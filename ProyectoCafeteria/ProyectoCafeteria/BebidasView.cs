using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;


namespace ProyectoCafeteria
{
	public partial class BebidasView : Gtk.Window
	{	private IDbConnection dbConnection;
		public BebidasView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			//para conectarse a la bd 
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select * from bebidasfrias ";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			TreeViewExtensions.Fill (treeView, dataReader);
			dataReader.Close ();
		}
	}
}

