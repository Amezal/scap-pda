
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Roles
{
	public partial class FrmRol
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action btnAgregar;

		private global::Gtk.Action btnEliminar;

		private global::Gtk.Action btnModificar;

		private global::Gtk.Action btnBuscar;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Entry entBuscar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvwRol;

		private global::Gtk.Button btnRegresar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Roles.FrmRol
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.btnAgregar = new global::Gtk.Action("btnAgregar", global::Mono.Unix.Catalog.GetString("  Agregar"), null, "add");
			this.btnAgregar.IsImportant = true;
			this.btnAgregar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Agregar");
			w1.Add(this.btnAgregar, null);
			this.btnEliminar = new global::Gtk.Action("btnEliminar", global::Mono.Unix.Catalog.GetString("  Eliminar"), null, "delete");
			this.btnEliminar.IsImportant = true;
			this.btnEliminar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Eliminar");
			w1.Add(this.btnEliminar, null);
			this.btnModificar = new global::Gtk.Action("btnModificar", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.btnModificar.IsImportant = true;
			this.btnModificar.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.btnModificar, null);
			this.btnBuscar = new global::Gtk.Action("btnBuscar", null, null, "search");
			this.btnBuscar.IsImportant = true;
			w1.Add(this.btnBuscar, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Roles.FrmRol";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmRol");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ScapProject0.Roles.FrmRol.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem name=\'btnAgregar\' action=\'btnAgregar\'/><to" +
					"olitem name=\'btnEliminar\' action=\'btnEliminar\'/><toolitem name=\'btnModificar\' ac" +
					"tion=\'btnModificar\'/><toolitem name=\'btnBuscar\' action=\'btnBuscar\'/></toolbar></" +
					"ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
			w2.X = 2;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entBuscar = new global::Gtk.Entry();
			this.entBuscar.WidthRequest = 247;
			this.entBuscar.CanFocus = true;
			this.entBuscar.Name = "entBuscar";
			this.entBuscar.IsEditable = true;
			this.entBuscar.InvisibleChar = '•';
			this.fixed1.Add(this.entBuscar);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entBuscar]));
			w3.X = 353;
			w3.Y = 6;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 660;
			this.GtkScrolledWindow.HeightRequest = 334;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvwRol = new global::Gtk.TreeView();
			this.trvwRol.CanFocus = true;
			this.trvwRol.Name = "trvwRol";
			this.GtkScrolledWindow.Add(this.trvwRol);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w5.X = 24;
			w5.Y = 66;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.btnRegresar);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnRegresar]));
			w6.X = 21;
			w6.Y = 430;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 726;
			this.DefaultHeight = 489;
			this.Show();
			this.btnAgregar.Activated += new global::System.EventHandler(this.OnBtnAgregarActivated);
			this.btnEliminar.Activated += new global::System.EventHandler(this.OnBtnEliminarActivated);
			this.btnModificar.Activated += new global::System.EventHandler(this.OnBtnModificarActivated);
			this.trvwRol.CursorChanged += new global::System.EventHandler(this.OnTrvwRolCursorChanged);
			this.trvwRol.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTrvwRolRowActivated);
		}
	}
}
