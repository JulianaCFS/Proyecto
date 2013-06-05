using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;


namespace ProyectoCafeteria
{
	public class CalculoLabelMain
	{	private IDbConnection dbConnection;
		public CalculoLabelMain ()
		{
		}
		public void calculoLabelTotal(Label total, Button botonNuevoPedido)
		{
				
				double precioTotal= 0;
				dbConnection = ApplicationContext.Instance.DbConnection;
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
				botonNuevoPedido.Visible=false;
				dataReader.Close ();

			}
	}	
}

