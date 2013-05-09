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
				"select nombre,tamano,precio,cantidad from pedidos ";
				
			IDataReader datareader = dbCommand.ExecuteReader ();
			
			mostrarTablaPedidos (treeview, datareader);
			datareader.Close ();
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
			
			
			for (int index = 0; index < dataReader.FieldCount; index++)
			{
				Console.WriteLine("el indice es: {0}", index);
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
			
			}
		}
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
		}
	}
}

