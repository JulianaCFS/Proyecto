using System;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;


namespace ProyectoCafeteria
{
	public partial class LlenarTreeViewBebidas : Gtk.Window
	{	
		public LlenarTreeViewBebidas () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		public static void llenarTablaBebidas(TreeView treeView, IDataReader dataReader) 
		{	
			
			TreeViewExtension.AppendColumns (treeView, dataReader);	//hacer cabecera	
			Type[] types = GetTypes (typeof(string), dataReader.FieldCount+1);
			
			listStore = new ListStore(types);
			treeView.Model = listStore;
			TreeViewExtension.Fill (dataReader);
			
			
		}
	}	
}

