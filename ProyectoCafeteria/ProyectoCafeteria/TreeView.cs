using Gtk;
using System;
using System.Data;
using Proyecto.Ad;
using ProyectoCafeteria;


namespace Proyecto.Ad
{
	public static class TreeViewExtensions
	{
		public static void AppendColumns(TreeView treeView, IDataReader dataReader)
		{
			for (int index = 0; index < dataReader.FieldCount; index++) 
				treeView.AppendColumn (dataReader.GetName (index), new CellRendererText(), "text", index);
			
			Gtk.ListStore comboModel = new ListStore(typeof(string));
		Gtk.ComboBox comboBox = new ComboBox(comboModel);
		comboBox.AppendText("Selecciona una opcion");
		comboBox.AppendText("A");
		comboBox.AppendText("B");
		comboBox.AppendText("C");
		comboBox.Active = 0;
		
		Gtk.TreeViewColumn comboCol = new TreeViewColumn();
		Gtk.CellRendererCombo comboCell = new CellRendererCombo();
		comboCol.Title = "Combo Column";
		comboCol.PackStart(comboCell, true);
		comboCol.AddAttribute(comboCell, "text", 1);
		comboCell.Editable = true;
		comboCell.Edited += OnEdited;
		comboCell.TextColumn = 0;
		comboCell.Text = comboBox.ActiveText;
		comboCell.Model = comboModel;
		comboCell.WidthChars = 20;
			
			treeView.AppendColumn(comboCol);
		}
		
		
		
		public static void Fill(TreeView treeView, IDataReader dataReader) 
		{	
			TreeViewExtensions.ClearColumns (treeView);
			TreeViewExtensions.AppendColumns (treeView, dataReader);		
			Type[] types = TypeExtensions.GetTypes (typeof(string), dataReader.FieldCount);
			
			ListStore listStore = new ListStore(types);
			treeView.Model = listStore;
			ListStoreExtensions.Fill (listStore, dataReader);
		}
		
		public static void ClearColumns(TreeView treeView)
		{	
			treeView.Model = null;//antes de llamar a removeColumn para evitar los Gtk.critica
			
			TreeViewColumn[] treeViewColumns = treeView.Columns;
			foreach (TreeViewColumn treeViewColumn in treeViewColumns)
				treeView.RemoveColumn (treeViewColumn);
		}
		
		public static void OnEdited(object sender, Gtk.EditedArgs args)
		{
		Gtk.TreeSelection selection = treeView.Selection;
		Gtk.TreeIter iter;
		selection.GetSelected(out iter);
		
		treeView.Model.SetValue(iter, 1, args.NewText); // the CellRendererText
	}

		
	}
}

