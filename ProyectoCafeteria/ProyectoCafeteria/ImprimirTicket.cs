using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;


namespace ProyectoCafeteria
{
	public partial class ImprimirTicket : Gtk.Window
	{	private IDbConnection dbConnection;
		public ImprimirTicket () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"delete from pedidos ";
			
			IDataReader datareader = dbCommand.ExecuteReader ();
			datareader.Close ();
				
			this.Destroy ();
		}
	}
}

