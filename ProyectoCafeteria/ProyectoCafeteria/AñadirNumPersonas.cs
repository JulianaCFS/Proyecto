using System;
using Gtk;
using System.Data;
using Proyecto.Ad;
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
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();

			double numPersonas = spinNumPersonas.Value;
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "insert into numpersonas (numpersonas) values (:numpersonas)";
			//DbCommandExtensions.AddParameter (dbCommand, "numPersonas", numPersonas);
			DbCommandExtensions.AddParameter (dbCommand, "numpersonas",spinNumPersonas.Value);
			Console.WriteLine(numPersonas);
			
			
			this.Destroy();
		}

		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException ();
		}
	}
}

