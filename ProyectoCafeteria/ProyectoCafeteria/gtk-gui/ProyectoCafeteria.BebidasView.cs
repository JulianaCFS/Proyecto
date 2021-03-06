
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoCafeteria
{
	public partial class BebidasView
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label labelBF;
		private global::Gtk.Fixed fixed9;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView treeView;
		private global::Gtk.Table table2;
		private global::Gtk.Button botonAceptar;
		private global::Gtk.Button botonEliminar;
		private global::Gtk.Button botonInicio;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.Fixed fixed4;
		private global::Gtk.Fixed fixed5;
		private global::Gtk.Fixed fixed6;
		private global::Gtk.Fixed fixed7;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProyectoCafeteria.BebidasView
			this.Name = "ProyectoCafeteria.BebidasView";
			this.Title = global::Mono.Unix.Catalog.GetString ("Bebidas Frías");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(2));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child ProyectoCafeteria.BebidasView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelBF = new global::Gtk.Label ();
			this.labelBF.Name = "labelBF";
			this.labelBF.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.vbox1.Add (this.labelBF);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelBF]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed9 = new global::Gtk.Fixed ();
			this.fixed9.Name = "fixed9";
			this.fixed9.HasWindow = false;
			this.vbox1.Add (this.fixed9);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed9]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.treeView = new global::Gtk.TreeView ();
			this.treeView.CanFocus = true;
			this.treeView.Name = "treeView";
			this.scrolledwindow1.Add (this.treeView);
			this.vbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
			w4.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(5)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.botonAceptar = new global::Gtk.Button ();
			this.botonAceptar.CanFocus = true;
			this.botonAceptar.Name = "botonAceptar";
			this.botonAceptar.UseUnderline = true;
			// Container child botonAceptar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w6 = new global::Gtk.HBox ();
			w6.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w6.Add (w7);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w9 = new global::Gtk.Label ();
			w9.LabelProp = global::Mono.Unix.Catalog.GetString ("Aceptar");
			w9.UseUnderline = true;
			w6.Add (w9);
			w5.Add (w6);
			this.botonAceptar.Add (w5);
			this.table2.Add (this.botonAceptar);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.botonAceptar]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.botonEliminar = new global::Gtk.Button ();
			this.botonEliminar.CanFocus = true;
			this.botonEliminar.Name = "botonEliminar";
			this.botonEliminar.UseUnderline = true;
			// Container child botonEliminar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w15 = new global::Gtk.HBox ();
			w15.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w16 = new global::Gtk.Image ();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w15.Add (w16);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w18 = new global::Gtk.Label ();
			w18.LabelProp = global::Mono.Unix.Catalog.GetString ("Eliminar");
			w18.UseUnderline = true;
			w15.Add (w18);
			w14.Add (w15);
			this.botonEliminar.Add (w14);
			this.table2.Add (this.botonEliminar);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.botonEliminar]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(4));
			w22.RightAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.botonInicio = new global::Gtk.Button ();
			this.botonInicio.CanFocus = true;
			this.botonInicio.Name = "botonInicio";
			this.botonInicio.UseUnderline = true;
			// Container child botonInicio.Gtk.Container+ContainerChild
			global::Gtk.Alignment w23 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w24 = new global::Gtk.HBox ();
			w24.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-home", global::Gtk.IconSize.Menu);
			w24.Add (w25);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w27 = new global::Gtk.Label ();
			w27.LabelProp = global::Mono.Unix.Catalog.GetString ("Atrás");
			w27.UseUnderline = true;
			w24.Add (w27);
			w23.Add (w24);
			this.botonInicio.Add (w23);
			this.table2.Add (this.botonInicio);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.botonInicio]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.table2.Add (this.fixed1);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed1]));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.table2.Add (this.fixed2);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed2]));
			w33.TopAttach = ((uint)(1));
			w33.BottomAttach = ((uint)(2));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.table2.Add (this.fixed3);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed3]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed4 = new global::Gtk.Fixed ();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.table2.Add (this.fixed4);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed4]));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.table2.Add (this.fixed5);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed5]));
			w36.LeftAttach = ((uint)(2));
			w36.RightAttach = ((uint)(3));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed6 = new global::Gtk.Fixed ();
			this.fixed6.Name = "fixed6";
			this.fixed6.HasWindow = false;
			this.table2.Add (this.fixed6);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed6]));
			w37.LeftAttach = ((uint)(3));
			w37.RightAttach = ((uint)(4));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.table2.Add (this.fixed7);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed7]));
			w38.LeftAttach = ((uint)(4));
			w38.RightAttach = ((uint)(5));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table2]));
			w39.Position = 3;
			w39.Expand = false;
			w39.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 703;
			this.DefaultHeight = 512;
			this.Show ();
			this.treeView.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeViewRowActivated);
			this.botonInicio.Clicked += new global::System.EventHandler (this.OnBotonInicioClicked);
			this.botonEliminar.Clicked += new global::System.EventHandler (this.OnBotonEliminarClicked);
			this.botonAceptar.Clicked += new global::System.EventHandler (this.OnBotonAceptarClicked);
		}
	}
}
