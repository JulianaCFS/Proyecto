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
		string valorComboBebida, valorComboBocadillo, valorComboCafe;
		private Label totalMainWindow;
		private Button botonNuevoPedidoMainWindow;
			
		public AlmuerzoCompleto (Label labelTotal,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			labelAlmuerzoCompleto.Markup = "<span size='xx-large' weight='bold'>ALMUERZO COMPLETO</span>";
			botonNuevoPedidoMainWindow = botonNP;
			totalMainWindow = labelTotal;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			cargarComboBebidas();
			cargarComboBocadillo();
			cargarComboPrecio();
			cargarComboCafe();
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
			
			comboboxBebida.Active= 0;
			
			
			//onsole.WriteLine(valor);
			
			
			
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
			
			comboboxBocadillo.Active= 0;
			dataReader.Close ();
			
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
			
			comboboxCafe.Active= 0;
			
			
			
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
			
			comboboxPrecio.Active= 0;
			
					
			
			
				
		}
		
		protected void OnBotonAtrasClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			if((comboboxBebida.Active != 0)&&(comboboxBocadillo.Active !=0)&&(comboboxCafe.Active!=0)&&(spinbuttonCantidad.Value!=0)){
			
			string cadena = "Almuerzo Completo: "+valorComboBebida+", "+valorComboBocadillo +", "+valorComboCafe;
			IDbCommand dbCommand = dbConnection.CreateCommand ();
						
			dbCommand.CommandText = "insert into pedidos (nombre, tamano, precio,cantidad) values (:nombre, :tamano, :precio,:cantidad)";

			DbCommandExtensions.AddParameter (dbCommand, "nombre",cadena);
			DbCommandExtensions.AddParameter (dbCommand, "tamano", "Normal");
			DbCommandExtensions.AddParameter (dbCommand, "precio", Convert.ToDouble(comboboxPrecio.ActiveText));
			DbCommandExtensions.AddParameter (dbCommand, "cantidad", Convert.ToInt32(spinbuttonCantidad.Value));
						
						dbCommand.ExecuteNonQuery ();
			
			CalculoLabelMain calculoLabel = new CalculoLabelMain();
			calculoLabel.calculoLabelTotal(totalMainWindow,botonNuevoPedidoMainWindow);
			Destroy ();
			}else{
				MensajeComboInfo mensaje = new MensajeComboInfo();
				mensaje.Show();
			}
						
			
		}
		

		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{	
			comboboxBocadillo.Active= 0;
			comboboxBebida.Active= 0;
			comboboxCafe.Active= 0;
			comboboxPrecio.Active= 0;
			spinbuttonCantidad.Value=0;
		}


		protected void OnComboboxBebidaChanged (object sender, System.EventArgs e)
		{
			

                 valorComboBebida = comboboxBebida.ActiveText;   
             	
		}

		protected void OnComboboxBocadilloChanged (object sender, System.EventArgs e)
		{
			 valorComboBocadillo = comboboxBocadillo.ActiveText; 
		}

		protected void OnComboboxCafeChanged (object sender, System.EventArgs e)
		{
			valorComboCafe = comboboxCafe.ActiveText; 
		}
	}
}

