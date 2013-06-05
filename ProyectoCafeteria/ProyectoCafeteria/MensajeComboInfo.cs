using System;
using Gtk;
using System.Data;
using ProyectoCafeteria;



namespace ProyectoCafeteria
{
	public partial class MensajeComboInfo : Gtk.Window
	{
		public MensajeComboInfo () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			labelMensaje.Markup = "<span size='x-large' weight='bold'>Debes de seleccionar todos los campos</span>";
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}

