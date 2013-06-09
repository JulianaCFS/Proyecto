using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using ProyectoCafeteria;
using Npgsql;





public partial class MainWindow: Gtk.Window
{	

	private IDbConnection dbConnection;
	public static bool HasIniciadoPedido = false;
 	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		total.Markup = "<span size='xx-large' weight='bold'> Total: 0,0 Euros</span>";
		
		
		string connectionString = "Server=localhost;Database=dbcafeteria;User Id=dbcafeteria;Password=dbcafeteria";
		ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
		dbConnection = ApplicationContext.Instance.DbConnection;
		dbConnection.Open ();
				 
		
		
		dbConnection = ApplicationContext.Instance.DbConnection;
		
		//Objeto fondo creado para poner un color de fondo en el boton "INICIAR PEDIDO"
		Gdk.Color fondo = new Gdk.Color();
		Gdk.Color.Parse("red", ref fondo);
		buttonNuevoPedido.ModifyBg(StateType.Normal, fondo);
		
		
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		
		
		IDbCommand dbCommand = dbConnection.CreateCommand ();
		dbCommand.CommandText = "update mesas set disponible='si';";
		
		dbCommand.ExecuteNonQuery();
		
		dbCommand.CommandText = "delete from ticket ";
		
		dbCommand.ExecuteNonQuery();
		
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBotonBebidasFriasClicked (object sender, System.EventArgs e)
	{
		
		showTablaBebidas();          
		
		
	}
	private void showTablaBebidas()
	{
		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();
		    
		} else {
			BebidasView bebidasView = new BebidasView (total, buttonNuevoPedido);
			bebidasView.Show ();
		}

	}
	
	
	//la llamada del metodo que calcularas el total que estara en bebidasview que tendras como parametros el label 
	//pantalla
	protected void OnBotonBebidasCalientesClicked (object sender, System.EventArgs e)
	{

		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {
			BebidasCalientesView bebidasCalientesView = new BebidasCalientesView (total, buttonNuevoPedido);
			bebidasCalientesView.Show ();
		}
	}


	protected void OnBotonBocadillosClicked (object sender, System.EventArgs e)
	{
		if(HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			Bocadillos bocadillos = new Bocadillos(total,buttonNuevoPedido);
			bocadillos.Show();
		}

	}
	protected void OnBotonAlmuerzoParteClicked (object sender, System.EventArgs e)
	{

		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			AlmuerzoParteView almuerzoParteView = new AlmuerzoParteView (total, buttonNuevoPedido);
			almuerzoParteView.Show ();
		}
	}

	protected void OnBotonAlmuerzoCompletoClicked (object sender, System.EventArgs e)
	{

		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			AlmuerzoCompleto almuerzoCompleto = new AlmuerzoCompleto (total, buttonNuevoPedido);
			almuerzoCompleto.Show ();

		}
	}

	protected void OnBotonDesayunoPopularClicked (object sender, System.EventArgs e)
	{
		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			DesayunoPopularView desayunoPopularView = new DesayunoPopularView (total, buttonNuevoPedido);
			desayunoPopularView.Show ();
		}

	}

	protected void OnBotonBolleriaDulceClicked (object sender, System.EventArgs e)
	{
		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			BolleriaDulceView bolleriaDulceView = new BolleriaDulceView (total, buttonNuevoPedido);
			bolleriaDulceView.Show ();
		}
	}

	protected void OnBotonBolleriaSaladaClicked (object sender, System.EventArgs e)
	{
		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			BolleriaSaladaView bolleriaSaladaView = new BolleriaSaladaView (total, buttonNuevoPedido);
			bolleriaSaladaView.Show ();
		}

	}

	protected void OnBotonticketClicked (object sender, System.EventArgs e)
	{
		if (HasIniciadoPedido == false) {
			AlertaSesionNoIniciada sesionNo = new AlertaSesionNoIniciada ();
			sesionNo.Show ();

		} else {

			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText =  "select COUNT(id) from pedidos";
			int hayPedidos = Convert.ToInt32(dbCommand.ExecuteScalar());

			if (hayPedidos != 0) {

				TicketView ticketview = new TicketView (total, buttonNuevoPedido);//le paso el label del total, para que cuando imprima el ticket, poner pantalla inicio el total a 0
				ticketview.Show ();

			}


		}

	}

	protected void OnButtonNuevoPedidoClicked (object sender, System.EventArgs e)
	{
		
		AñadirNumPersonas añadirNumPersonas = new AñadirNumPersonas (total,buttonNuevoPedido);
		añadirNumPersonas.Show();
			
			
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"delete from pedidos ";
			
		    dbCommand.ExecuteNonQuery();
			
			total.Markup = "<span size='xx-large' weight='bold'>Inicie Pedido    Total: 0,0 Euros</span>";
			buttonNuevoPedido.Visible=false;
				
	}

	
	
	
	protected void OnBotonAyudaClicked (object sender, System.EventArgs e)
	{
		PantallaAyudaUsuario ayudaUsuario = new PantallaAyudaUsuario();
		ayudaUsuario.Show();
	}
}
