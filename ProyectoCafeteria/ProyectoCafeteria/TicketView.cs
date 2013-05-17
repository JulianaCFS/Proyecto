using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public partial class TicketView : Gtk.Window
	{	private IDbConnection dbConnection;
		private ListStore liststore;//listStore que utilizo para todos los métodos.
		public TicketView () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select id,nombre,tamano,precio,cantidad from pedidos ";
				
			IDataReader datareader = dbCommand.ExecuteReader ();
			
			mostrarTablaPedidos (treeview, datareader);
			datareader.Close ();
			totalTicket();
			
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnBotonEliminarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
		public  void mostrarTablaPedidos(TreeView treeview, IDataReader datareader) 
		{	
			//TreeViewExtensions.ClearColumns (treeView);
			AppendColumns (treeview, datareader);	//hacer cabecera	
			Type[] types = GetTypes (typeof(string), datareader.FieldCount+1);
			
			liststore = new ListStore(types);
			treeview.Model = liststore;
			Fill (datareader);
			
		}
		public void Fill(IDataReader datareader)
		{
			while(datareader.Read ()) {
				List<string> values = new List<string>();
				for (int index = 0; index < datareader.FieldCount; index++)
				{
					values.Add (datareader[index].ToString ());
					Console.WriteLine("El iden es: {0} {1} ", datareader[index].ToString (), index);
					
				}
				//values.Add("Selecciona una cantidad");
				liststore.AppendValues (values.ToArray());
			}
		}
		public  void AppendColumns(TreeView treeView, IDataReader dataReader)
		{
			
			
			for (int index = 0; index < dataReader.FieldCount-1; index++)
			{
				Console.WriteLine("el indice es: {0}", index);
				if(index == 0)
					treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index).Visible=false;
				else
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
			comboCol.Title = "Combo Cantidad";
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
				Gtk.TreeSelection selection = treeview.Selection;
				Gtk.TreeIter iter;
				selection.GetSelected(out iter);
		
				treeview.Model.SetValue(iter, 4, args.NewText); // the CellRendererText
			
			    liststore = (ListStore)treeview.Model;
		        long id = long.Parse (liststore.GetValue (iter, 0).ToString ());
				actualizarPedido(args.NewText, id);
		}
		public void actualizarPedido(String cantidad,long id){
			
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				 "update pedidos set cantidad=:cantidad where id=:id";
			
			DbCommandExtensions.AddParameter (dbCommand, "cantidad", cantidad);
			DbCommandExtensions.AddParameter (dbCommand, "id", id);
				
			dbCommand.ExecuteNonQuery ();
			totalTicket();
		
			
		}
		
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
		}
		public void totalTicket(){
			
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
			
				labelTotal.Text = "Total: "+Convert.ToString(precioTotal)+ " Euros";
			
				dataReader.Close ();
			
		}
	}
}

