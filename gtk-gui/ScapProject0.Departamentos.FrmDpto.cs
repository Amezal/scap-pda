
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Departamentos
{
	public partial class FrmDpto
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action AgregarAction;

		private global::Gtk.Action EliminarAction;

		private global::Gtk.Action btnBuscar;

		private global::Gtk.Action btnModificar;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Button button1;

		private global::Gtk.ComboBoxEntry cbxDpto;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView tvwDpto;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Departamentos.FrmDpto
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.AgregarAction = new global::Gtk.Action("AgregarAction", global::Mono.Unix.Catalog.GetString("  Agregar"), null, "add");
			this.AgregarAction.IsImportant = true;
			this.AgregarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Agregar");
			w1.Add(this.AgregarAction, null);
			this.EliminarAction = new global::Gtk.Action("EliminarAction", global::Mono.Unix.Catalog.GetString("  Eliminar"), null, "delete");
			this.EliminarAction.IsImportant = true;
			this.EliminarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Eliminar");
			w1.Add(this.EliminarAction, null);
			this.btnBuscar = new global::Gtk.Action("btnBuscar", global::Mono.Unix.Catalog.GetString("  Buscar"), null, "search");
			this.btnBuscar.IsImportant = true;
			this.btnBuscar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Buscar");
			w1.Add(this.btnBuscar, null);
			this.btnModificar = new global::Gtk.Action("btnModificar", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.btnModificar.IsImportant = true;
			this.btnModificar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.btnModificar, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Departamentos.FrmDpto";
			this.Title = global::Mono.Unix.Catalog.GetString("Departamentos de empleados");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.Departamentos.FrmDpto.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar1'><toolitem name='AgregarAction' action='AgregarAction'/><separator/><toolitem name='EliminarAction' action='EliminarAction'/><separator/><toolitem name='btnModificar' action='btnModificar'/><separator/><toolitem name='btnBuscar' action='btnBuscar'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
			w2.X = 31;
			w2.Y = 38;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w3.X = 47;
			w3.Y = 364;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cbxDpto = global::Gtk.ComboBoxEntry.NewText();
			this.cbxDpto.Name = "cbxDpto";
			this.fixed1.Add(this.cbxDpto);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cbxDpto]));
			w4.X = 475;
			w4.Y = 45;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.tvwDpto = new global::Gtk.TreeView();
			this.tvwDpto.WidthRequest = 550;
			this.tvwDpto.HeightRequest = 240;
			this.tvwDpto.CanFocus = true;
			this.tvwDpto.Name = "tvwDpto";
			this.scrolledwindow1.Add(this.tvwDpto);
			this.fixed1.Add(this.scrolledwindow1);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.scrolledwindow1]));
			w6.X = 67;
			w6.Y = 94;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 862;
			this.DefaultHeight = 523;
			this.Show();
			this.AgregarAction.Activated += new global::System.EventHandler(this.OnAddActionActivated);
			this.btnBuscar.Activated += new global::System.EventHandler(this.OnBtnBuscarActivated);
			this.btnModificar.Activated += new global::System.EventHandler(this.OnBtnModificarActivated);
		}
	}
}
