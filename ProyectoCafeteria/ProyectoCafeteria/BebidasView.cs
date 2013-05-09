using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;


namespace ProyectoCafeteria
{
	public partial class BebidasView : Gtk.Window
	{	
		private IDbConnection dbConnection;
		private ListStore listStore;//listStore que utilizo para todos los métodos.
		private Label total;
		
		public BebidasView (Label labelTotal) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			total = labelTotal;
			//para conectarse a la bd 
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select * from bebidasfrias ";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			
			llenarTablaBebidasFrias (treeView, dataReader);
			dataReader.Close ();
		}
		
		public  void AppendColumns(TreeView treeView, IDataReader dataReader)
		{
			
			
			for (int index = 0; index < dataReader.FieldCount; index++)
			{
				Console.WriteLine("el indice es: {0}", index);
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
			
			}
	
			
			Gtk.ListStore listStoreCombo = new ListStore(typeof(string));
			treeView.Model = listStoreCombo;
			
			// Values to be chosen in the ComboBox
			Gtk.ListStore comboModel = new ListStore(typeof(string));
			Gtk.ComboBox comboBox = new ComboBox(comboModel);
			comboBox.AppendText("Selecciona una cantidad");
			comboBox.AppendText("1");
			comboBox.AppendText("2");
			comboBox.AppendText("3");
			comboBox.Active = 0;
			
			Gtk.TreeViewColumn comboCol = new TreeViewColumn();
			Gtk.CellRendererCombo comboCell = new CellRendererCombo();
			comboCol.Title = "Combo Column";
			comboCol.PackStart(comboCell, true);
			comboCol.AddAttribute(comboCell, "text", 4);
			comboCell.Editable = true;
			comboCell.Edited += OnEdited;
			comboCell.TextColumn = 0;
			comboCell.Text = comboBox.ActiveText;
			comboCell.Model = comboModel;
			comboCell.WidthChars = 20;
			
			treeView.AppendColumn(comboCol);
		
		
		}
		
		public  void OnEdited(object sender, Gtk.EditedArgs args)
		{
				Gtk.TreeSelection selection = treeView.Selection;
				Gtk.TreeIter iter;
				selection.GetSelected(out iter);
				
				treeView.Model.SetValue(iter, 4, args.NewText); // the CellRendererText
		}
		
		public  void llenarTablaBebidasFrias(TreeView treeView, IDataReader dataReader) 
		{	
			//TreeViewExtensions.ClearColumns (treeView);
			AppendColumns (treeView, dataReader);	//hacer cabecera	
			Type[] types = GetTypes (typeof(string), dataReader.FieldCount+1);
			
			listStore = new ListStore(types);
			treeView.Model = listStore;
			Fill (dataReader);
			
			
		}
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
		}
		
		public void Fill(IDataReader dataReader)
		{
			while(dataReader.Read ()) {
				List<string> values = new List<string>();
				for (int index = 0; index < dataReader.FieldCount; index++)
				{
					values.Add (dataReader[index].ToString ());
					Console.WriteLine("El iden es: {0} {1} ", dataReader[index].ToString (), index);
					
				}
				values.Add("Selecciona una cantidad");
				listStore.AppendValues (values.ToArray());
			}
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			treeView.Model = listStore;
			TreeModel tModel;
			treeView.Selection.Mode = SelectionMode.Multiple;
			TreeSelection tSelect = treeView.Selection;
			tSelect.SelectAll();			//selecciona todas las filas necesario para obtener la informacion de todas.
			Array treePaths = tSelect.GetSelectedRows(out tModel);
			
			foreach(TreePath tPath in treePaths)
			{
				TreeIter iter;
				
				if(listStore.GetIter(out iter, tPath))
				{
					
					string nombre = (string)listStore.GetValue(iter,1);
					string tamano = (string)listStore.GetValue(iter,2);
					string precio = (string)listStore.GetValue(iter,3);
					string cantidad = (string)listStore.GetValue(iter,4);
					
					/*Console.WriteLine("Nombre :" + nombre);
					Console.WriteLine("Tipo :" + tamano);
					Console.WriteLine("Precio :" + precio);
					Console.WriteLine("Cantidad :" + cantidad);*/
					if(!cantidad.Equals("Selecciona una cantidad"))
					{
						IDbCommand dbCommand = dbConnection.CreateCommand ();
						
						dbCommand.CommandText = "insert into pedidos (nombre, tamano, precio,cantidad) values (:nombre, :tamano, :precio,:cantidad)";
						
						
						DbCommandExtensions.AddParameter (dbCommand, "nombre",nombre);
						DbCommandExtensions.AddParameter (dbCommand, "tamano", tamano);
						DbCommandExtensions.AddParameter (dbCommand, "precio", Convert.ToDouble(precio));
						DbCommandExtensions.AddParameter (dbCommand, "cantidad", Convert.ToInt32(cantidad));
						
						dbCommand.ExecuteNonQuery ();
			
						Destroy ();
						
					}
				}
			}
			calculoLabelTotal();
			}
			public void calculoLabelTotal()
			{
			
				double precioTotal= 0;
				//para conectarse a la bd 
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select precio,cantidad from pedidos ";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			while(dataReader.Read ()) {
				
				//for (int index = 0; index < dataReader.FieldCount; index++)
				//{
					
					double precio = dataReader.GetDouble(0);
					int cantidad = dataReader.GetInt32(1);
					precioTotal = precioTotal+(precio * cantidad);
				Console.WriteLine("El precio y la cantidad es: {0}", precioTotal);
					
				//}
			}
			
				total.Text = "Total: "+Convert.ToString(precioTotal)+ " Euros";
			
				dataReader.Close ();
			
			
			
			
			}

		
		protected void OnBotonInicioClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonEliminarClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
			TreeIter treeIter;
			treeView.Selection.GetSelected(out treeIter);
			treeView.Model.SetValue(treeIter, 4, "Selecciona una cantidad");
		}
		

		protected void OnBotonTicketClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
			this.Destroy();
			TicketView ticketView =new TicketView();
			ticketView.Show();
			
		}
	}
}

