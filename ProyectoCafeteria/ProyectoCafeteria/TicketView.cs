using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public partial class TicketView : Gtk.Window
	{
		public TicketView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnBotonCancelarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnBotonEliminarClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
	}
}

