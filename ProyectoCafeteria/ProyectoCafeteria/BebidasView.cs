using System;
using Proyecto.Ad;
using System.Data;
using Gtk;
using Npgsql;
using ProyectoCafeteria;


namespace ProyectoCafeteria
{
	public partial class BebidasView : Gtk.Window
	{	private IDbConnection dbConnection;
		//static TreeView treeview ;
		//Gtk.ListStore treeModel = new ListStore(typeof(int),typeof(string),typeof(string),typeof(double),typeof(int));
		ListStore treeModel = new ListStore(typeof(string),typeof(string),typeof(string),typeof(string),typeof(string));
		public BebidasView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			//para conectarse a la bd 
			string connectionString = "Server=localhost;Database=dbprueba;User Id=dbprueba;Password=Juliana";
			ApplicationContext.Instance.DbConnection = new NpgsqlConnection(connectionString);
			dbConnection = ApplicationContext.Instance.DbConnection;
			dbConnection.Open ();
			
			//hacer la consulta bd
			IDbCommand dbCommand = dbConnection.CreateCommand ();
			dbCommand.CommandText = 
				"select * from bebidasfrias ";
				
			IDataReader dataReader = dbCommand.ExecuteReader ();
			
			
			treeModel = TreeViewExtensions.Fill (treeView, dataReader);
			dataReader.Close ();
		}
		
		
		

		protected void OnButton2Clicked (object sender, System.EventArgs e)
		{
			//treeview = treeView;
			

			treeView.Model = treeModel;
			//throw new System.NotImplementedException ();
			TreeModel tModel;
			treeView.Selection.Mode = SelectionMode.Multiple;
			TreeSelection tSelect = treeView.Selection;
			tSelect.SelectAll();			//selecciona todas las filas necesario para obtener la informacion de todas.
			Array treePaths = tSelect.GetSelectedRows(out tModel);
			
			foreach(TreePath tPath in treePaths)
			{
				TreeIter iter;
				
				if(treeModel.GetIter(out iter, tPath))
				{
					//string id = (string)treeModel.GetValue(iter,0);
					string nombre = (string)treeModel.GetValue(iter,1);
					string tamano = (string)treeModel.GetValue(iter,2);
					string precio = (string)treeModel.GetValue(iter,3);
					string cantidad = (string)treeModel.GetValue(iter,4);
					/*Console.WriteLine("Id  :" + id );
					Console.WriteLine("Nombre :" + nombre);
					Console.WriteLine("Tipo :" + tipo);
					Console.WriteLine("Precio :" + precio);
					Console.WriteLine("Cantidad :" + cantidad);*/
					if(!cantidad.Equals("Selecciona una cantidad"))
					{
						IDbCommand dbCommand = dbConnection.CreateCommand ();
						
						dbCommand.CommandText = "insert into pedidos (nombre, tamano, precio,cantidad) values (:nombre, :tamano, :precio,:cantidad)";
						
						//DbCommandExtensions.AddParameter (dbCommand, "id",Convert.ToInt32(id));
						DbCommandExtensions.AddParameter (dbCommand, "nombre",nombre);
						DbCommandExtensions.AddParameter (dbCommand, "tamano", tamano);
						DbCommandExtensions.AddParameter (dbCommand, "precio", Convert.ToDouble(precio));
						DbCommandExtensions.AddParameter (dbCommand, "cantidad", Convert.ToInt32(cantidad));
						
						dbCommand.ExecuteNonQuery ();
			
						Destroy ();
					}
				}
			}
			//tSelect.UnselectAll();
			}
	}
}

