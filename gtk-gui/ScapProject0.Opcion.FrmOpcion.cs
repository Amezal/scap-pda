
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Opcion
{
	public partial class FrmOpcion
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action Action;

		private global::Gtk.Action btnAdd;

		private global::Gtk.Action deleteAction;

		private global::Gtk.Action deleteAction1;

		private global::Gtk.Action btnDelete;

		private global::Gtk.Action btnModify;

		private global::Gtk.Action btnSearch;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Toolbar toolbar2;

		private global::Gtk.Entry entry1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView twOpcion;

		private global::Gtk.Button btnBack;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Opcion.FrmOpcion
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.Action = new global::Gtk.Action("Action", null, null, null);
			w1.Add(this.Action, null);
			this.btnAdd = new global::Gtk.Action("btnAdd", global::Mono.Unix.Catalog.GetString("Agregar"), null, "add");
			this.btnAdd.IsImportant = true;
			this.btnAdd.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
			w1.Add(this.btnAdd, null);
			this.deleteAction = new global::Gtk.Action("deleteAction", null, null, "delete");
			w1.Add(this.deleteAction, null);
			this.deleteAction1 = new global::Gtk.Action("deleteAction1", null, null, "delete");
			w1.Add(this.deleteAction1, null);
			this.btnDelete = new global::Gtk.Action("btnDelete", global::Mono.Unix.Catalog.GetString("Eliminar"), null, "delete");
			this.btnDelete.IsImportant = true;
			this.btnDelete.ShortLabel = global::Mono.Unix.Catalog.GetString("Eliminar");
			w1.Add(this.btnDelete, null);
			this.btnModify = new global::Gtk.Action("btnModify", global::Mono.Unix.Catalog.GetString("Modificar"), null, "modify");
			this.btnModify.IsImportant = true;
			this.btnModify.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar");
			w1.Add(this.btnModify, null);
			this.btnSearch = new global::Gtk.Action("btnSearch", global::Mono.Unix.Catalog.GetString("Buscar"), null, "search");
			this.btnSearch.IsImportant = true;
			this.btnSearch.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.btnSearch, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Opcion.FrmOpcion";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmOpcion");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ScapProject0.Opcion.FrmOpcion.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.fixed1.Add(this.toolbar1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
			w2.X = 52;
			w2.Y = 31;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar2\'><toolitem name=\'btnAdd\' action=\'btnAdd\'/><toolitem n" +
					"ame=\'btnDelete\' action=\'btnDelete\'/><toolitem name=\'btnModify\' action=\'btnModify" +
					"\'/><toolitem name=\'btnSearch\' action=\'btnSearch\'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.fixed1.Add(this.toolbar2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar2]));
			w3.X = 21;
			w3.Y = 23;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
			w4.X = 397;
			w4.Y = 31;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.twOpcion = new global::Gtk.TreeView();
			this.twOpcion.WidthRequest = 415;
			this.twOpcion.HeightRequest = 239;
			this.twOpcion.CanFocus = true;
			this.twOpcion.Name = "twOpcion";
			this.GtkScrolledWindow.Add(this.twOpcion);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w6.X = 139;
			w6.Y = 82;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnBack = new global::Gtk.Button();
			this.btnBack.CanFocus = true;
			this.btnBack.Name = "btnBack";
			this.btnBack.UseUnderline = true;
			this.btnBack.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed1.Add(this.btnBack);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnBack]));
			w7.X = 43;
			w7.Y = 353;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 776;
			this.DefaultHeight = 408;
			this.Show();
			this.btnAdd.Activated += new global::System.EventHandler(this.OnBtnAddActivated);
			this.btnDelete.Activated += new global::System.EventHandler(this.OnBtnDeleteActivated);
			this.btnModify.Activated += new global::System.EventHandler(this.OnBtnModifyActivated);
			this.btnSearch.Activated += new global::System.EventHandler(this.OnBtnSearchActivated);
			this.twOpcion.CursorChanged += new global::System.EventHandler(this.OnTwOpcionCursorChanged);
			this.btnBack.Clicked += new global::System.EventHandler(this.OnBtnBackClicked);
		}
	}
}
