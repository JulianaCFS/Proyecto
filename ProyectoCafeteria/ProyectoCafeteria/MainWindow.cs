using System;
using Gtk;
using System.Data;
using Proyecto.Ad;
using System.Collections.Generic;
using ProyectoCafeteria;




public partial class MainWindow: Gtk.Window
{	private IDbConnection dbConnection;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
	
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, System.EventArgs e)
	{
		
		showTablaBebidas();          
		
		
	}
	private void showTablaBebidas()
	{
		BebidasView bebidasView = new BebidasView();
		bebidasView.Show();
	}

	protected void OnButton2Clicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
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
}
