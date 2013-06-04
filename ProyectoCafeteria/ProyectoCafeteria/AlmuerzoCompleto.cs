using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;


namespace ProyectoCafeteria
{
	public partial class AlmuerzoCompleto : Gtk.Window
	{	private IDbConnection dbConnection;
		public AlmuerzoCompleto () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			labelAlmuerzoCompleto.Markup = "<span size='xx-large' weight='bold'>ALMUERZO COMPLETO</span>";
			//botonNuevoPedidoMainWindow = botonNP;
			//totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			cargarComboBebidas();
		}
		public void cargarComboBebidas(){
			
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
			
			
			cargarComboBocadillo();
			
		}
		public void cargarComboBocadillo(){
			
			int cont=0;
			int index = 0;
			//string valorCafe = comboboxCafe.value();
			//Console.WriteLine(valorCafe);
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = "select nombre from bocadillos";

			IDataReader dataReader = dbCommand.ExecuteReader ();

			comboboxBocadillo.InsertText(cont,"Seleccione un Bocadillo");
			cont++;

			do
			{
				while (dataReader.Read())
				{
					comboboxBocadillo.InsertText(cont,dataReader[index].ToString ());
					cont++;
				}
				index++;
				
			} while (dataReader.NextResult());

			dataReader.Close ();
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
			dbCommand.CommandText = "select precio from almuerzocompleto";

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
		protected void OnBotonAtrasClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			
		}

		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}

