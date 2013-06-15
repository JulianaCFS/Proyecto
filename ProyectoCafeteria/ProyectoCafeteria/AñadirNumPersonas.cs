using System;
using Gtk;
using System.Data;
using Npgsql;

namespace ProyectoCafeteria
{
	public partial class AñadirNumPersonas : Gtk.Window
	{	private IDbConnection dbConnection;
		private Label totalMainWindow;
		private Button botonNuevoPedidoMainWindow;
		
		public AñadirNumPersonas (Label labelTotalMainWindow,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			botonNuevoPedidoMainWindow = botonNP;
			totalMainWindow = labelTotalMainWindow;
			
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
		
			MainWindow.HasIniciadoPedido = true; //Cuando le demos a aceptar entonces ya habremos iniciado sesion. 


					
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			int maximo=0;
			double numPersonas = spinNumPersonas.Value;
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "select maximo from mesas LIMIT 1";
			
			IDataReader datareader = dbCommand.ExecuteReader ();
			
			if(datareader.Read ()){
			
				maximo = datareader.GetInt32(0);
				
			}
			
			

			calculoMesa(numPersonas,maximo);
			this.Destroy();
		}
		public void calculoMesa(double numPersonas,int max){
			
			int numMesas;
			int resto;
			DateTime date1 = DateTime.Now;
			String identificadorTicket = String.Format("{0:MMddyyyyHHmmss}", date1); 
			long idmesa=0;
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			
			dbCommand.CommandText =  "select COUNT(idmesa)from mesas where disponible = 'si'";
			int mesasDisponibles = Convert.ToInt32(dbCommand.ExecuteScalar());
			
			
			if((numPersonas >=1 && numPersonas <=max && mesasDisponibles == 0) ){
				AlertaMesaNoDisponible alertaMesaNoDisponible = new AlertaMesaNoDisponible();
				alertaMesaNoDisponible.Show();
				botonNuevoPedidoMainWindow.Visible=true;
				totalMainWindow.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
				this.Destroy();
			}
			
			else if((numPersonas >=1 && numPersonas <=max && mesasDisponibles != 0 ))
			{
				//recogo el idmesa de la tabla mesas
				
				dbCommand.CommandText =  "select idmesa from mesas where disponible = 'si' order by idmesa LIMIT 1";
				IDataReader datareader = dbCommand.ExecuteReader ();
				
				if(datareader.Read ()){
			    
				idmesa = datareader.GetInt64(0);
				
				}
				//actualizo la tabla idmesa
				dbCommand.CommandText =  "update mesas set disponible='no' where idmesa=:idmesa";
				DbCommandExtensions.AddParameter (dbCommand, "idmesa", idmesa);
				
				dbCommand.ExecuteNonQuery ();
				
				
				dbCommand.CommandText = "insert into ticket (identificador, fk_idmesa) values (:identificadorTicket, :idmesa)";
				DbCommandExtensions.AddParameter (dbCommand, "identificadorTicket",identificadorTicket);
				DbCommandExtensions.AddParameter (dbCommand, "idmesa",idmesa);
				
				dbCommand.ExecuteNonQuery ();

			}
			
			else{  //Como ahora estamos en la opcion de el numero de personas es mayor que es maximo,  calcularemos el numero de mesas
				//para ese numero de personas y luego del calculo pondremos otra sentencia if para ver si el numero de mesas que se necesitan es mayor o igual
				//al numero de mesas que hay disponibles.
				
				numMesas = (int)numPersonas / max;
				resto = (int)numPersonas % max;
				
				if(resto != 0){
					
					numMesas= numMesas+1;
					
				}

				if (mesasDisponibles >= numMesas) 
				{
					dbCommand.CommandText = "select idmesa from mesas where disponible = 'si' order by idmesa LIMIT :numMesas";
					DbCommandExtensions.AddParameter (dbCommand, "numMesas", numMesas);
					IDataReader datareader = dbCommand.ExecuteReader ();


					while (datareader.Read ()) {

						for (int index = 0; index < datareader.FieldCount; index++) {

							idmesa = datareader.GetInt64 (0);
							Console.WriteLine (idmesa);

							//actualizo la tabla idmesa

							IDbCommand dbCommand2 = dbConnection.CreateCommand ();
							dbCommand2.CommandText = "update mesas set disponible='no' where idmesa=:idmesa;";
							DbCommandExtensions.AddParameter (dbCommand2, "idmesa", idmesa);

							dbCommand2.ExecuteNonQuery ();

							dbCommand2.CommandText = "insert into ticket (identificador, fk_idmesa) values (:identificadorTicket, :idmesa)";
							DbCommandExtensions.AddParameter (dbCommand2, "identificadorTicket", identificadorTicket);
							DbCommandExtensions.AddParameter (dbCommand2, "idmesa", idmesa);

							dbCommand2.ExecuteNonQuery ();

						  }

					   }
				    }
					else
					{
						AlertaMesaNoDisponible alertaMesaNoDisponible = new AlertaMesaNoDisponible();
						alertaMesaNoDisponible.Show();
						botonNuevoPedidoMainWindow.Visible=true;
						totalMainWindow.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
						this.Destroy();

					}
				}

			}
			
		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			totalMainWindow.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
			botonNuevoPedidoMainWindow.Visible=true;
			this.Destroy ();
		}
	}
}

