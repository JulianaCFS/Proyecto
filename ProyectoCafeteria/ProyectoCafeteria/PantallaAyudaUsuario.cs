using System;
using Gtk;
using System.Data;
using ProyectoCafeteria;

namespace ProyectoCafeteria
{
	public partial class PantallaAyudaUsuario : Gtk.Window
	{
		public PantallaAyudaUsuario () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}

