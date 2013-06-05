using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;

namespace ProyectoCafeteria
{
	public partial class DesayunoPopularView : Gtk.Window
	{	private IDbConnection dbConnection;
		private Label totalMainWindow;
		private Button botonNuevoPedidoMainWindow; 
		string valorComboCafe, valorComboComida;
		
		public DesayunoPopularView (Label labelTotalMainWindow,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelDesayunoPopular.Markup = "<span size='xx-large' weight='bold'>DESAYUNO POPULAR</span>";
			botonNuevoPedidoMainWindow = botonNP;
			totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			cargarComboCafe();
			cargarComboComida();
			cargarComboPrecio();
		}
		public void cargarComboCafe()
		{
			int cont=0;
			int index = 0;
			//string valorCafe = comboboxCafe.value();
			//Console.WriteLine(valorCafe);
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = "select nombre from bebidascalientes where nombre like '%leche'";

			IDataReader dataReader = dbCommand.ExecuteReader ();

			comboboxCafe.InsertText(cont,"Seleccione un Articulo");
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
		public void cargarComboComida(){
			
			int cont=0;
			int index = 0;
			//string valorCafe = comboboxCafe.value();
			//Console.WriteLine(valorCafe);
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			

			IDataReader dataReader = dbCommand.ExecuteReader ();

			comboboxComida.InsertText(cont,"Seleccione un Artículo");
			comboboxComida.InsertText(cont,"Tostada con Tomate");
			comboboxComida.InsertText(cont,"Tostada con Aceite");
			comboboxComida.InsertText(cont,"Croissant Grande");
			cont++;

			do
			{
				while (dataReader.Read())
				{
					comboboxComida.InsertText(cont,dataReader[index].ToString ());
					cont++;
				}
				index++;
				
			} while (dataReader.NextResult());
			
			comboboxComida.Active = 0;
			dataReader.Close ();
			
			
		}
			public void cargarComboPrecio()
			{
				int cont=0;
				int index = 0;
				/*double valorPrecio = comboboxPrecio.value();
				Console.WriteLine(valorPrecio);*/
				
				IDbCommand dbCommand = dbConnection.CreateCommand ();
				dbCommand.CommandText = "select precio from desayunopopular";
	
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
			

		protected void OnComboboxCafeChanged (object sender, System.EventArgs e)
		{
			valorComboCafe = comboboxCafe.ActiveText; 
		}

		protected void OnComboboxComidaChanged (object sender, System.EventArgs e)
		{
			valorComboComida = comboboxComida.ActiveText;
		}

		protected void OnBotonAtrasClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{	
			if((comboboxComida.Active != 0)&&(comboboxCafe.Active!=0)&&(spinbuttonCantidad.Value!=0)){
			string cadena = "Desayuno Popular: "+valorComboComida+", "+valorComboCafe;
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
			comboboxComida.Active= 0;
			comboboxCafe.Active= 0;
			comboboxPrecio.Active= 0;
			spinbuttonCantidad.Value=0;
		}
	}
}

