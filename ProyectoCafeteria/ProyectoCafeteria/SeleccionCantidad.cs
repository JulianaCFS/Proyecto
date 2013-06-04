using System;

using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;

namespace ProyectoCafeteria
{
	public partial class SeleccionCantidad : Gtk.Window
	{
		private IDbConnection dbConnection;
		private int pant;
		private TreeView treeview;
		private Label labelPrecioTotal;

		public SeleccionCantidad (TreeView TV, string cantidad, int pantalla, Label labelPrecio) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			/*string connectionString = "Server=localhost;Database=dbcafeteria;User Id=dbcafeteria;Password=dbcafeteria";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);*/
			dbConnection = ApplicationContext.Instance.DbConnection;
			//dbConnection.Open ();

			pant = pantalla;
			treeview = TV;
			labelPrecioTotal = labelPrecio; //sera el label donde mostraremos el total.
	
			spincantidad.Value = Convert.ToDouble (cantidad);
		}

		protected void OnBotonAceptarClicked (object sender, EventArgs e)
		{

			if (pant != 0) { //viene de la pantalla bebidas frias,..
				SeleccionCantidadNoTicket ();
				
			}
			else
			{
				//la pantalla es la del ticket, pantalla ticket  es el numero 0
				SeleccionCantidadTicket ();
				
			}
		    

			this.Destroy ();
		}

		public void SeleccionCantidadNoTicket()
		{
			double cant = spincantidad.Value;
			//Console.WriteLine("Cantidad seleccionada :" + cant);

			Gtk.TreeSelection selection = treeview.Selection;
			Gtk.TreeIter iter;
			selection.GetSelected(out iter);

			string cadena_cantidad = Convert.ToString (cant);
			treeview.Model.SetValue (iter, 4, cadena_cantidad);
		
		}

		public void SeleccionCantidadTicket()
		{

			double cant = spincantidad.Value;
		
			Gtk.TreeSelection selection = treeview.Selection;
			Gtk.TreeIter iter;
			selection.GetSelected(out iter);

			string cadena_cantidad = Convert.ToString (cant);
			treeview.Model.SetValue (iter, 4, cadena_cantidad);
		
			TreeModel model;
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "update pedidos set cantidad=:cantidad where id=:id";

			if (treeview.Selection.GetSelected (out model, out iter)) {
				long id = long.Parse (treeview.Model.GetValue (iter, 0).ToString ());
				DbCommandExtensions.AddParameter (dbCommand, "cantidad", cant);
				DbCommandExtensions.AddParameter (dbCommand, "id", id);
			}

			dbCommand.ExecuteNonQuery ();

		    totalTicket (labelPrecioTotal);

		}

		public void totalTicket(Label labelPrecioT)
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

			labelPrecioT.Markup = "<span size='xx-large' weight='bold'>"+ "Total: "+Convert.ToString(precioTotal)+ " Euros"+ "</span>";
			dataReader.Close ();

		}

		
		protected void OnBotonCancelarClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}

		
	}
}


