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
		private Label totalMain;
		private Button botonNuevoPedido;
		public ImprimirTicket (Label labelTotal,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			totalMain = labelTotal;
			botonNuevoPedido = botonNP;
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
			
			totalMain.Markup = "<span size='xx-large' weight='bold'>Inicie Pedido   Total: 0,0 Euros</span>";
			botonNuevoPedido.Visible=false;
			
				
			this.Destroy ();
		}
	}
}

