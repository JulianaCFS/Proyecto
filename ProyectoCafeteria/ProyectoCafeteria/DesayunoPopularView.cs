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
		
		public DesayunoPopularView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelDesayunoPopular.Markup = "<span size='xx-large' weight='bold'>DESAYUNO POPULAR</span>";
			//botonNuevoPedidoMainWindow = botonNP;
			//totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			cargarComboCafe();
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
			
			//comboboxCafe.Active= index_activado;
			
			cargarComboComida();
			
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

			dataReader.Close ();
			cargarComboPrecio();
			
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
	}
}

