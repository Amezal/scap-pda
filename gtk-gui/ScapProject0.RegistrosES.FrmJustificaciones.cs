
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.RegistrosES
{
	public partial class FrmJustificaciones
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action GuardarAction;

		private global::Gtk.Action cancelAction;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Calendar cldFin;

		private global::Gtk.Label label1;

		private global::Gtk.Calendar cldInicio;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.SpinButton entHoraInicio;

		private global::Gtk.Label label4;

		private global::Gtk.SpinButton entMinInicio;

		private global::Gtk.Label label5;

		private global::Gtk.SpinButton entHoraFin;

		private global::Gtk.Label label6;

		private global::Gtk.SpinButton entMinFin;

		private global::Gtk.Label label7;

		private global::Gtk.Button button1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView entDesc;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.RegistrosES.FrmJustificaciones
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.GuardarAction = new global::Gtk.Action("GuardarAction", global::Mono.Unix.Catalog.GetString("  Guardar"), null, "save");
			this.GuardarAction.IsImportant = true;
			this.GuardarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Guardar");
			w1.Add(this.GuardarAction, null);
			this.cancelAction = new global::Gtk.Action("cancelAction", null, null, "cancel");
			this.cancelAction.IsImportant = true;
			this.cancelAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Cancelar");
			w1.Add(this.cancelAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.RegistrosES.FrmJustificaciones";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmJustificaciones");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.RegistrosES.FrmJustificaciones.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.WidthRequest = 0;
			this.fixed1.HeightRequest = 0;
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem name=\'GuardarAction\' action=\'GuardarAction" +
					"\'/><separator/><toolitem name=\'cancelAction\' action=\'cancelAction\'/></toolbar></" +
					"ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
			w2.X = 3;
			w2.Y = 9;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cldFin = new global::Gtk.Calendar();
			this.cldFin.CanFocus = true;
			this.cldFin.Name = "cldFin";
			this.cldFin.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.fixed1.Add(this.cldFin);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cldFin]));
			w3.X = 496;
			w3.Y = 73;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha Inicio: ");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w4.X = 16;
			w4.Y = 99;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cldInicio = new global::Gtk.Calendar();
			this.cldInicio.CanFocus = true;
			this.cldInicio.Name = "cldInicio";
			this.cldInicio.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.fixed1.Add(this.cldInicio);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cldInicio]));
			w5.X = 116;
			w5.Y = 71;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha Fin:");
			this.fixed1.Add(this.label2);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
			w6.X = 410;
			w6.Y = 99;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Hora Inicio:");
			this.fixed1.Add(this.label3);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
			w7.X = 23;
			w7.Y = 298;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entHoraInicio = new global::Gtk.SpinButton(0D, 23D, 1D);
			this.entHoraInicio.CanFocus = true;
			this.entHoraInicio.Name = "entHoraInicio";
			this.entHoraInicio.Adjustment.PageIncrement = 10D;
			this.entHoraInicio.ClimbRate = 1D;
			this.entHoraInicio.Numeric = true;
			this.fixed1.Add(this.entHoraInicio);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entHoraInicio]));
			w8.X = 114;
			w8.Y = 291;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString(":");
			this.fixed1.Add(this.label4);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
			w9.X = 193;
			w9.Y = 298;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entMinInicio = new global::Gtk.SpinButton(0D, 59D, 1D);
			this.entMinInicio.CanFocus = true;
			this.entMinInicio.Name = "entMinInicio";
			this.entMinInicio.Adjustment.PageIncrement = 10D;
			this.entMinInicio.ClimbRate = 1D;
			this.entMinInicio.Numeric = true;
			this.fixed1.Add(this.entMinInicio);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entMinInicio]));
			w10.X = 204;
			w10.Y = 291;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Hora Fin:");
			this.fixed1.Add(this.label5);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label5]));
			w11.X = 415;
			w11.Y = 298;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entHoraFin = new global::Gtk.SpinButton(0D, 23D, 1D);
			this.entHoraFin.CanFocus = true;
			this.entHoraFin.Name = "entHoraFin";
			this.entHoraFin.Adjustment.PageIncrement = 10D;
			this.entHoraFin.ClimbRate = 1D;
			this.entHoraFin.Numeric = true;
			this.fixed1.Add(this.entHoraFin);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entHoraFin]));
			w12.X = 494;
			w12.Y = 291;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString(":");
			this.fixed1.Add(this.label6);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label6]));
			w13.X = 573;
			w13.Y = 298;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entMinFin = new global::Gtk.SpinButton(0D, 59D, 1D);
			this.entMinFin.CanFocus = true;
			this.entMinFin.Name = "entMinFin";
			this.entMinFin.Adjustment.PageIncrement = 10D;
			this.entMinFin.ClimbRate = 1D;
			this.entMinFin.Numeric = true;
			this.fixed1.Add(this.entMinFin);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entMinFin]));
			w14.X = 584;
			w14.Y = 291;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Justificacion:");
			this.fixed1.Add(this.label7);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label7]));
			w15.X = 31;
			w15.Y = 378;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w16.X = 35;
			w16.Y = 611;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 575;
			this.GtkScrolledWindow.HeightRequest = 227;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.entDesc = new global::Gtk.TextView();
			this.entDesc.CanFocus = true;
			this.entDesc.Name = "entDesc";
			this.GtkScrolledWindow.Add(this.entDesc);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w18.X = 144;
			w18.Y = 375;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 788;
			this.DefaultHeight = 705;
			this.Show();
			this.GuardarAction.Activated += new global::System.EventHandler(this.OnGuardarActionActivated);
			this.cancelAction.Activated += new global::System.EventHandler(this.OnCancelActionActivated);
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		}
	}
}
