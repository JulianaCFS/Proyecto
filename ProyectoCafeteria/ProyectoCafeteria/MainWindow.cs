using System;
using Gtk;
using System.Data;
using Proyecto.Ad;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;




public partial class MainWindow: Gtk.Window
{	private IDbConnection dbConnection;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		total.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
		buttonNuevoPedido.Visible=true;
				 
		
		
		
		Gdk.Color fondo = new Gdk.Color();
		Gdk.Color.Parse("red", ref fondo);
		buttonNuevoPedido.ModifyBg(StateType.Normal, fondo);
		
	
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBotonBebidasFriasClicked (object sender, System.EventArgs e)
	{
		
		showTablaBebidas();          
		
		
	}
	private void showTablaBebidas()
	{
		BebidasView bebidasView = new BebidasView(total,buttonNuevoPedido);
		bebidasView.Show();
	}
	
	
	//la llamada del metodo que calcularas el total que estara en bebidasview que tendras como parametros el label 
	//pantalla

	protected void OnButton2Clicked (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
	}

	protected void OnButton3Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton4Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton5Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton6Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton7Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton8Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnButton9Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnBotonticketClicked (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
			
			TicketView ticketview = new TicketView(total,buttonNuevoPedido);//le paso el label del total, para que cuando imprima el ticket, poner pantalla inicio el total a 0
			ticketview.Show();
	}

	protected void OnButtonNuevoPedidoClicked (object sender, System.EventArgs e)
	{
		
		AñadirNumPersonas añadirNumPersonas = new AñadirNumPersonas ();
		añadirNumPersonas.Show();
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
			
			total.Markup = "<span size='xx-large' weight='bold'>Inicie Pedido    Total: 0,0 Euros</span>";
			buttonNuevoPedido.Visible=false;
				
	}
}
