
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0
{
	public partial class FrmGenerarReportes
	{
		private global::Gtk.Fixed fixed3;

		private global::Gtk.RadioButton radiobutton1;

		private global::Gtk.RadioButton radiobutton2;

		private global::Gtk.RadioButton radiobutton3;

		private global::Gtk.Label label2;

		private global::Gtk.ComboBox combobox2;

		private global::Gtk.Label label3;

		private global::Gtk.ComboBox combobox3;

		private global::Gtk.Button button9;

		private global::Gtk.Button button10;

		private global::Gtk.ComboBoxEntry cbxeEmp;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.FrmGenerarReportes
			this.Name = "ScapProject0.FrmGenerarReportes";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmGenerarReportes");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.FrmGenerarReportes.Gtk.Container+ContainerChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.radiobutton1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Departamento"));
			this.radiobutton1.CanFocus = true;
			this.radiobutton1.Name = "radiobutton1";
			this.radiobutton1.Active = true;
			this.radiobutton1.DrawIndicator = true;
			this.radiobutton1.UseUnderline = true;
			this.radiobutton1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.fixed3.Add(this.radiobutton1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.radiobutton1]));
			w1.X = 51;
			w1.Y = 58;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.radiobutton2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Cargo"));
			this.radiobutton2.CanFocus = true;
			this.radiobutton2.Name = "radiobutton2";
			this.radiobutton2.DrawIndicator = true;
			this.radiobutton2.UseUnderline = true;
			this.radiobutton2.Group = this.radiobutton1.Group;
			this.fixed3.Add(this.radiobutton2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.radiobutton2]));
			w2.X = 51;
			w2.Y = 117;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.radiobutton3 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Empleado"));
			this.radiobutton3.CanFocus = true;
			this.radiobutton3.Name = "radiobutton3";
			this.radiobutton3.DrawIndicator = true;
			this.radiobutton3.UseUnderline = true;
			this.radiobutton3.Group = this.radiobutton1.Group;
			this.fixed3.Add(this.radiobutton3);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.radiobutton3]));
			w3.X = 51;
			w3.Y = 177;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Rango");
			this.fixed3.Add(this.label2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label2]));
			w4.X = 51;
			w4.Y = 250;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.combobox2 = global::Gtk.ComboBox.NewText();
			this.combobox2.WidthRequest = 158;
			this.combobox2.HeightRequest = 25;
			this.combobox2.Name = "combobox2";
			this.fixed3.Add(this.combobox2);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.combobox2]));
			w5.X = 190;
			w5.Y = 250;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Tipo");
			this.fixed3.Add(this.label3);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label3]));
			w6.X = 51;
			w6.Y = 319;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.combobox3 = global::Gtk.ComboBox.NewText();
			this.combobox3.WidthRequest = 158;
			this.combobox3.HeightRequest = 25;
			this.combobox3.Name = "combobox3";
			this.fixed3.Add(this.combobox3);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.combobox3]));
			w7.X = 190;
			w7.Y = 316;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.button9 = new global::Gtk.Button();
			this.button9.WidthRequest = 119;
			this.button9.HeightRequest = 25;
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString("REGRESAR");
			this.fixed3.Add(this.button9);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.button9]));
			w8.X = 43;
			w8.Y = 418;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.button10 = new global::Gtk.Button();
			this.button10.HeightRequest = 25;
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseUnderline = true;
			this.button10.Label = global::Mono.Unix.Catalog.GetString("GENERAR REPORTE");
			this.fixed3.Add(this.button10);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.button10]));
			w9.X = 224;
			w9.Y = 418;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.cbxeEmp = global::Gtk.ComboBoxEntry.NewText();
			this.cbxeEmp.WidthRequest = 158;
			this.cbxeEmp.HeightRequest = 25;
			this.cbxeEmp.Name = "cbxeEmp";
			this.fixed3.Add(this.cbxeEmp);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.cbxeEmp]));
			w10.X = 188;
			w10.Y = 181;
			this.Add(this.fixed3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 421;
			this.DefaultHeight = 479;
			this.Show();
			this.button9.Clicked += new global::System.EventHandler(this.OnButton9Clicked);
		}
	}
}
