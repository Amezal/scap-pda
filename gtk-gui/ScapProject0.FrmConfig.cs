
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0
{
	public partial class FrmConfig
	{
		private global::Gtk.Fixed fixed2;

		private global::Gtk.Button button4;

		private global::Gtk.Button button5;

		private global::Gtk.Button button6;

		private global::Gtk.Button button7;

		private global::Gtk.Button button1;

		private global::Gtk.Button button8;

		private global::Gtk.Button button2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.FrmConfig
			this.Name = "ScapProject0.FrmConfig";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmConfig");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.FrmConfig.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button4 = new global::Gtk.Button();
			this.button4.WidthRequest = 221;
			this.button4.HeightRequest = 29;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Usuarios");
			this.fixed2.Add(this.button4);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button4]));
			w1.X = 90;
			w1.Y = 34;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button5 = new global::Gtk.Button();
			this.button5.WidthRequest = 221;
			this.button5.HeightRequest = 29;
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Horarios");
			this.fixed2.Add(this.button5);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button5]));
			w2.X = 90;
			w2.Y = 88;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button6 = new global::Gtk.Button();
			this.button6.WidthRequest = 221;
			this.button6.HeightRequest = 29;
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString("Cargos");
			this.fixed2.Add(this.button6);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button6]));
			w3.X = 90;
			w3.Y = 144;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button7 = new global::Gtk.Button();
			this.button7.WidthRequest = 221;
			this.button7.HeightRequest = 29;
			this.button7.CanFocus = true;
			this.button7.Name = "button7";
			this.button7.UseUnderline = true;
			this.button7.Label = global::Mono.Unix.Catalog.GetString("Departamentos");
			this.fixed2.Add(this.button7);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button7]));
			w4.X = 90;
			w4.Y = 201;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.WidthRequest = 221;
			this.button1.HeightRequest = 29;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Rol");
			this.fixed2.Add(this.button1);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button1]));
			w5.X = 90;
			w5.Y = 260;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button8 = new global::Gtk.Button();
			this.button8.WidthRequest = 119;
			this.button8.HeightRequest = 25;
			this.button8.CanFocus = true;
			this.button8.Name = "button8";
			this.button8.UseUnderline = true;
			this.button8.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed2.Add(this.button8);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button8]));
			w6.X = 13;
			w6.Y = 404;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 221;
			this.button2.HeightRequest = 29;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Opcion");
			this.fixed2.Add(this.button2);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button2]));
			w7.X = 90;
			w7.Y = 319;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 476;
			this.Show();
			this.button4.Clicked += new global::System.EventHandler(this.OnButton4Clicked);
			this.button5.Clicked += new global::System.EventHandler(this.OnButton5Clicked);
			this.button6.Clicked += new global::System.EventHandler(this.OnButton6Clicked);
			this.button7.Clicked += new global::System.EventHandler(this.OnButton7Clicked);
			this.button8.Clicked += new global::System.EventHandler(this.OnButton8Clicked);
			this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		}
	}
}
