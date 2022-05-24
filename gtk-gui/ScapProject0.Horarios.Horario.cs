
// This file has been generated by the GUI designer. Do not modify.
namespace ScapProject0.Horarios
{
	public partial class Horario
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action AgregarAction;

		private global::Gtk.ToggleAction EliminarAction;

		private global::Gtk.Action ModificarAction;

		private global::Gtk.Action BuscarAction;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.Toolbar toolbar3;

		private global::Gtk.Entry entry3;

		private global::Gtk.Button btnBackHor;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvwHorario;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ScapProject0.Horarios.Horario
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.AgregarAction = new global::Gtk.Action("AgregarAction", global::Mono.Unix.Catalog.GetString("  Agregar"), null, "add");
			this.AgregarAction.IsImportant = true;
			this.AgregarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Agregar");
			w1.Add(this.AgregarAction, null);
			this.EliminarAction = new global::Gtk.ToggleAction("EliminarAction", global::Mono.Unix.Catalog.GetString("  Eliminar"), null, "delete");
			this.EliminarAction.IsImportant = true;
			this.EliminarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Eliminar");
			w1.Add(this.EliminarAction, null);
			this.ModificarAction = new global::Gtk.Action("ModificarAction", global::Mono.Unix.Catalog.GetString("  Modificar"), null, "modify");
			this.ModificarAction.IsImportant = true;
			this.ModificarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("  Modificar");
			w1.Add(this.ModificarAction, null);
			this.BuscarAction = new global::Gtk.Action("BuscarAction", global::Mono.Unix.Catalog.GetString("Buscar"), null, "search");
			this.BuscarAction.IsImportant = true;
			this.BuscarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.BuscarAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "ScapProject0.Horarios.Horario";
			this.Title = global::Mono.Unix.Catalog.GetString("Horarios de empleados");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ScapProject0.Horarios.Horario.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar3'><toolitem name='AgregarAction' action='AgregarAction'/><separator/><toolitem name='EliminarAction' action='EliminarAction'/><separator/><toolitem name='ModificarAction' action='ModificarAction'/><separator/><toolitem name='BuscarAction' action='BuscarAction'/></toolbar></ui>");
			this.toolbar3 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar3")));
			this.toolbar3.Name = "toolbar3";
			this.toolbar3.ShowArrow = false;
			this.fixed2.Add(this.toolbar3);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.toolbar3]));
			w2.X = 16;
			w2.Y = 9;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.fixed2.Add(this.entry3);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry3]));
			w3.X = 448;
			w3.Y = 13;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.btnBackHor = new global::Gtk.Button();
			this.btnBackHor.CanFocus = true;
			this.btnBackHor.Name = "btnBackHor";
			this.btnBackHor.UseUnderline = true;
			this.btnBackHor.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed2.Add(this.btnBackHor);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.btnBackHor]));
			w4.X = 41;
			w4.Y = 247;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvwHorario = new global::Gtk.TreeView();
			this.trvwHorario.WidthRequest = 600;
			this.trvwHorario.HeightRequest = 150;
			this.trvwHorario.CanFocus = true;
			this.trvwHorario.Name = "trvwHorario";
			this.GtkScrolledWindow.Add(this.trvwHorario);
			this.fixed2.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.GtkScrolledWindow]));
			w6.X = 13;
			w6.Y = 68;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 660;
			this.DefaultHeight = 300;
			this.Show();
			this.AgregarAction.Activated += new global::System.EventHandler(this.OnAddActionActivated);
			this.ModificarAction.Activated += new global::System.EventHandler(this.OnModifyActionActivated);
			this.btnBackHor.Clicked += new global::System.EventHandler(this.OnBtnBackHorClicked);
		}
	}
}
