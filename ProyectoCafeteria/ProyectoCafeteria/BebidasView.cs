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
		private Button botonNuevoPedido;
		
		public BebidasView (Label labelTotal,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelBF.Markup = "<span size='xx-large' weight='bold'>Bebidas Frias</span>";
			botonNuevoPedido = botonNP;
			

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
				//Console.WriteLine("el indice es: {0}", index);
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
			
			}
	
			//Añadimos la columna de la cantidad porque en la BBDD no tenemos este campo.
			TreeViewColumn cantidad = new TreeViewColumn();
			cantidad.Title = "Cantidad";
			CellRendererText cant = new CellRendererText();
			cantidad.PackStart(cant, true);
			cantidad.AddAttribute(cant,"text",4);

			treeView.AppendColumn(cantidad);
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
					//Console.WriteLine("El iden es: {0} {1} ", dataReader[index].ToString (), index);
					
				}
				values.Add("0");
				listStore.AppendValues (values.ToArray());
			}
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
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
					
				/*	Console.WriteLine("Nombre :" + nombre);
					Console.WriteLine("Tipo :" + tamano);
					Console.WriteLine("Precio :" + precio);
					Console.WriteLine("Cantidad :" + cantidad);*/

					if(!cantidad.Equals("0"))
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
				
				//hacer la consulta bd
				IDbCommand dbCommand = dbConnection.CreateCommand ();
				dbCommand.CommandText =  "select precio,cantidad from pedidos ";
				
				IDataReader dataReader = dbCommand.ExecuteReader ();
			
				while(dataReader.Read ()) {

					double precio = dataReader.GetDouble(0);
					int cantidad = dataReader.GetInt32(1);
					precioTotal = precioTotal+(precio * cantidad);
					
				}

				total.Markup = "<span size='xx-large' weight='bold'>"+ " Creando Pedido    Total: "+Convert.ToString(precioTotal)+ " Euros"+ "</span>";
				botonNuevoPedido.Visible=true;
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
			treeView.Model.SetValue(treeIter, 4, "0");
		}
		

		/*protected void OnBotonTicketClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
			this.Destroy();
			TicketView ticketView =new TicketView(total);
			ticketView.Show();
			
		}*/

		protected void OnTreeViewRowActivated (object o, RowActivatedArgs args)
		{
			TreeModel model;
			//registro seleccionado
			TreeIter iterSelected;

			if (treeView.Selection.GetSelected (out model, out iterSelected)) {
				string cantidad = (string)model.GetValue (iterSelected, 4);
			
				SeleccionCantidad pantallaseleccion = new SeleccionCantidad (treeView, cantidad, 1, labelBF);
				pantallaseleccion.Show ();
		}
	}
	}
}

