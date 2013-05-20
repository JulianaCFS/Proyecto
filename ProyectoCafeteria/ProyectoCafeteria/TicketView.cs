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
			//throw new System.NotImplementedException ();
			ImprimirTicket imprimirTicket = new ImprimirTicket();
			imprimirTicket.Show();
			this.Destroy ();
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
				//Console.WriteLine("el indice es: {0}", index);
				if(index == 0)
					treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index).Visible=false;
				else
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
	
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
		}

		public void totalTicket()
		{
			
				double precioTotal= 0;

				IDbCommand dbCommand = dbConnection.CreateCommand ();
				dbCommand.CommandText = "select precio,cantidad from pedidos ";
				
				IDataReader dataReader = dbCommand.ExecuteReader ();
			
				while(dataReader.Read ()) {

					double precio = dataReader.GetDouble(0);
					int cantidad = dataReader.GetInt32(1);
					precioTotal = precioTotal+(precio * cantidad);
				//Console.WriteLine("El precio y la cantidad es: {0}", precioTotal);

				}	

				labelTotalTicket.Markup = "<span size='xx-large' weight='bold'>"+ "Total: "+Convert.ToString(precioTotal)+ " Euros"+ "</span>";
				dataReader.Close ();
			
		}

		protected void OnTreeviewRowActivated (object o, RowActivatedArgs args)
		{
			TreeModel model;
			//registro seleccionado
			TreeIter iterSelected;

			if (treeview.Selection.GetSelected (out model, out iterSelected)) {
				string cantidad = (string)model.GetValue (iterSelected, 4);

				SeleccionCantidad pantallaseleccion = new SeleccionCantidad (treeview, cantidad, 0, labelTotalTicket);
				pantallaseleccion.Show ();
		}
	}
	}
}

