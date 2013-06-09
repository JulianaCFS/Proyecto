using System;
using Gtk;
using System.Data;
using ProyectoCafeteria;

namespace ProyectoCafeteria
{
	public partial class AlertaSesionNoIniciada : Gtk.Window
	{
		public AlertaSesionNoIniciada () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelAlerta.Markup = "<span size='x-large' weight='bold'>Debes dar al boton INICIAR PEDIDO.</span>";
		}

		protected void OnBotonAceptarClicked (object sender, EventArgs e)
		{
			   this.Destroy();
		}
	}
}

