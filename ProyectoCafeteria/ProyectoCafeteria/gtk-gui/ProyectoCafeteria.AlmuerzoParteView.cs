
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoCafeteria
{
	public partial class AlmuerzoParteView
	{
		private global::Gtk.VBox vbox6;
		private global::Gtk.Label labelAlmuerzoParte;
		private global::Gtk.Fixed fixed74;
		private global::Gtk.Fixed fixed75;
		private global::Gtk.Fixed fixed76;
		private global::Gtk.Table table12;
		private global::Gtk.ComboBox comboboxBebida;
		private global::Gtk.ComboBox comboboxCafe;
		private global::Gtk.ComboBox comboboxPrecio;
		private global::Gtk.Fixed fixed77;
		private global::Gtk.Fixed fixed78;
		private global::Gtk.Fixed fixed79;
		private global::Gtk.Fixed fixed80;
		private global::Gtk.Fixed fixed81;
		private global::Gtk.Fixed fixed82;
		private global::Gtk.Label labelBebida;
		private global::Gtk.Label labelCafe;
		private global::Gtk.Label labelCantidad;
		private global::Gtk.Label labelPrecio;
		private global::Gtk.SpinButton spinbuttonCantidad;
		private global::Gtk.Fixed fixed83;
		private global::Gtk.Table table13;
		private global::Gtk.Button botonAceptar;
		private global::Gtk.Button botonAtras;
		private global::Gtk.Button botonCancelar;
		private global::Gtk.Fixed fixed100;
		private global::Gtk.Fixed fixed101;
		private global::Gtk.Fixed fixed102;
		private global::Gtk.Fixed fixed103;
		private global::Gtk.Fixed fixed104;
		private global::Gtk.Fixed fixed105;
		private global::Gtk.Fixed fixed84;
		private global::Gtk.Fixed fixed85;
		private global::Gtk.Fixed fixed86;
		private global::Gtk.Fixed fixed87;
		private global::Gtk.Fixed fixed88;
		private global::Gtk.Fixed fixed89;
		private global::Gtk.Fixed fixed90;
		private global::Gtk.Fixed fixed91;
		private global::Gtk.Fixed fixed92;
		private global::Gtk.Fixed fixed93;
		private global::Gtk.Fixed fixed94;
		private global::Gtk.Fixed fixed95;
		private global::Gtk.Fixed fixed96;
		private global::Gtk.Fixed fixed97;
		private global::Gtk.Fixed fixed98;
		private global::Gtk.Fixed fixed99;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProyectoCafeteria.AlmuerzoParteView
			this.Name = "ProyectoCafeteria.AlmuerzoParteView";
			this.Title = global::Mono.Unix.Catalog.GetString ("Almuerzo Parte");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(2));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child ProyectoCafeteria.AlmuerzoParteView.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.labelAlmuerzoParte = new global::Gtk.Label ();
			this.labelAlmuerzoParte.Name = "labelAlmuerzoParte";
			this.labelAlmuerzoParte.LabelProp = global::Mono.Unix.Catalog.GetString ("label16");
			this.vbox6.Add (this.labelAlmuerzoParte);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.labelAlmuerzoParte]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.fixed74 = new global::Gtk.Fixed ();
			this.fixed74.Name = "fixed74";
			this.fixed74.HasWindow = false;
			this.vbox6.Add (this.fixed74);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.fixed74]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.fixed75 = new global::Gtk.Fixed ();
			this.fixed75.Name = "fixed75";
			this.fixed75.HasWindow = false;
			this.vbox6.Add (this.fixed75);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.fixed75]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.fixed76 = new global::Gtk.Fixed ();
			this.fixed76.Name = "fixed76";
			this.fixed76.HasWindow = false;
			this.vbox6.Add (this.fixed76);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.fixed76]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table12 = new global::Gtk.Table (((uint)(2)), ((uint)(7)), false);
			this.table12.Name = "table12";
			this.table12.RowSpacing = ((uint)(6));
			this.table12.ColumnSpacing = ((uint)(6));
			// Container child table12.Gtk.Table+TableChild
			this.comboboxBebida = global::Gtk.ComboBox.NewText ();
			this.comboboxBebida.Name = "comboboxBebida";
			this.table12.Add (this.comboboxBebida);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table12 [this.comboboxBebida]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.comboboxCafe = global::Gtk.ComboBox.NewText ();
			this.comboboxCafe.Name = "comboboxCafe";
			this.table12.Add (this.comboboxCafe);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table12 [this.comboboxCafe]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.comboboxPrecio = global::Gtk.ComboBox.NewText ();
			this.comboboxPrecio.Name = "comboboxPrecio";
			this.table12.Add (this.comboboxPrecio);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table12 [this.comboboxPrecio]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(4));
			w7.RightAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed77 = new global::Gtk.Fixed ();
			this.fixed77.Name = "fixed77";
			this.fixed77.HasWindow = false;
			this.table12.Add (this.fixed77);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed77]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed78 = new global::Gtk.Fixed ();
			this.fixed78.Name = "fixed78";
			this.fixed78.HasWindow = false;
			this.table12.Add (this.fixed78);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed78]));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed79 = new global::Gtk.Fixed ();
			this.fixed79.Name = "fixed79";
			this.fixed79.HasWindow = false;
			this.table12.Add (this.fixed79);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed79]));
			w10.LeftAttach = ((uint)(5));
			w10.RightAttach = ((uint)(6));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed80 = new global::Gtk.Fixed ();
			this.fixed80.Name = "fixed80";
			this.fixed80.HasWindow = false;
			this.table12.Add (this.fixed80);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed80]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed81 = new global::Gtk.Fixed ();
			this.fixed81.Name = "fixed81";
			this.fixed81.HasWindow = false;
			this.table12.Add (this.fixed81);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed81]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(3));
			w12.RightAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.fixed82 = new global::Gtk.Fixed ();
			this.fixed82.Name = "fixed82";
			this.fixed82.HasWindow = false;
			this.table12.Add (this.fixed82);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table12 [this.fixed82]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(5));
			w13.RightAttach = ((uint)(6));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.labelBebida = new global::Gtk.Label ();
			this.labelBebida.Name = "labelBebida";
			this.labelBebida.LabelProp = global::Mono.Unix.Catalog.GetString ("Bebidas");
			this.table12.Add (this.labelBebida);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table12 [this.labelBebida]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.labelCafe = new global::Gtk.Label ();
			this.labelCafe.Name = "labelCafe";
			this.labelCafe.LabelProp = global::Mono.Unix.Catalog.GetString ("Café");
			this.table12.Add (this.labelCafe);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table12 [this.labelCafe]));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.labelCantidad = new global::Gtk.Label ();
			this.labelCantidad.Name = "labelCantidad";
			this.labelCantidad.LabelProp = global::Mono.Unix.Catalog.GetString ("Cantidad");
			this.table12.Add (this.labelCantidad);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table12 [this.labelCantidad]));
			w16.LeftAttach = ((uint)(6));
			w16.RightAttach = ((uint)(7));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.labelPrecio = new global::Gtk.Label ();
			this.labelPrecio.Name = "labelPrecio";
			this.labelPrecio.LabelProp = global::Mono.Unix.Catalog.GetString ("Precio");
			this.table12.Add (this.labelPrecio);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table12 [this.labelPrecio]));
			w17.LeftAttach = ((uint)(4));
			w17.RightAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.spinbuttonCantidad = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbuttonCantidad.CanFocus = true;
			this.spinbuttonCantidad.Name = "spinbuttonCantidad";
			this.spinbuttonCantidad.Adjustment.PageIncrement = 10;
			this.spinbuttonCantidad.ClimbRate = 1;
			this.spinbuttonCantidad.Numeric = true;
			this.table12.Add (this.spinbuttonCantidad);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table12 [this.spinbuttonCantidad]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(6));
			w18.RightAttach = ((uint)(7));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table12);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table12]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.fixed83 = new global::Gtk.Fixed ();
			this.fixed83.Name = "fixed83";
			this.fixed83.HasWindow = false;
			this.vbox6.Add (this.fixed83);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.fixed83]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table13 = new global::Gtk.Table (((uint)(5)), ((uint)(5)), false);
			this.table13.Name = "table13";
			this.table13.RowSpacing = ((uint)(6));
			this.table13.ColumnSpacing = ((uint)(6));
			// Container child table13.Gtk.Table+TableChild
			this.botonAceptar = new global::Gtk.Button ();
			this.botonAceptar.CanFocus = true;
			this.botonAceptar.Name = "botonAceptar";
			this.botonAceptar.UseUnderline = true;
			// Container child botonAceptar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w21 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w22 = new global::Gtk.HBox ();
			w22.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w22.Add (w23);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w25 = new global::Gtk.Label ();
			w25.LabelProp = global::Mono.Unix.Catalog.GetString ("Aceptar");
			w25.UseUnderline = true;
			w22.Add (w25);
			w21.Add (w22);
			this.botonAceptar.Add (w21);
			this.table13.Add (this.botonAceptar);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table13 [this.botonAceptar]));
			w29.TopAttach = ((uint)(4));
			w29.BottomAttach = ((uint)(5));
			w29.LeftAttach = ((uint)(3));
			w29.RightAttach = ((uint)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.botonAtras = new global::Gtk.Button ();
			this.botonAtras.CanFocus = true;
			this.botonAtras.Name = "botonAtras";
			this.botonAtras.UseUnderline = true;
			// Container child botonAtras.Gtk.Container+ContainerChild
			global::Gtk.Alignment w30 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w31 = new global::Gtk.HBox ();
			w31.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w32 = new global::Gtk.Image ();
			w32.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-home", global::Gtk.IconSize.Menu);
			w31.Add (w32);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w34 = new global::Gtk.Label ();
			w34.LabelProp = global::Mono.Unix.Catalog.GetString ("Atrás");
			w34.UseUnderline = true;
			w31.Add (w34);
			w30.Add (w31);
			this.botonAtras.Add (w30);
			this.table13.Add (this.botonAtras);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table13 [this.botonAtras]));
			w38.TopAttach = ((uint)(4));
			w38.BottomAttach = ((uint)(5));
			w38.LeftAttach = ((uint)(2));
			w38.RightAttach = ((uint)(3));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.botonCancelar = new global::Gtk.Button ();
			this.botonCancelar.CanFocus = true;
			this.botonCancelar.Name = "botonCancelar";
			this.botonCancelar.UseUnderline = true;
			// Container child botonCancelar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w39 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w40 = new global::Gtk.HBox ();
			w40.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w41 = new global::Gtk.Image ();
			w41.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w40.Add (w41);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w43 = new global::Gtk.Label ();
			w43.LabelProp = global::Mono.Unix.Catalog.GetString ("Cancelar");
			w43.UseUnderline = true;
			w40.Add (w43);
			w39.Add (w40);
			this.botonCancelar.Add (w39);
			this.table13.Add (this.botonCancelar);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table13 [this.botonCancelar]));
			w47.TopAttach = ((uint)(4));
			w47.BottomAttach = ((uint)(5));
			w47.LeftAttach = ((uint)(4));
			w47.RightAttach = ((uint)(5));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed100 = new global::Gtk.Fixed ();
			this.fixed100.Name = "fixed100";
			this.fixed100.HasWindow = false;
			this.table13.Add (this.fixed100);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed100]));
			w48.TopAttach = ((uint)(3));
			w48.BottomAttach = ((uint)(4));
			w48.LeftAttach = ((uint)(3));
			w48.RightAttach = ((uint)(4));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed101 = new global::Gtk.Fixed ();
			this.fixed101.Name = "fixed101";
			this.fixed101.HasWindow = false;
			this.table13.Add (this.fixed101);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed101]));
			w49.TopAttach = ((uint)(3));
			w49.BottomAttach = ((uint)(4));
			w49.LeftAttach = ((uint)(2));
			w49.RightAttach = ((uint)(3));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed102 = new global::Gtk.Fixed ();
			this.fixed102.Name = "fixed102";
			this.fixed102.HasWindow = false;
			this.table13.Add (this.fixed102);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed102]));
			w50.TopAttach = ((uint)(3));
			w50.BottomAttach = ((uint)(4));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed103 = new global::Gtk.Fixed ();
			this.fixed103.Name = "fixed103";
			this.fixed103.HasWindow = false;
			this.table13.Add (this.fixed103);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed103]));
			w51.TopAttach = ((uint)(3));
			w51.BottomAttach = ((uint)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed104 = new global::Gtk.Fixed ();
			this.fixed104.Name = "fixed104";
			this.fixed104.HasWindow = false;
			this.table13.Add (this.fixed104);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed104]));
			w52.TopAttach = ((uint)(4));
			w52.BottomAttach = ((uint)(5));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed105 = new global::Gtk.Fixed ();
			this.fixed105.Name = "fixed105";
			this.fixed105.HasWindow = false;
			this.table13.Add (this.fixed105);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed105]));
			w53.TopAttach = ((uint)(4));
			w53.BottomAttach = ((uint)(5));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed84 = new global::Gtk.Fixed ();
			this.fixed84.Name = "fixed84";
			this.fixed84.HasWindow = false;
			this.table13.Add (this.fixed84);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed84]));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed85 = new global::Gtk.Fixed ();
			this.fixed85.Name = "fixed85";
			this.fixed85.HasWindow = false;
			this.table13.Add (this.fixed85);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed85]));
			w55.TopAttach = ((uint)(1));
			w55.BottomAttach = ((uint)(2));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed86 = new global::Gtk.Fixed ();
			this.fixed86.Name = "fixed86";
			this.fixed86.HasWindow = false;
			this.table13.Add (this.fixed86);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed86]));
			w56.LeftAttach = ((uint)(1));
			w56.RightAttach = ((uint)(2));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed87 = new global::Gtk.Fixed ();
			this.fixed87.Name = "fixed87";
			this.fixed87.HasWindow = false;
			this.table13.Add (this.fixed87);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed87]));
			w57.TopAttach = ((uint)(1));
			w57.BottomAttach = ((uint)(2));
			w57.LeftAttach = ((uint)(1));
			w57.RightAttach = ((uint)(2));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed88 = new global::Gtk.Fixed ();
			this.fixed88.Name = "fixed88";
			this.fixed88.HasWindow = false;
			this.table13.Add (this.fixed88);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed88]));
			w58.LeftAttach = ((uint)(2));
			w58.RightAttach = ((uint)(3));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed89 = new global::Gtk.Fixed ();
			this.fixed89.Name = "fixed89";
			this.fixed89.HasWindow = false;
			this.table13.Add (this.fixed89);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed89]));
			w59.TopAttach = ((uint)(1));
			w59.BottomAttach = ((uint)(2));
			w59.LeftAttach = ((uint)(2));
			w59.RightAttach = ((uint)(3));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed90 = new global::Gtk.Fixed ();
			this.fixed90.Name = "fixed90";
			this.fixed90.HasWindow = false;
			this.table13.Add (this.fixed90);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed90]));
			w60.LeftAttach = ((uint)(3));
			w60.RightAttach = ((uint)(4));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed91 = new global::Gtk.Fixed ();
			this.fixed91.Name = "fixed91";
			this.fixed91.HasWindow = false;
			this.table13.Add (this.fixed91);
			global::Gtk.Table.TableChild w61 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed91]));
			w61.TopAttach = ((uint)(1));
			w61.BottomAttach = ((uint)(2));
			w61.LeftAttach = ((uint)(3));
			w61.RightAttach = ((uint)(4));
			w61.XOptions = ((global::Gtk.AttachOptions)(4));
			w61.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed92 = new global::Gtk.Fixed ();
			this.fixed92.Name = "fixed92";
			this.fixed92.HasWindow = false;
			this.table13.Add (this.fixed92);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed92]));
			w62.LeftAttach = ((uint)(4));
			w62.RightAttach = ((uint)(5));
			w62.XOptions = ((global::Gtk.AttachOptions)(4));
			w62.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed93 = new global::Gtk.Fixed ();
			this.fixed93.Name = "fixed93";
			this.fixed93.HasWindow = false;
			this.table13.Add (this.fixed93);
			global::Gtk.Table.TableChild w63 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed93]));
			w63.TopAttach = ((uint)(1));
			w63.BottomAttach = ((uint)(2));
			w63.LeftAttach = ((uint)(4));
			w63.RightAttach = ((uint)(5));
			w63.XOptions = ((global::Gtk.AttachOptions)(4));
			w63.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed94 = new global::Gtk.Fixed ();
			this.fixed94.Name = "fixed94";
			this.fixed94.HasWindow = false;
			this.table13.Add (this.fixed94);
			global::Gtk.Table.TableChild w64 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed94]));
			w64.TopAttach = ((uint)(2));
			w64.BottomAttach = ((uint)(3));
			w64.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed95 = new global::Gtk.Fixed ();
			this.fixed95.Name = "fixed95";
			this.fixed95.HasWindow = false;
			this.table13.Add (this.fixed95);
			global::Gtk.Table.TableChild w65 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed95]));
			w65.TopAttach = ((uint)(2));
			w65.BottomAttach = ((uint)(3));
			w65.LeftAttach = ((uint)(1));
			w65.RightAttach = ((uint)(2));
			w65.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed96 = new global::Gtk.Fixed ();
			this.fixed96.Name = "fixed96";
			this.fixed96.HasWindow = false;
			this.table13.Add (this.fixed96);
			global::Gtk.Table.TableChild w66 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed96]));
			w66.TopAttach = ((uint)(2));
			w66.BottomAttach = ((uint)(3));
			w66.LeftAttach = ((uint)(2));
			w66.RightAttach = ((uint)(3));
			w66.XOptions = ((global::Gtk.AttachOptions)(4));
			w66.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed97 = new global::Gtk.Fixed ();
			this.fixed97.Name = "fixed97";
			this.fixed97.HasWindow = false;
			this.table13.Add (this.fixed97);
			global::Gtk.Table.TableChild w67 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed97]));
			w67.TopAttach = ((uint)(2));
			w67.BottomAttach = ((uint)(3));
			w67.LeftAttach = ((uint)(3));
			w67.RightAttach = ((uint)(4));
			w67.XOptions = ((global::Gtk.AttachOptions)(4));
			w67.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed98 = new global::Gtk.Fixed ();
			this.fixed98.Name = "fixed98";
			this.fixed98.HasWindow = false;
			this.table13.Add (this.fixed98);
			global::Gtk.Table.TableChild w68 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed98]));
			w68.TopAttach = ((uint)(2));
			w68.BottomAttach = ((uint)(3));
			w68.LeftAttach = ((uint)(4));
			w68.RightAttach = ((uint)(5));
			w68.XOptions = ((global::Gtk.AttachOptions)(4));
			w68.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table13.Gtk.Table+TableChild
			this.fixed99 = new global::Gtk.Fixed ();
			this.fixed99.Name = "fixed99";
			this.fixed99.HasWindow = false;
			this.table13.Add (this.fixed99);
			global::Gtk.Table.TableChild w69 = ((global::Gtk.Table.TableChild)(this.table13 [this.fixed99]));
			w69.TopAttach = ((uint)(3));
			w69.BottomAttach = ((uint)(4));
			w69.LeftAttach = ((uint)(4));
			w69.RightAttach = ((uint)(5));
			w69.XOptions = ((global::Gtk.AttachOptions)(4));
			w69.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table13);
			global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table13]));
			w70.Position = 6;
			this.Add (this.vbox6);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 542;
			this.DefaultHeight = 202;
			this.Show ();
			this.comboboxCafe.Changed += new global::System.EventHandler (this.OnComboboxCafeChanged);
			this.comboboxBebida.Changed += new global::System.EventHandler (this.OnComboboxBebidaChanged);
			this.botonCancelar.Clicked += new global::System.EventHandler (this.OnBotonCancelarClicked);
			this.botonAtras.Clicked += new global::System.EventHandler (this.OnBotonAtrasClicked);
			this.botonAceptar.Clicked += new global::System.EventHandler (this.OnBotonAceptarClicked);
		}
	}
}