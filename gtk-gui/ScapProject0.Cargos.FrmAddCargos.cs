
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Cargos
{
	public partial class FrmAddCargos
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action GuardarAction;

		private global::Gtk.Action CancelarAction;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entry1;

		private global::Gtk.Toolbar toolbar3;

		private global::Gtk.Button btnBack;

		private global::Gtk.ComboBox cbxSelectDpto;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Cargos.FrmAddCargos
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.GuardarAction = new global::Gtk.Action("GuardarAction", global::Mono.Unix.Catalog.GetString("  Guardar"), null, "save");
			this.GuardarAction.IsImportant = true;
			this.GuardarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Guardar");
			w1.Add(this.GuardarAction, null);
			this.CancelarAction = new global::Gtk.Action("CancelarAction", global::Mono.Unix.Catalog.GetString("  Cancelar"), null, "cancel");
			this.CancelarAction.IsImportant = true;
			this.CancelarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Cancelar");
			w1.Add(this.CancelarAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Cargos.FrmAddCargos";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmAddCargos");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.Cargos.FrmAddCargos.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Departamento:");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w2.X = 80;
			w2.Y = 155;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo:");
			this.fixed1.Add(this.label2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
			w3.X = 137;
			w3.Y = 207;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
			w4.X = 207;
			w4.Y = 201;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar3\'><toolitem name=\'GuardarAction\' action=\'GuardarAction" +
					"\'/><toolitem name=\'CancelarAction\' action=\'CancelarAction\'/></toolbar></ui>");
			this.toolbar3 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar3")));
			this.toolbar3.Name = "toolbar3";
			this.toolbar3.ShowArrow = false;
			this.fixed1.Add(this.toolbar3);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar3]));
			w5.X = 30;
			w5.Y = 34;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnBack = new global::Gtk.Button();
			this.btnBack.CanFocus = true;
			this.btnBack.Name = "btnBack";
			this.btnBack.UseUnderline = true;
			this.btnBack.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.btnBack);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnBack]));
			w6.X = 51;
			w6.Y = 300;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cbxSelectDpto = global::Gtk.ComboBox.NewText();
			this.cbxSelectDpto.WidthRequest = 172;
			this.cbxSelectDpto.Name = "cbxSelectDpto";
			this.fixed1.Add(this.cbxSelectDpto);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cbxSelectDpto]));
			w7.X = 207;
			w7.Y = 147;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 496;
			this.DefaultHeight = 363;
			this.Show();
			this.btnBack.Clicked += new global::System.EventHandler(this.OnBtnBackClicked);
		}
	}
}
