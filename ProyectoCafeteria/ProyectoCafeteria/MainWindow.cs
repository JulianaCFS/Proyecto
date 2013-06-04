using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;





public partial class MainWindow: Gtk.Window
{	private IDbConnection dbConnection;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		total.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
		//buttonNuevoPedido.Visible=true;
		
		string connectionString = "Server=localhost;Database=dbcafeteria;User Id=dbcafeteria;Password=dbcafeteria";
		ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
		dbConnection = ApplicationContext.Instance.DbConnection;
		dbConnection.Open ();
				 
		
		//ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
		dbConnection = ApplicationContext.Instance.DbConnection;
		
		//Objeto fondo creado para poner un color de fondo en el boton "INICIAR PEDIDO"
		Gdk.Color fondo = new Gdk.Color();
		Gdk.Color.Parse("red", ref fondo);
		buttonNuevoPedido.ModifyBg(StateType.Normal, fondo);
		
		/*Label labelprueba = new Label ();
		
		labelprueba.Markup = "<span size='xx-large' weight='bold'> </span>";
		
		botonBebidasFrias.Label= "<span size='xx-large' weight='bold'> Bebidas Frías(refrescos,cervezas,batidos)</span>";
		*/
		
		
		// Guarda la imagen que esta en la misma carpeta a
 		// un objeto de Gtk.Image
		//Gtk.Image image = new Gtk.Image("cocacola.jpg");
		//byte[] bytes = image.Pixbuf.SaveToBuffer ("jpg");
		
		 
		
		/*IDbCommand dbCommand = dbConnection.CreateCommand ();
						
		dbCommand.CommandText = "insert into bebidasfrias (imagen) values (:imagen)";

		DbCommandExtensions.AddParameter (dbCommand, "imagen",bytes);*/
		
		//insert into bebidasfrias (nombre, imagen) values (:nombre, :imagen);
		//AddParameter imagen ... Value = bytes
		
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
	protected void OnBotonBebidasCalientesClicked (object sender, System.EventArgs e)
	{
		BebidasCalientesView bebidasCalientesView = new BebidasCalientesView(total,buttonNuevoPedido);
		bebidasCalientesView.Show();
	}


	protected void OnBotonBocadillosClicked (object sender, System.EventArgs e)
	{
		Bocadillos bocadillos = new Bocadillos(total,buttonNuevoPedido);
		bocadillos.Show();
	}
	protected void OnBotonAlmuerzoParteClicked (object sender, System.EventArgs e)
	{
		AlmuerzoParteView almuerzoParteView = new AlmuerzoParteView(total,buttonNuevoPedido);
		almuerzoParteView.Show();
	}

	protected void OnBotonAlmuerzoCompletoClicked (object sender, System.EventArgs e)
	{
		AlmuerzoCompleto almuerzoCompleto = new AlmuerzoCompleto();
		almuerzoCompleto.Show();
	}

	protected void OnBotonDesayunoPopularClicked (object sender, System.EventArgs e)
	{
		DesayunoPopularView desayunoPopularView = new DesayunoPopularView();
		desayunoPopularView.Show ();
	}

	protected void OnBotonBolleriaDulceClicked (object sender, System.EventArgs e)
	{
		BolleriaDulceView bolleriaDulceView = new BolleriaDulceView(total,buttonNuevoPedido);
		bolleriaDulceView.Show();
	}

	protected void OnBotonBolleriaSaladaClicked (object sender, System.EventArgs e)
	{
		BolleriaSaladaView bolleriaSaladaView = new BolleriaSaladaView(total,buttonNuevoPedido);
		bolleriaSaladaView.Show();

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
			/*string connectionString = "Server=localhost;Database=dbcafeteria;User Id=dbcafeteria;Password=dbcafeteria";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();*/
			
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
