
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoCafeteria
{
	public partial class BebidasView
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeView;
		private global::Gtk.Table table1;
		private global::Gtk.Button botonAceptar;
		private global::Gtk.Button botonEliminar;
		private global::Gtk.Button botonInicio;
		private global::Gtk.Button botonTicket;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProyectoCafeteria.BebidasView
			this.Name = "ProyectoCafeteria.BebidasView";
			this.Title = global::Mono.Unix.Catalog.GetString ("BebidasView");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProyectoCafeteria.BebidasView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeView = new global::Gtk.TreeView ();
			this.treeView.CanFocus = true;
			this.treeView.Name = "treeView";
			this.GtkScrolledWindow.Add (this.treeView);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.botonAceptar = new global::Gtk.Button ();
			this.botonAceptar.CanFocus = true;
			this.botonAceptar.Name = "botonAceptar";
			this.botonAceptar.UseUnderline = true;
			this.botonAceptar.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
			this.table1.Add (this.botonAceptar);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.botonAceptar]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.botonEliminar = new global::Gtk.Button ();
			this.botonEliminar.CanFocus = true;
			this.botonEliminar.Name = "botonEliminar";
			this.botonEliminar.UseUnderline = true;
			this.botonEliminar.Label = global::Mono.Unix.Catalog.GetString ("Eliminar");
			this.table1.Add (this.botonEliminar);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.botonEliminar]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.botonInicio = new global::Gtk.Button ();
			this.botonInicio.CanFocus = true;
			this.botonInicio.Name = "botonInicio";
			this.botonInicio.UseUnderline = true;
			this.botonInicio.Label = global::Mono.Unix.Catalog.GetString ("Inicio");
			this.table1.Add (this.botonInicio);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.botonInicio]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.botonTicket = new global::Gtk.Button ();
			this.botonTicket.CanFocus = true;
			this.botonTicket.Name = "botonTicket";
			this.botonTicket.UseUnderline = true;
			this.botonTicket.Label = global::Mono.Unix.Catalog.GetString ("Ticket");
			this.table1.Add (this.botonTicket);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.botonTicket]));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.botonTicket.Clicked += new global::System.EventHandler (this.OnBotonTicketClicked);
			this.botonInicio.Clicked += new global::System.EventHandler (this.OnBotonInicioClicked);
			this.botonEliminar.Clicked += new global::System.EventHandler (this.OnBotonEliminarClicked);
			this.botonAceptar.Clicked += new global::System.EventHandler (this.OnBotonAceptarClicked);
		}
	}
}
