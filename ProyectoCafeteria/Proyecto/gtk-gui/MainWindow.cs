
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Fixed fixed4;
	private global::Gtk.Label label3;
	private global::Gtk.Table table2;
	private global::Gtk.Button button10;
	private global::Gtk.Button button11;
	private global::Gtk.Fixed fixed2;
	private global::Gtk.Fixed fixed3;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.HSeparator hseparator1;
	private global::Gtk.Table table1;
	private global::Gtk.Button button1;
	private global::Gtk.Button button2;
	private global::Gtk.Button button3;
	private global::Gtk.Button button4;
	private global::Gtk.Button button5;
	private global::Gtk.Button button6;
	private global::Gtk.Button button7;
	private global::Gtk.Button button8;
	private global::Gtk.Button button9;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.fixed4 = new global::Gtk.Fixed ();
		this.fixed4.Name = "fixed4";
		this.fixed4.HasWindow = false;
		this.vbox1.Add (this.fixed4);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed4]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		w1.Padding = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 1F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
		this.label3.Wrap = true;
		this.label3.Justify = ((global::Gtk.Justification)(1));
		this.vbox1.Add (this.label3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label3]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.button10 = new global::Gtk.Button ();
		this.button10.CanFocus = true;
		this.button10.Name = "button10";
		this.button10.UseUnderline = true;
		this.button10.Label = global::Mono.Unix.Catalog.GetString ("Ticket");
		this.table2.Add (this.button10);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.button10]));
		w3.LeftAttach = ((uint)(2));
		w3.RightAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.button11 = new global::Gtk.Button ();
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		this.button11.Label = global::Mono.Unix.Catalog.GetString ("Nuevo Pedido");
		this.table2.Add (this.button11);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.button11]));
		w4.LeftAttach = ((uint)(3));
		w4.RightAttach = ((uint)(4));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.table2.Add (this.fixed2);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed2]));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.fixed3 = new global::Gtk.Fixed ();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.table2.Add (this.fixed3);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed3]));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table2]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.vbox1.Add (this.fixed1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed1]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(1));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox1.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
		w9.Position = 4;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), true);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("Bebidas Frías");
		this.table1.Add (this.button1);
		// Container child table1.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Bebidas Calientes");
		this.table1.Add (this.button2);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.button2]));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.button3 = new global::Gtk.Button ();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("Bocadillos");
		this.table1.Add (this.button3);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.button3]));
		w12.LeftAttach = ((uint)(2));
		w12.RightAttach = ((uint)(3));
		// Container child table1.Gtk.Table+TableChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("Almuerzo Parte");
		this.table1.Add (this.button4);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.button4]));
		w13.TopAttach = ((uint)(1));
		w13.BottomAttach = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("Almuerzo Completo");
		this.table1.Add (this.button5);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.button5]));
		w14.TopAttach = ((uint)(1));
		w14.BottomAttach = ((uint)(2));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.button6 = new global::Gtk.Button ();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("Desayuno Popular");
		this.table1.Add (this.button6);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.button6]));
		w15.TopAttach = ((uint)(1));
		w15.BottomAttach = ((uint)(2));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		// Container child table1.Gtk.Table+TableChild
		this.button7 = new global::Gtk.Button ();
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString ("Bollería Dulce");
		this.table1.Add (this.button7);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.button7]));
		w16.TopAttach = ((uint)(2));
		w16.BottomAttach = ((uint)(3));
		// Container child table1.Gtk.Table+TableChild
		this.button8 = new global::Gtk.Button ();
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString ("Bollería Salada");
		this.table1.Add (this.button8);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.button8]));
		w17.TopAttach = ((uint)(2));
		w17.BottomAttach = ((uint)(3));
		w17.LeftAttach = ((uint)(1));
		w17.RightAttach = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.button9 = new global::Gtk.Button ();
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString ("Ayuda");
		this.table1.Add (this.button9);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.button9]));
		w18.TopAttach = ((uint)(2));
		w18.BottomAttach = ((uint)(3));
		w18.LeftAttach = ((uint)(2));
		w18.RightAttach = ((uint)(3));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w19.Position = 5;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 497;
		this.DefaultHeight = 336;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button9.Clicked += new global::System.EventHandler (this.OnButton9Clicked);
		this.button8.Clicked += new global::System.EventHandler (this.OnButton8Clicked);
		this.button7.Clicked += new global::System.EventHandler (this.OnButton7Clicked);
		this.button6.Clicked += new global::System.EventHandler (this.OnButton6Clicked);
		this.button5.Clicked += new global::System.EventHandler (this.OnButton5Clicked);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
		this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}