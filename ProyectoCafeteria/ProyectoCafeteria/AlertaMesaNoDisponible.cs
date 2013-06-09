using System;
using Gtk;
using System.Data;
using ProyectoCafeteria;


namespace ProyectoCafeteria
{
	public partial class AlertaMesaNoDisponible : Gtk.Window
	{
		public AlertaMesaNoDisponible () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelAlertaMesas.Markup = "<span size='x-large' weight='bold'>No hay mesas disponibles, inténtalo más tarde.</span>";
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}

