using Gtk;
using System;
using System.Data;
using Proyecto.Ad;
using ProyectoCafeteria;



namespace Proyecto.Ad
{
	public static class TreeViewExtensions
	{
		
		static TreeView tv ;
		public static void AppendColumns(TreeView treeView, IDataReader dataReader)
		{
			
			tv = treeView;
			for (int index = 0; index < dataReader.FieldCount; index++)
			{
				Console.WriteLine("el indice es: {0}", index);
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
			
			}
			
		//Gtk.EditedArgs args = new Gtk.EditedArgs();
		Gtk.ListStore treeModel = new ListStore(typeof(string));

		treeView.Model = treeModel;
		
		// Values to be chosen in the ComboBox
		Gtk.ListStore comboModel = new ListStore(typeof(string));
		Gtk.ComboBox comboBox = new ComboBox(comboModel);
		comboBox.AppendText("Selecciona una cantidad");
		comboBox.AppendText("1");
		comboBox.AppendText("2");
		comboBox.AppendText("3");
		comboBox.Active = 0;
		
		Gtk.TreeViewColumn comboCol = new TreeViewColumn();
		Gtk.CellRendererCombo comboCell = new CellRendererCombo();
		comboCol.Title = "Combo Column";
		comboCol.PackStart(comboCell, true);
		comboCol.AddAttribute(comboCell, "text", 4);
		comboCell.Editable = true;
		comboCell.Edited += OnEdited;
		comboCell.TextColumn = 0;
		comboCell.Text = comboBox.ActiveText;
		comboCell.Model = comboModel;
		comboCell.WidthChars = 20;
		
		treeView.AppendColumn(comboCol);
		
		
		}
		
		public static void OnEdited(object sender, Gtk.EditedArgs args)
		{
				Gtk.TreeSelection selection = tv.Selection;
				Gtk.TreeIter iter;
				selection.GetSelected(out iter);
				
				tv.Model.SetValue(iter, 4, args.NewText); // the CellRendererText
		}
		
		public static void Fill(TreeView treeView, IDataReader dataReader) 
		{	
			//TreeViewExtensions.ClearColumns (treeView);
			TreeViewExtensions.AppendColumns (treeView, dataReader);		
			Type[] types = TypeExtensions.GetTypes (typeof(string), dataReader.FieldCount+1);
			
			ListStore listStore = new ListStore(types);
			treeView.Model = listStore;
			ListStoreExtensions.Fill (listStore, dataReader);
			
			
		}
		
		/*public static void showEscogerOpcion(TreeView tv)
		{
			
			Gtk.TreeSelection selection = tv.Selection;
			Gtk.TreeIter iter;
			selection.GetSelected(out iter);
			
			//tv.Model.SetValue(iter, 4, args.NewText); // the CellRendererText
		}*/
		
		/*public static void ClearColumns(TreeView treeView)
		{	
			treeView.Model = null;//antes de llamar a removeColumn para evitar los Gtk.critica
			
			TreeViewColumn[] treeViewColumns = treeView.Columns;
			foreach (TreeViewColumn treeViewColumn in treeViewColumns)
				treeView.RemoveColumn (treeViewColumn);
		}*/
		
		
				/*public void OnEdited(object sender, Gtk.EditedArgs args)
			{
				Gtk.TreeSelection selection = treeview1.Selection;
				Gtk.TreeIter iter;
				selection.GetSelected(out iter);
				
				treeview1.Model.SetValue(iter, 1, args.NewText); // the CellRendererText
			}*/
	}	
			/*private void showActiveItem(ListStore listStore)
			{
				TreeIter treeIter;
				if ( comboBox.GetActiveIter (out treeIter) ) { //item seleccionado
					object value = listStore.GetValue (treeIter, 0);
					Console.WriteLine ("comboBox.Changed delegate value={0}", value);
				}
			}*/
}

