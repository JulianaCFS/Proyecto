using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;

namespace ProyectoCafeteria
{
	public partial class AlmuerzoParteView : Gtk.Window
	{
		
		private IDbConnection dbConnection;
		//private Label totalMainWindow;
		//private Button botonNuevoPedidoMainWindow; 
		public AlmuerzoParteView (Label labelTotalMainWindow,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			labelAlmuerzoParte.Markup = "<span size='xx-large' weight='bold'>ALMUERZO PARTE</span>";
			//botonNuevoPedidoMainWindow = botonNP;
			//totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			cargarComboBebidas();
			
		}
		public void cargarComboBebidas()
		{
			int cont=0;
			int index = 0;
			
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = "select nombre from bebidasfrias";

			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			comboboxBebida.InsertText(cont,"Seleccione una bebida");
			cont++;

			do
			{
				while (dataReader.Read())
				{
					comboboxBebida.InsertText(cont,dataReader[index].ToString ());
					cont++;
				}
				index++;
				
			} while (dataReader.NextResult());


			dataReader.Close ();
			
			//comboboxBebida.Active= index_activado;
			
			
			cargarComboCafe();
			
		}
		public void cargarComboCafe()
		{
			int cont=0;
			int index = 0;
			//string valorCafe = comboboxCafe.value();
			//Console.WriteLine(valorCafe);
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = "select nombre from bebidascalientes";

			IDataReader dataReader = dbCommand.ExecuteReader ();

			comboboxCafe.InsertText(cont,"Seleccione un Café");
			cont++;

			do
			{
				while (dataReader.Read())
				{
					comboboxCafe.InsertText(cont,dataReader[index].ToString ());
					cont++;
				}
				index++;
				
			} while (dataReader.NextResult());

			dataReader.Close ();
			
			//comboboxCafe.Active= index_activado;
			
			cargarComboPrecio();
			
		}
		public void cargarComboPrecio()
		{
			int cont=0;
			int index = 0;
			/*double valorPrecio = comboboxPrecio.value();
			Console.WriteLine(valorPrecio);*/
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = "select precio from almuerzoparte";

			IDataReader dataReader = dbCommand.ExecuteReader ();


			do
			{
				while (dataReader.Read())
				{
					comboboxPrecio.InsertText(cont,dataReader[index].ToString ());
					
				}
				index++;
				
			} while (dataReader.NextResult());

			dataReader.Close ();
			
			//comboboxPrecio.Active= index_activado;
			
			cargarSpinButtonCantidad();
			
				
		}
		public void cargarSpinButtonCantidad(){
			
			 double cant = spinbuttonCantidad.Value;
			
			//string cadena_cantidad = Convert.ToString (cant);
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "update pedidos set cantidad=:cantidad";
			
			DbCommandExtensions.AddParameter (dbCommand, "cantidad", cant);
			//DbCommandExtensions.AddParameter (dbCommand, "id", id);
			
			//totalTicket (labelPrecioTotal);
		}
		/*public void totalTicket(Label labelPrecioT)
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

		}*/

		
		
		protected void OnBotonAtrasClicked (object sender, System.EventArgs e)
		{
			this.Destroy ();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{	
			int IdBebida = comboboxBebida.Active;
			int IdCafe = comboboxCafe.Active;
			int IdPrecio = comboboxPrecio.Active;
			spinbuttonCantidad.Value = 0;
		
			//if(IdBebida != ""){}
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			
			dbCommand.CommandText = "insert into pedidos (nombre, tamano, precio,cantidad) values (:nombre, :tamano, :precio,:cantidad)";

			DbCommandExtensions.AddParameter (dbCommand, "nombre",Convert.ToDouble(IdBebida));
			DbCommandExtensions.AddParameter (dbCommand, "tamano",Convert.ToDouble(IdCafe));
			DbCommandExtensions.AddParameter (dbCommand, "precio", Convert.ToDouble(IdPrecio));
			DbCommandExtensions.AddParameter (dbCommand, "cantidad", Convert.ToInt64(spinbuttonCantidad));
			
			dbCommand.ExecuteNonQuery ();
			
			Destroy ();	
		}
		
		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
	}
}

