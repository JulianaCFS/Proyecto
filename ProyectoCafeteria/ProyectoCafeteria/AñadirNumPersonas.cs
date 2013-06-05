using System;
using Gtk;
using System.Data;
using Npgsql;

namespace ProyectoCafeteria
{
	public partial class AñadirNumPersonas : Gtk.Window
	{	private IDbConnection dbConnection;
		
		public AñadirNumPersonas () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
		
			
			//string connectionString = "Server=localhost;Database=dbcafeteria;User Id=dbcafeteria;Password=dbcafeteria";
			//ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			int maximo=0;
			double numPersonas = spinNumPersonas.Value;
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "select maximo from mesas LIMIT 1";
			
			IDataReader datareader = dbCommand.ExecuteReader ();
			
			if(datareader.Read ()){
			
				maximo = datareader.GetInt32(0);
				//Console.WriteLine(maximo);
			}
			
			//Console.WriteLine(numPersonas);

			calculoMesa(numPersonas,maximo);
			this.Destroy();
		}
		public void calculoMesa(double numPersonas,int max){
			
			int numMesas;
			int resto;
			DateTime date1 = DateTime.Now;
			String identificadorTicket = String.Format("{0:MMddyyyyHHmmss}", date1); 
			long idmesa = 0;
			
			
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			
			
			if(numPersonas >=1 && numPersonas <=max){
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
				
				//si dejo da error
				dbCommand.CommandText = "insert into ticket (identificador, fk_idmesa) values (:identificadorTicket, :idmesa)";
				DbCommandExtensions.AddParameter (dbCommand, "identificadorTicket",identificadorTicket);
				DbCommandExtensions.AddParameter (dbCommand, "idmesa",idmesa);
				
				dbCommand.ExecuteNonQuery ();
			}else{
				
				numMesas = (int)numPersonas / max;
				resto = /*(int)numPersonas-(max * numMesas);*/(int)numPersonas % max;
				
				
				if(resto != 0){
					
					numMesas= numMesas+1;
					
				}
				//long[] mesas =new long[numMesas];
				
				dbCommand.CommandText =  "select idmesa from mesas where disponible = 'si' order by idmesa LIMIT 2";
				DbCommandExtensions.AddParameter (dbCommand, "numMesas",numMesas);
				IDataReader datareader = dbCommand.ExecuteReader ();
				
				
				while(datareader.Read ()){
					
					for (int index = 0; index < datareader.FieldCount; index++)
				    {
					
						idmesa = datareader.GetInt64(0);
						Console.WriteLine(idmesa);
				
						//actualizo la tabla idmesa
						
						//dbCommand.CommandText =  "update mesas set disponible='no' where idmesa=1;update mesas set disponible='no' where idmesa=2;";
						dbCommand.CommandText = "update mesas set disponible='no' where idmesa=:idmesa;";
						DbCommandExtensions.AddParameter (dbCommand, "idmesa", idmesa);
						Console.WriteLine(dbCommand.CommandText);
						
						dbCommand.ExecuteNonQuery();
						
						
						/*dbCommand.CommandText = "insert into ticket (identificador, fk_idmesa) values (:identificadorTicket, :idmesa)";
						DbCommandExtensions.AddParameter (dbCommand, "identificadorTicket",identificadorTicket);
						DbCommandExtensions.AddParameter (dbCommand, "idmesa",idmesa);
						
						dbCommand.ExecuteNonQuery ();*/
						
					}
					
				}
				
				
						dbCommand.CommandText =  "update mesas set disponible='no' where idmesa=:idmesa;";
						DbCommandExtensions.AddParameter (dbCommand, "idmesa", 2);
						Console.WriteLine(dbCommand.CommandText);
						
						dbCommand.ExecuteNonQuery ();
			
			}
			
			
		}
		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
		}
	}
}

