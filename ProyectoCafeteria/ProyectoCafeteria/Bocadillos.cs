using System;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;
using System.Collections.Generic;

namespace ProyectoCafeteria
{
	public partial class Bocadillos : Gtk.Window
	{	
		private ListStore listStore;
		private IDbConnection dbConnection;
		private Label totalMainWindow;
		private Button botonNuevoPedidoMainWindow;
		
		public Bocadillos (Label labelTotalMainWindow,Button botonNP) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			labelBocadillos.Markup = "<span size='xx-large' weight='bold'>Bebidas Bocadillos</span>";
			botonNuevoPedidoMainWindow = botonNP;
			totalMainWindow = labelTotalMainWindow;
			
			dbConnection = ApplicationContext.Instance.DbConnection;
			
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select * from bocadillos ";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			//llamo al método llenarTablaBebidas de la clase LlenarTreeViewBebidas, para que me llene el treeView con los datos obtenedo de la consulta de la BBDD
			//LlenarTreeViewBebidas.llenarTablaBebidas(treeView, dataReader);
			
			//Aquí creamos un objeto de la clase RellenarTreeView y le pasamos a la clase el treeView y el dataReader
			RellenarTreeView rellenar =new RellenarTreeView();
			rellenar.llenarTreeView(treeView, dataReader);
			//recogemos el listStore que usamos en la clase RellenarTreeView, para ser usada en los los métodos en esa clase
			listStore = rellenar.get_ListStore();
			
			dataReader.Close ();
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
			CalculoLabelMain calculoLabel = new CalculoLabelMain();
			calculoLabel.calculoLabelTotal(totalMainWindow,botonNuevoPedidoMainWindow);
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
			
				SeleccionCantidad pantallaseleccion = new SeleccionCantidad (treeView, cantidad, 1, labelBocadillos);
				pantallaseleccion.Show ();
			}
		}

		
	}
}

