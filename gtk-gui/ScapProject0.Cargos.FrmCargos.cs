
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Cargos
{
	public partial class FrmCargos
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action AgregarAction;

		private global::Gtk.Action EliminarAction;

		private global::Gtk.Action ModificarAction;

		private global::Gtk.Action BuscarAction;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button btnBack;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView tvwCar;

		private global::Gtk.ComboBoxEntry cbxCargos;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Cargos.FrmCargos
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
			this.ModificarAction = new global::Gtk.Action("ModificarAction", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.ModificarAction.IsImportant = true;
			this.ModificarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.ModificarAction, null);
			this.BuscarAction = new global::Gtk.Action("BuscarAction", global::Mono.Unix.Catalog.GetString("  Buscar"), null, "search");
			this.BuscarAction.IsImportant = true;
			this.BuscarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Buscar");
			w1.Add(this.BuscarAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Cargos.FrmCargos";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmCargos");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.Cargos.FrmCargos.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnBack = new global::Gtk.Button();
			this.btnBack.CanFocus = true;
			this.btnBack.Name = "btnBack";
			this.btnBack.UseUnderline = true;
			this.btnBack.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.btnBack);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnBack]));
			w2.X = 47;
			w2.Y = 364;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar1'><toolitem name='AgregarAction' action='AgregarAction'/><toolitem name='EliminarAction' action='EliminarAction'/><toolitem name='ModificarAction' action='ModificarAction'/><toolitem name='BuscarAction' action='BuscarAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
			w3.X = 31;
			w3.Y = 38;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tvwCar = new global::Gtk.TreeView();
			this.tvwCar.WidthRequest = 550;
			this.tvwCar.HeightRequest = 240;
			this.tvwCar.CanFocus = true;
			this.tvwCar.Name = "tvwCar";
			this.GtkScrolledWindow.Add(this.tvwCar);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w5.X = 67;
			w5.Y = 94;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cbxCargos = global::Gtk.ComboBoxEntry.NewText();
			this.cbxCargos.Name = "cbxCargos";
			this.fixed1.Add(this.cbxCargos);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cbxCargos]));
			w6.X = 445;
			w6.Y = 41;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 856;
			this.DefaultHeight = 515;
			this.Show();
			this.AgregarAction.Activated += new global::System.EventHandler(this.OnAgregarActionActivated);
			this.ModificarAction.Activated += new global::System.EventHandler(this.OnModificarActionActivated);
			this.btnBack.Clicked += new global::System.EventHandler(this.OnBtnBackClicked);
			this.tvwCar.CursorChanged += new global::System.EventHandler(this.OnTvwCarCursorChanged);
		}
	}
}
