
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Empleados
{
	public partial class FrmEmp
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action AgregarAction;

		private global::Gtk.Action EliminarAction;

		private global::Gtk.Action modifyAction;

		private global::Gtk.Action ModificarAction;

		private global::Gtk.Action searchAction;

		private global::Gtk.Action AgregarAction1;

		private global::Gtk.Action EliminarAction1;

		private global::Gtk.Action ModificarAction1;

		private global::Gtk.Action BuscarAction;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.Toolbar toolbar2;

		private global::Gtk.Entry entBuscar;

		private global::Gtk.Button button1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvwEmpleado;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Empleados.FrmEmp
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
			this.modifyAction = new global::Gtk.Action("modifyAction", null, null, "modify");
			w1.Add(this.modifyAction, null);
			this.ModificarAction = new global::Gtk.Action("ModificarAction", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.ModificarAction.IsImportant = true;
			this.ModificarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.ModificarAction, null);
			this.searchAction = new global::Gtk.Action("searchAction", null, null, "search");
			w1.Add(this.searchAction, null);
			this.AgregarAction1 = new global::Gtk.Action("AgregarAction1", global::Mono.Unix.Catalog.GetString("  Agregar"), null, "add");
			this.AgregarAction1.IsImportant = true;
			this.AgregarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("  Agregar");
			w1.Add(this.AgregarAction1, null);
			this.EliminarAction1 = new global::Gtk.Action("EliminarAction1", global::Mono.Unix.Catalog.GetString("  Eliminar"), null, "delete");
			this.EliminarAction1.IsImportant = true;
			this.EliminarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("  Eliminar");
			w1.Add(this.EliminarAction1, null);
			this.ModificarAction1 = new global::Gtk.Action("ModificarAction1", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.ModificarAction1.IsImportant = true;
			this.ModificarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.ModificarAction1, null);
			this.BuscarAction = new global::Gtk.Action("BuscarAction", global::Mono.Unix.Catalog.GetString("  Buscar"), null, "search");
			this.BuscarAction.IsImportant = true;
			this.BuscarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Buscar");
			w1.Add(this.BuscarAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Empleados.FrmEmp";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmEmp");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.Empleados.FrmEmp.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar2'><toolitem name='AgregarAction1' action='AgregarAction1'/><separator/><toolitem name='EliminarAction1' action='EliminarAction1'/><toolitem name='ModificarAction1' action='ModificarAction1'/><toolitem name='BuscarAction' action='BuscarAction'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.fixed2.Add(this.toolbar2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.toolbar2]));
			w2.X = 19;
			w2.Y = 12;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.entBuscar = new global::Gtk.Entry();
			this.entBuscar.CanFocus = true;
			this.entBuscar.Name = "entBuscar";
			this.entBuscar.IsEditable = true;
			this.entBuscar.InvisibleChar = '•';
			this.fixed2.Add(this.entBuscar);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entBuscar]));
			w3.X = 434;
			w3.Y = 18;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.UseUnderline = true;
			this.button1.Label = "Regresar";
			this.fixed2.Add(this.button1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button1]));
			w4.X = 29;
			w4.Y = 360;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvwEmpleado = new global::Gtk.TreeView();
			this.trvwEmpleado.WidthRequest = 671;
			this.trvwEmpleado.HeightRequest = 240;
			this.trvwEmpleado.CanFocus = true;
			this.trvwEmpleado.Name = "trvwEmpleado";
			this.GtkScrolledWindow.Add(this.trvwEmpleado);
			this.fixed2.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.GtkScrolledWindow]));
			w6.X = 24;
			w6.Y = 81;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 722;
			this.DefaultHeight = 466;
			this.Show();
			this.AgregarAction1.Activated += new global::System.EventHandler(this.OnAgregarAction1Activated);
			this.EliminarAction1.Activated += new global::System.EventHandler(this.OnEliminarAction1Activated);
			this.ModificarAction1.Activated += new global::System.EventHandler(this.OnModificarAction1Activated);
			this.BuscarAction.Activated += new global::System.EventHandler(this.OnBuscarActionActivated);
			this.entBuscar.Changed += new global::System.EventHandler(this.OnEntBuscarChanged);
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
			this.trvwEmpleado.CursorChanged += new global::System.EventHandler(this.OnTrvwEmpleadoCursorChanged);
			this.trvwEmpleado.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTrvwEmpleadoRowActivated);
		}
	}
}
