using System;
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
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"delete from pedidos ";
			
			
			
			totalMain.Markup = "<span size='xx-large' weight='bold'>   Total: 0,0 Euros</span>";
			botonNuevoPedido.Visible=true;
			MainWindow.HasIniciadoPedido = false;
				
			this.Destroy ();
		}
	}
}

