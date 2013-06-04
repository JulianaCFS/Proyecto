using System;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;


namespace ProyectoCafeteria
{
	public partial class BolleriaSaladaView : Gtk.Window
	{	
		private ListStore listStore;
		private IDbConnection dbConnection;
		private Label totalMainWindow;
		private Button botonNuevoPedidoMainWindow;
		
		public BolleriaSaladaView (Label labelTotalMainWindow,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			labelBolleriaSalada.Markup = "<span size='xx-large' weight='bold'>Bollería Salada</span>";
			botonNuevoPedidoMainWindow = botonNP;
			totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select * from bolleriasalada";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			//llamo al método llenarTablaBebidas de la clase LlenarTreeViewBebidas, para que me llene el treeView con los datos obtenedo de la consulta de la BBDD
			//LlenarTreeViewBebidas.llenarTablaBebidas(treeView, dataReader);
			
			llenarTreeViewBolleriaSalada (treeView, dataReader);
			dataReader.Close ();
		}
		public  void llenarTreeViewBolleriaSalada(TreeView treeView, IDataReader dataReader) 
		{	
			//TreeViewExtensions.ClearColumns (treeView);
			AppendColumns (treeView, dataReader);	//hacer cabecera	
			Type[] types = GetTypes (typeof(string), dataReader.FieldCount+1);
			
			listStore = new ListStore(types);
			treeView.Model = listStore;
			Fill (dataReader);
			
			
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

		protected void OnBotonAtrasClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonAceptarClicked (object sender, System.EventArgs e)
		{
			TreeModel tModel;
			treeView.Selection.Mode = SelectionMode.Multiple;
			TreeSelection tSelect = treeView.Selection;
			tSelect.SelectAll();			//selecciona todas las filas necesario para obtener la informacion de todas.
			Array treePaths = tSelect.GetSelectedRows(out tModel);
			
			foreach(TreePath tPath in treePaths)
			{
				TreeIter iter;

				if(listStore.GetIter(out iter, tPath))
				{
					string nombre = (string)listStore.GetValue(iter,1);
					string tamano = (string)listStore.GetValue(iter,2);
					string precio = (string)listStore.GetValue(iter,3);
					string cantidad = (string)listStore.GetValue(iter,4);
					
				/*	Console.WriteLine("Nombre :" + nombre);
					Console.WriteLine("Tipo :" + tamano);
					Console.WriteLine("Precio :" + precio);
					Console.WriteLine("Cantidad :" + cantidad);*/

					if(!cantidad.Equals("0"))
					{
						IDbCommand dbCommand = dbConnection.CreateCommand ();
						
						dbCommand.CommandText = "insert into pedidos (nombre, tamano, precio,cantidad) values (:nombre, :tamano, :precio,:cantidad)";

						DbCommandExtensions.AddParameter (dbCommand, "nombre",nombre);
						DbCommandExtensions.AddParameter (dbCommand, "tamano", tamano);
						DbCommandExtensions.AddParameter (dbCommand, "precio", Convert.ToDouble(precio));
						DbCommandExtensions.AddParameter (dbCommand, "cantidad", Convert.ToInt32(cantidad));
						
						dbCommand.ExecuteNonQuery ();
			
						Destroy ();
						
					}
				}
			}
			calculoLabelTotal();
		}
		public void calculoLabelTotal()
		{
			
				double precioTotal= 0;
				
				//hacer la consulta bd
				IDbCommand dbCommand = dbConnection.CreateCommand ();
				dbCommand.CommandText =  "select precio,cantidad from pedidos ";
				
				IDataReader dataReader = dbCommand.ExecuteReader ();
			
				while(dataReader.Read ()) {

					double precio = dataReader.GetDouble(0);
					int cantidad = dataReader.GetInt32(1);
					precioTotal = precioTotal+(precio * cantidad);
					
				}

				totalMainWindow.Markup = "<span size='xx-large' weight='bold'>"+ " Creando Pedido    Total: "+Convert.ToString(precioTotal)+ " Euros"+ "</span>";
				botonNuevoPedidoMainWindow.Visible=false;
				dataReader.Close ();

		}

		protected void OnBotonEliminarClicked (object sender, System.EventArgs e)
		{
			TreeIter treeIter;
			treeView.Selection.GetSelected(out treeIter);
			treeView.Model.SetValue(treeIter, 4, "0");
		}

		protected void OnTreeViewRowActivated (object o, Gtk.RowActivatedArgs args)
		{
			TreeModel model;
			//registro seleccionado
			TreeIter iterSelected;

			if (treeView.Selection.GetSelected (out model, out iterSelected)) {
				string cantidad = (string)model.GetValue (iterSelected, 4);
			
				SeleccionCantidad pantallaseleccion = new SeleccionCantidad (treeView, cantidad, 1, labelBolleriaSalada);
				pantallaseleccion.Show ();
		}
	}
}

}