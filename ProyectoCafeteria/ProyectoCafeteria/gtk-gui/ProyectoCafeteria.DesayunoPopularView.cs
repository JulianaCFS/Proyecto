
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoCafeteria
{
	public partial class DesayunoPopularView
	{
		private global::Gtk.VBox vbox8;
		private global::Gtk.Label labelDesayunoPopular;
		private global::Gtk.Fixed fixed136;
		private global::Gtk.Fixed fixed137;
		private global::Gtk.Fixed fixed138;
		private global::Gtk.Table table16;
		private global::Gtk.ComboBox comboboxCafe;
		private global::Gtk.ComboBox comboboxComida;
		private global::Gtk.ComboBox comboboxPrecio;
		private global::Gtk.Fixed fixed142;
		private global::Gtk.Fixed fixed143;
		private global::Gtk.Fixed fixed144;
		private global::Gtk.Fixed fixed145;
		private global::Gtk.Fixed fixed146;
		private global::Gtk.Fixed fixed147;
		private global::Gtk.Label labelBebida;
		private global::Gtk.Label labelCantidad;
		private global::Gtk.Label labelComida;
		private global::Gtk.Label labelPrecio;
		private global::Gtk.SpinButton spinbuttonCantidad;
		private global::Gtk.Fixed fixed139;
		private global::Gtk.Fixed fixed140;
		private global::Gtk.Fixed fixed141;
		private global::Gtk.Table table17;
		private global::Gtk.Button botonAceptar;
		private global::Gtk.Button botonAtras;
		private global::Gtk.Button botonCancelar;
		private global::Gtk.Fixed fixed148;
		private global::Gtk.Fixed fixed149;
		private global::Gtk.Fixed fixed150;
		private global::Gtk.Fixed fixed151;
		private global::Gtk.Fixed fixed152;
		private global::Gtk.Fixed fixed153;
		private global::Gtk.Fixed fixed154;
		private global::Gtk.Fixed fixed155;
		private global::Gtk.Fixed fixed156;
		private global::Gtk.Fixed fixed157;
		private global::Gtk.Fixed fixed158;
		private global::Gtk.Fixed fixed159;
		private global::Gtk.Fixed fixed160;
		private global::Gtk.Fixed fixed161;
		private global::Gtk.Fixed fixed162;
		private global::Gtk.Fixed fixed163;
		private global::Gtk.Fixed fixed164;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProyectoCafeteria.DesayunoPopularView
			this.Name = "ProyectoCafeteria.DesayunoPopularView";
			this.Title = global::Mono.Unix.Catalog.GetString ("DesayunoPopularView");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(2));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child ProyectoCafeteria.DesayunoPopularView.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			this.vbox8.BorderWidth = ((uint)(6));
			// Container child vbox8.Gtk.Box+BoxChild
			this.labelDesayunoPopular = new global::Gtk.Label ();
			this.labelDesayunoPopular.Name = "labelDesayunoPopular";
			this.labelDesayunoPopular.LabelProp = global::Mono.Unix.Catalog.GetString ("label31");
			this.vbox8.Add (this.labelDesayunoPopular);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.labelDesayunoPopular]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed136 = new global::Gtk.Fixed ();
			this.fixed136.Name = "fixed136";
			this.fixed136.HasWindow = false;
			this.vbox8.Add (this.fixed136);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed136]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed137 = new global::Gtk.Fixed ();
			this.fixed137.Name = "fixed137";
			this.fixed137.HasWindow = false;
			this.vbox8.Add (this.fixed137);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed137]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed138 = new global::Gtk.Fixed ();
			this.fixed138.Name = "fixed138";
			this.fixed138.HasWindow = false;
			this.vbox8.Add (this.fixed138);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed138]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table16 = new global::Gtk.Table (((uint)(2)), ((uint)(7)), false);
			this.table16.Name = "table16";
			this.table16.RowSpacing = ((uint)(6));
			this.table16.ColumnSpacing = ((uint)(6));
			// Container child table16.Gtk.Table+TableChild
			this.comboboxCafe = global::Gtk.ComboBox.NewText ();
			this.comboboxCafe.Name = "comboboxCafe";
			this.table16.Add (this.comboboxCafe);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table16 [this.comboboxCafe]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.comboboxComida = global::Gtk.ComboBox.NewText ();
			this.comboboxComida.Name = "comboboxComida";
			this.table16.Add (this.comboboxComida);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table16 [this.comboboxComida]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.comboboxPrecio = global::Gtk.ComboBox.NewText ();
			this.comboboxPrecio.Name = "comboboxPrecio";
			this.table16.Add (this.comboboxPrecio);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table16 [this.comboboxPrecio]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(4));
			w7.RightAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed142 = new global::Gtk.Fixed ();
			this.fixed142.Name = "fixed142";
			this.fixed142.HasWindow = false;
			this.table16.Add (this.fixed142);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed142]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed143 = new global::Gtk.Fixed ();
			this.fixed143.Name = "fixed143";
			this.fixed143.HasWindow = false;
			this.table16.Add (this.fixed143);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed143]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed144 = new global::Gtk.Fixed ();
			this.fixed144.Name = "fixed144";
			this.fixed144.HasWindow = false;
			this.table16.Add (this.fixed144);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed144]));
			w10.LeftAttach = ((uint)(3));
			w10.RightAttach = ((uint)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed145 = new global::Gtk.Fixed ();
			this.fixed145.Name = "fixed145";
			this.fixed145.HasWindow = false;
			this.table16.Add (this.fixed145);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed145]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed146 = new global::Gtk.Fixed ();
			this.fixed146.Name = "fixed146";
			this.fixed146.HasWindow = false;
			this.table16.Add (this.fixed146);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed146]));
			w12.LeftAttach = ((uint)(5));
			w12.RightAttach = ((uint)(6));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.fixed147 = new global::Gtk.Fixed ();
			this.fixed147.Name = "fixed147";
			this.fixed147.HasWindow = false;
			this.table16.Add (this.fixed147);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table16 [this.fixed147]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(5));
			w13.RightAttach = ((uint)(6));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.labelBebida = new global::Gtk.Label ();
			this.labelBebida.Name = "labelBebida";
			this.labelBebida.LabelProp = global::Mono.Unix.Catalog.GetString ("Bebida");
			this.table16.Add (this.labelBebida);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table16 [this.labelBebida]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.labelCantidad = new global::Gtk.Label ();
			this.labelCantidad.Name = "labelCantidad";
			this.labelCantidad.LabelProp = global::Mono.Unix.Catalog.GetString ("Cantidad");
			this.table16.Add (this.labelCantidad);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table16 [this.labelCantidad]));
			w15.LeftAttach = ((uint)(6));
			w15.RightAttach = ((uint)(7));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.labelComida = new global::Gtk.Label ();
			this.labelComida.Name = "labelComida";
			this.labelComida.LabelProp = global::Mono.Unix.Catalog.GetString ("Comida");
			this.table16.Add (this.labelComida);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table16 [this.labelComida]));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.labelPrecio = new global::Gtk.Label ();
			this.labelPrecio.Name = "labelPrecio";
			this.labelPrecio.LabelProp = global::Mono.Unix.Catalog.GetString ("Precio");
			this.table16.Add (this.labelPrecio);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table16 [this.labelPrecio]));
			w17.LeftAttach = ((uint)(4));
			w17.RightAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table16.Gtk.Table+TableChild
			this.spinbuttonCantidad = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbuttonCantidad.CanFocus = true;
			this.spinbuttonCantidad.Name = "spinbuttonCantidad";
			this.spinbuttonCantidad.Adjustment.PageIncrement = 10;
			this.spinbuttonCantidad.ClimbRate = 1;
			this.spinbuttonCantidad.Numeric = true;
			this.table16.Add (this.spinbuttonCantidad);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table16 [this.spinbuttonCantidad]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(6));
			w18.RightAttach = ((uint)(7));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox8.Add (this.table16);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.table16]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed139 = new global::Gtk.Fixed ();
			this.fixed139.Name = "fixed139";
			this.fixed139.HasWindow = false;
			this.vbox8.Add (this.fixed139);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed139]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed140 = new global::Gtk.Fixed ();
			this.fixed140.Name = "fixed140";
			this.fixed140.HasWindow = false;
			this.vbox8.Add (this.fixed140);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed140]));
			w21.Position = 6;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed141 = new global::Gtk.Fixed ();
			this.fixed141.Name = "fixed141";
			this.fixed141.HasWindow = false;
			this.vbox8.Add (this.fixed141);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed141]));
			w22.Position = 7;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table17 = new global::Gtk.Table (((uint)(4)), ((uint)(5)), false);
			this.table17.Name = "table17";
			this.table17.RowSpacing = ((uint)(6));
			this.table17.ColumnSpacing = ((uint)(6));
			this.table17.BorderWidth = ((uint)(6));
			// Container child table17.Gtk.Table+TableChild
			this.botonAceptar = new global::Gtk.Button ();
			this.botonAceptar.CanFocus = true;
			this.botonAceptar.Name = "botonAceptar";
			this.botonAceptar.UseUnderline = true;
			// Container child botonAceptar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w23 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w24 = new global::Gtk.HBox ();
			w24.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w24.Add (w25);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w27 = new global::Gtk.Label ();
			w27.LabelProp = global::Mono.Unix.Catalog.GetString ("Aceptar");
			w27.UseUnderline = true;
			w24.Add (w27);
			w23.Add (w24);
			this.botonAceptar.Add (w23);
			this.table17.Add (this.botonAceptar);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table17 [this.botonAceptar]));
			w31.TopAttach = ((uint)(3));
			w31.BottomAttach = ((uint)(4));
			w31.LeftAttach = ((uint)(3));
			w31.RightAttach = ((uint)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.botonAtras = new global::Gtk.Button ();
			this.botonAtras.CanFocus = true;
			this.botonAtras.Name = "botonAtras";
			this.botonAtras.UseUnderline = true;
			// Container child botonAtras.Gtk.Container+ContainerChild
			global::Gtk.Alignment w32 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w33 = new global::Gtk.HBox ();
			w33.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w34 = new global::Gtk.Image ();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-home", global::Gtk.IconSize.Menu);
			w33.Add (w34);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w36 = new global::Gtk.Label ();
			w36.LabelProp = global::Mono.Unix.Catalog.GetString ("Atrás");
			w36.UseUnderline = true;
			w33.Add (w36);
			w32.Add (w33);
			this.botonAtras.Add (w32);
			this.table17.Add (this.botonAtras);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table17 [this.botonAtras]));
			w40.TopAttach = ((uint)(3));
			w40.BottomAttach = ((uint)(4));
			w40.LeftAttach = ((uint)(2));
			w40.RightAttach = ((uint)(3));
			w40.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table17.Gtk.Table+TableChild
			this.botonCancelar = new global::Gtk.Button ();
			this.botonCancelar.CanFocus = true;
			this.botonCancelar.Name = "botonCancelar";
			this.botonCancelar.UseUnderline = true;
			// Container child botonCancelar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w41 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w42 = new global::Gtk.HBox ();
			w42.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w43 = new global::Gtk.Image ();
			w43.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w42.Add (w43);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w45 = new global::Gtk.Label ();
			w45.LabelProp = global::Mono.Unix.Catalog.GetString ("Cancelar");
			w45.UseUnderline = true;
			w42.Add (w45);
			w41.Add (w42);
			this.botonCancelar.Add (w41);
			this.table17.Add (this.botonCancelar);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table17 [this.botonCancelar]));
			w49.TopAttach = ((uint)(3));
			w49.BottomAttach = ((uint)(4));
			w49.LeftAttach = ((uint)(4));
			w49.RightAttach = ((uint)(5));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed148 = new global::Gtk.Fixed ();
			this.fixed148.Name = "fixed148";
			this.fixed148.HasWindow = false;
			this.table17.Add (this.fixed148);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed148]));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed149 = new global::Gtk.Fixed ();
			this.fixed149.Name = "fixed149";
			this.fixed149.HasWindow = false;
			this.table17.Add (this.fixed149);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed149]));
			w51.TopAttach = ((uint)(1));
			w51.BottomAttach = ((uint)(2));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed150 = new global::Gtk.Fixed ();
			this.fixed150.Name = "fixed150";
			this.fixed150.HasWindow = false;
			this.table17.Add (this.fixed150);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed150]));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed151 = new global::Gtk.Fixed ();
			this.fixed151.Name = "fixed151";
			this.fixed151.HasWindow = false;
			this.table17.Add (this.fixed151);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed151]));
			w53.TopAttach = ((uint)(1));
			w53.BottomAttach = ((uint)(2));
			w53.LeftAttach = ((uint)(1));
			w53.RightAttach = ((uint)(2));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed152 = new global::Gtk.Fixed ();
			this.fixed152.Name = "fixed152";
			this.fixed152.HasWindow = false;
			this.table17.Add (this.fixed152);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed152]));
			w54.LeftAttach = ((uint)(2));
			w54.RightAttach = ((uint)(3));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed153 = new global::Gtk.Fixed ();
			this.fixed153.Name = "fixed153";
			this.fixed153.HasWindow = false;
			this.table17.Add (this.fixed153);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed153]));
			w55.TopAttach = ((uint)(1));
			w55.BottomAttach = ((uint)(2));
			w55.LeftAttach = ((uint)(2));
			w55.RightAttach = ((uint)(3));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed154 = new global::Gtk.Fixed ();
			this.fixed154.Name = "fixed154";
			this.fixed154.HasWindow = false;
			this.table17.Add (this.fixed154);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed154]));
			w56.LeftAttach = ((uint)(3));
			w56.RightAttach = ((uint)(4));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed155 = new global::Gtk.Fixed ();
			this.fixed155.Name = "fixed155";
			this.fixed155.HasWindow = false;
			this.table17.Add (this.fixed155);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed155]));
			w57.TopAttach = ((uint)(1));
			w57.BottomAttach = ((uint)(2));
			w57.LeftAttach = ((uint)(3));
			w57.RightAttach = ((uint)(4));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed156 = new global::Gtk.Fixed ();
			this.fixed156.Name = "fixed156";
			this.fixed156.HasWindow = false;
			this.table17.Add (this.fixed156);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed156]));
			w58.LeftAttach = ((uint)(4));
			w58.RightAttach = ((uint)(5));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed157 = new global::Gtk.Fixed ();
			this.fixed157.Name = "fixed157";
			this.fixed157.HasWindow = false;
			this.table17.Add (this.fixed157);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed157]));
			w59.TopAttach = ((uint)(1));
			w59.BottomAttach = ((uint)(2));
			w59.LeftAttach = ((uint)(4));
			w59.RightAttach = ((uint)(5));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed158 = new global::Gtk.Fixed ();
			this.fixed158.Name = "fixed158";
			this.fixed158.HasWindow = false;
			this.table17.Add (this.fixed158);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed158]));
			w60.TopAttach = ((uint)(2));
			w60.BottomAttach = ((uint)(3));
			w60.LeftAttach = ((uint)(4));
			w60.RightAttach = ((uint)(5));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed159 = new global::Gtk.Fixed ();
			this.fixed159.Name = "fixed159";
			this.fixed159.HasWindow = false;
			this.table17.Add (this.fixed159);
			global::Gtk.Table.TableChild w61 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed159]));
			w61.TopAttach = ((uint)(2));
			w61.BottomAttach = ((uint)(3));
			w61.LeftAttach = ((uint)(3));
			w61.RightAttach = ((uint)(4));
			w61.XOptions = ((global::Gtk.AttachOptions)(4));
			w61.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed160 = new global::Gtk.Fixed ();
			this.fixed160.Name = "fixed160";
			this.fixed160.HasWindow = false;
			this.table17.Add (this.fixed160);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed160]));
			w62.TopAttach = ((uint)(2));
			w62.BottomAttach = ((uint)(3));
			w62.LeftAttach = ((uint)(2));
			w62.RightAttach = ((uint)(3));
			w62.XOptions = ((global::Gtk.AttachOptions)(4));
			w62.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed161 = new global::Gtk.Fixed ();
			this.fixed161.Name = "fixed161";
			this.fixed161.HasWindow = false;
			this.table17.Add (this.fixed161);
			global::Gtk.Table.TableChild w63 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed161]));
			w63.TopAttach = ((uint)(3));
			w63.BottomAttach = ((uint)(4));
			w63.LeftAttach = ((uint)(1));
			w63.RightAttach = ((uint)(2));
			w63.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed162 = new global::Gtk.Fixed ();
			this.fixed162.Name = "fixed162";
			this.fixed162.HasWindow = false;
			this.table17.Add (this.fixed162);
			global::Gtk.Table.TableChild w64 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed162]));
			w64.TopAttach = ((uint)(2));
			w64.BottomAttach = ((uint)(3));
			w64.LeftAttach = ((uint)(1));
			w64.RightAttach = ((uint)(2));
			w64.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed163 = new global::Gtk.Fixed ();
			this.fixed163.Name = "fixed163";
			this.fixed163.HasWindow = false;
			this.table17.Add (this.fixed163);
			global::Gtk.Table.TableChild w65 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed163]));
			w65.TopAttach = ((uint)(2));
			w65.BottomAttach = ((uint)(3));
			w65.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table17.Gtk.Table+TableChild
			this.fixed164 = new global::Gtk.Fixed ();
			this.fixed164.Name = "fixed164";
			this.fixed164.HasWindow = false;
			this.table17.Add (this.fixed164);
			global::Gtk.Table.TableChild w66 = ((global::Gtk.Table.TableChild)(this.table17 [this.fixed164]));
			w66.TopAttach = ((uint)(3));
			w66.BottomAttach = ((uint)(4));
			w66.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox8.Add (this.table17);
			global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.table17]));
			w67.Position = 8;
			w67.Fill = false;
			this.Add (this.vbox8);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 613;
			this.DefaultHeight = 287;
			this.Show ();
		}
	}
}
