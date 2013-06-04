using System;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Data;

namespace ProyectoCafeteria
{
	class MainClass
	{	
		public static void Main (string[] args)
		{	
			
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
			
		}
	}
}
