using System;
using Gtk;
using System.Data;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public class RellenarTreeView
	{	
		private ListStore listStore;
		
		public RellenarTreeView ()
		{
		}
		public  void llenarTreeView(TreeView treeView, IDataReader dataReader) 
		{	
			
			AppendColumns (treeView, dataReader);	//hacer cabecera	
			Type[] types = GetTypes (typeof(string), dataReader.FieldCount+1);
			
			listStore = new ListStore(types);
			treeView.Model = listStore;
			Fill (dataReader);
			
			
		}
		public ListStore get_ListStore(){
			
			return listStore;
		}
		public  void AppendColumns(TreeView treeView, IDataReader dataReader)
		{
			
			
			for (int index = 0; index < dataReader.FieldCount; index++)
			{
				//Console.WriteLine("el indice es: {0}", index);
				if(index == 0)
					treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index).Visible=false;
				else
					treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
				
			
			}
		
			//Añadimos la columna de la cantidad porque en la BBDD no tenemos este campo.
			TreeViewColumn cantidad = new TreeViewColumn();
			cantidad.Title = "Cantidad";
			CellRendererText cant = new CellRendererText();
			cantidad.PackStart(cant, true);
			cantidad.AddAttribute(cant,"text",4);

			treeView.AppendColumn(cantidad);
		
		}
		//método que devuelve el tipo a rellenar el treeview
		public static Type[] GetTypes(Type type, int count)
		{
			List<Type> types = new List<Type>();
			for (int index = 0; index < count; index++)
				types.Add(type);
			return types.ToArray ();
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
				listStore.AppendValues (values.ToArray());
			}
		}
	}
}
