
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Roles
{
	public partial class FrmAddRol
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action btnGuardar;

		private global::Gtk.Action btnCancelar;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Button btnRegresar;

		private global::Gtk.Label label1;

		private global::Gtk.Entry txtRol;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Roles.FrmAddRol
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.btnGuardar = new global::Gtk.Action("btnGuardar", global::Mono.Unix.Catalog.GetString("  Guardar"), null, "save");
			this.btnGuardar.IsImportant = true;
			this.btnGuardar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Guardar");
			w1.Add(this.btnGuardar, null);
			this.btnCancelar = new global::Gtk.Action("btnCancelar", global::Mono.Unix.Catalog.GetString("  Cancelar"), null, "cancel");
			this.btnCancelar.IsImportant = true;
			this.btnCancelar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Cancelar");
			w1.Add(this.btnCancelar, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Roles.FrmAddRol";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmAddRol");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ScapProject0.Roles.FrmAddRol.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem name=\'btnGuardar\' action=\'btnGuardar\'/><to" +
					"olitem name=\'btnCancelar\' action=\'btnCancelar\'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.btnRegresar);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnRegresar]));
			w3.X = 29;
			w3.Y = 203;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Rol: ");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w4.X = 55;
			w4.Y = 105;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtRol = new global::Gtk.Entry();
			this.txtRol.CanFocus = true;
			this.txtRol.Name = "txtRol";
			this.txtRol.IsEditable = true;
			this.txtRol.InvisibleChar = '•';
			this.fixed1.Add(this.txtRol);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtRol]));
			w5.X = 99;
			w5.Y = 97;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 396;
			this.DefaultHeight = 292;
			this.Show();
			this.btnGuardar.Activated += new global::System.EventHandler(this.OnBtnGuardarActivated);
			this.btnRegresar.Clicked += new global::System.EventHandler(this.OnBtnRegresarClicked);
		}
	}
}
