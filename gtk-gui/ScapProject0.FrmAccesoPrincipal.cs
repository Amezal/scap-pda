
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0
{
	public partial class FrmAccesoPrincipal
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label label1;

		private global::Gtk.Button button1;

		private global::Gtk.Button button2;

		private global::Gtk.Button button3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.FrmAccesoPrincipal
			this.Name = "ScapProject0.FrmAccesoPrincipal";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmAccesoPrincipal");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.FrmAccesoPrincipal.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("ACCEDER COMO:");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w1.X = 143;
			w1.Y = 52;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.WidthRequest = 152;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("EMPLEADO");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w2.X = 122;
			w2.Y = 107;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 152;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("ADMINISTRADOR");
			this.fixed1.Add(this.button2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
			w3.X = 122;
			w3.Y = 169;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button();
			this.button3.WidthRequest = 119;
			this.button3.HeightRequest = 25;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("SALIR");
			this.fixed1.Add(this.button3);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
			w4.X = 15;
			w4.Y = 260;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
			this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		}
	}
}
