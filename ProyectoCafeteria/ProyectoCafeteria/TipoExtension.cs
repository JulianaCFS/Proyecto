using System;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public partial class TipoExtension : Gtk.Window
	{
		public TipoExtension () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
		}
	}
}

