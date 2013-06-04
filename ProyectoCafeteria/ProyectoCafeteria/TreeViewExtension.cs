using System;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public partial class TreeViewExtension : Gtk.Window
	{
		public TreeViewExtension () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		public  void AppendColumns(TreeView treeView, IDataReader dataReader)
		{	

			for (int index = 0; index < dataReader.FieldCount; index++)
			{
				//Console.WriteLine("el indice es: {0}", index);
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
				
				
				//treeView.AppendColumn ("columna1", new CellRendererText(), "text",index);
			}
			
			//Añadimos la columna de la cantidad porque en la BBDD no tenemos este campo.
			TreeViewColumn cantidad = new TreeViewColumn();
			cantidad.Title = "Cantidad";
			CellRendererText cant = new CellRendererText();
			cantidad.PackStart(cant, true);
			cantidad.AddAttribute(cant,"text",4);
			
		   
			//para mostrar las imágenes
			//CellRendererPixbuf cellRendererPixbuf = new CellRendererPixbuf();
			
			//prueba para cambiar tamaño letra
			cantidad.Sizing = TreeViewColumnSizing.Fixed;
		   	cantidad.FixedWidth = 200;
			
			
			treeView.AppendColumn(cantidad);
		}
		public void Fill(IDataReader dataReader)
		{
			while(dataReader.Read ()) {
				List<string> values = new List<string>();
				for (int index = 0; index < dataReader.FieldCount; index++)
				{
					values.Add (dataReader[index].ToString ());
					//Console.WriteLine("El iden es: {0} {1} ", dataReader[index].ToString (), index);
					
				}
				values.Add("0");
				//listStore.AppendValues (values.ToArray());
			}
		}
	}
}

