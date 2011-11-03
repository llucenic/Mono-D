
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D.OptionPanels
{
	public partial class DGlobalOptions
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView tvCategories;
		private global::Gtk.Notebook OptionsNotebook;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.VBox vbox6;
		private global::Gtk.VBox vbox8;
		private global::Gtk.Table table6;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Button btnDebugArguments;
		private global::Gtk.Button btnReleaseArguments;
		private global::Gtk.Label label28;
		private global::Gtk.Label label29;
		private global::Gtk.Label label30;
		private global::Gtk.Label label31;
		private global::Gtk.Label label32;
		private global::Gtk.Entry txtCompiler;
		private global::Gtk.Entry txtConsoleAppLinker;
		private global::Gtk.Entry txtGUIAppLinker;
		private global::Gtk.Entry txtSharedLibLinker;
		private global::Gtk.Entry txtStaticLibLinker;
		private global::Gtk.Notebook notebook2;
		private global::Gtk.Table table4;
		private global::Gtk.Button btnAddLibraryPath;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Entry txtLibraryPath;
		private global::Gtk.Button btnBrowseLibraryPath;
		private global::Gtk.Label label15;
		private global::Gtk.ScrolledWindow scrolledwindow11;
		private global::Gtk.TreeView tvLibraryPaths;
		private global::Gtk.VBox vbox9;
		private global::Gtk.Button btnRemoveLibraryPath;
		private global::Gtk.Label label10;
		private global::Gtk.Table table5;
		private global::Gtk.Button btnAddDefaultLib;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Entry txtDefaultLib;
		private global::Gtk.Button btnBrowseDefaultLib;
		private global::Gtk.Label label16;
		private global::Gtk.ScrolledWindow scrolledwindow12;
		private global::Gtk.TreeView tvDefaultLibs;
		private global::Gtk.VBox vbox10;
		private global::Gtk.Button btnRemoveDefaultLib;
		private global::Gtk.Label label12;
		private global::Gtk.Label label1;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Table table2;
		private global::Gtk.Button addLibButton;
		private global::Gtk.Label label13;
		private global::Gtk.Entry libAddEntry;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView libTreeView;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Button browseButton;
		private global::Gtk.Button removeLibButton;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Table table3;
		private global::Gtk.Button includePathAddButton;
		private global::Gtk.Entry includePathEntry;
		private global::Gtk.Label label14;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.TreeView includePathTreeView;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Button includePathBrowseButton;
		private global::Gtk.Button includePathRemoveButton;
		private global::Gtk.Label label3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.OptionPanels.DGlobalOptions
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.D.OptionPanels.DGlobalOptions";
			// Container child MonoDevelop.D.OptionPanels.DGlobalOptions.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tvCategories = new global::Gtk.TreeView ();
			this.tvCategories.WidthRequest = 79;
			this.tvCategories.CanFocus = true;
			this.tvCategories.Name = "tvCategories";
			this.tvCategories.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.tvCategories);
			this.hbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.OptionsNotebook = new global::Gtk.Notebook ();
			this.OptionsNotebook.CanFocus = true;
			this.OptionsNotebook.Name = "OptionsNotebook";
			this.OptionsNotebook.CurrentPage = 2;
			// Notebook tab
			global::Gtk.Label w3 = new global::Gtk.Label ();
			w3.Visible = true;
			this.OptionsNotebook.Add (w3);
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("general");
			this.OptionsNotebook.SetTabLabel (w3, this.label8);
			this.label8.ShowAll ();
			// Notebook tab
			global::Gtk.Label w4 = new global::Gtk.Label ();
			w4.Visible = true;
			this.OptionsNotebook.Add (w4);
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("compilers");
			this.OptionsNotebook.SetTabLabel (w4, this.label9);
			this.label9.ShowAll ();
			// Container child OptionsNotebook.Gtk.Notebook+NotebookChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 3;
			// Container child vbox6.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table6 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table6.Name = "table6";
			this.table6.RowSpacing = ((uint)(6));
			this.table6.ColumnSpacing = ((uint)(6));
			// Container child table6.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnDebugArguments = new global::Gtk.Button ();
			this.btnDebugArguments.CanFocus = true;
			this.btnDebugArguments.Name = "btnDebugArguments";
			this.btnDebugArguments.UseUnderline = true;
			this.btnDebugArguments.Label = global::Mono.Unix.Catalog.GetString ("Debug Arguments");
			this.hbox8.Add (this.btnDebugArguments);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnDebugArguments]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnReleaseArguments = new global::Gtk.Button ();
			this.btnReleaseArguments.CanFocus = true;
			this.btnReleaseArguments.Name = "btnReleaseArguments";
			this.btnReleaseArguments.UseUnderline = true;
			this.btnReleaseArguments.Label = global::Mono.Unix.Catalog.GetString ("Release Arguments");
			this.hbox8.Add (this.btnReleaseArguments);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnReleaseArguments]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.table6.Add (this.hbox8);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox8]));
			w7.TopAttach = ((uint)(5));
			w7.BottomAttach = ((uint)(6));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.Xalign = 0.2F;
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("Static Lib Linker");
			this.table6.Add (this.label28);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table6 [this.label28]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label29 = new global::Gtk.Label ();
			this.label29.Name = "label29";
			this.label29.Xalign = 0.2F;
			this.label29.LabelProp = global::Mono.Unix.Catalog.GetString ("Shared Lib Linker");
			this.table6.Add (this.label29);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table6 [this.label29]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label30 = new global::Gtk.Label ();
			this.label30.Name = "label30";
			this.label30.Xalign = 0.2F;
			this.label30.LabelProp = global::Mono.Unix.Catalog.GetString ("Console app Linker");
			this.table6.Add (this.label30);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table6 [this.label30]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label31 = new global::Gtk.Label ();
			this.label31.Name = "label31";
			this.label31.Xalign = 0.2F;
			this.label31.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler");
			this.table6.Add (this.label31);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table6 [this.label31]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.Xalign = 0.2F;
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString ("GUI app Linker");
			this.table6.Add (this.label32);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table6 [this.label32]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtCompiler = new global::Gtk.Entry ();
			this.txtCompiler.CanFocus = true;
			this.txtCompiler.Name = "txtCompiler";
			this.txtCompiler.IsEditable = true;
			this.txtCompiler.InvisibleChar = '•';
			this.table6.Add (this.txtCompiler);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtCompiler]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtConsoleAppLinker = new global::Gtk.Entry ();
			this.txtConsoleAppLinker.CanFocus = true;
			this.txtConsoleAppLinker.Name = "txtConsoleAppLinker";
			this.txtConsoleAppLinker.IsEditable = true;
			this.txtConsoleAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtConsoleAppLinker);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtConsoleAppLinker]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtGUIAppLinker = new global::Gtk.Entry ();
			this.txtGUIAppLinker.CanFocus = true;
			this.txtGUIAppLinker.Name = "txtGUIAppLinker";
			this.txtGUIAppLinker.IsEditable = true;
			this.txtGUIAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtGUIAppLinker);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtGUIAppLinker]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtSharedLibLinker = new global::Gtk.Entry ();
			this.txtSharedLibLinker.CanFocus = true;
			this.txtSharedLibLinker.Name = "txtSharedLibLinker";
			this.txtSharedLibLinker.IsEditable = true;
			this.txtSharedLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtSharedLibLinker);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtSharedLibLinker]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtStaticLibLinker = new global::Gtk.Entry ();
			this.txtStaticLibLinker.CanFocus = true;
			this.txtStaticLibLinker.Name = "txtStaticLibLinker";
			this.txtStaticLibLinker.IsEditable = true;
			this.txtStaticLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtStaticLibLinker);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtStaticLibLinker]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox8.Add (this.table6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.table6]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.notebook2 = new global::Gtk.Notebook ();
			this.notebook2.CanFocus = true;
			this.notebook2.Name = "notebook2";
			this.notebook2.CurrentPage = 0;
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.table4 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(10));
			this.table4.ColumnSpacing = ((uint)(10));
			// Container child table4.Gtk.Table+TableChild
			this.btnAddLibraryPath = new global::Gtk.Button ();
			this.btnAddLibraryPath.Sensitive = false;
			this.btnAddLibraryPath.CanFocus = true;
			this.btnAddLibraryPath.Name = "btnAddLibraryPath";
			this.btnAddLibraryPath.UseUnderline = true;
			this.btnAddLibraryPath.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table4.Add (this.btnAddLibraryPath);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table4 [this.btnAddLibraryPath]));
			w19.LeftAttach = ((uint)(2));
			w19.RightAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.txtLibraryPath = new global::Gtk.Entry ();
			this.txtLibraryPath.CanFocus = true;
			this.txtLibraryPath.Name = "txtLibraryPath";
			this.txtLibraryPath.IsEditable = true;
			this.txtLibraryPath.InvisibleChar = '?';
			this.hbox5.Add (this.txtLibraryPath);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtLibraryPath]));
			w20.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.btnBrowseLibraryPath = new global::Gtk.Button ();
			this.btnBrowseLibraryPath.CanFocus = true;
			this.btnBrowseLibraryPath.Name = "btnBrowseLibraryPath";
			this.btnBrowseLibraryPath.UseUnderline = true;
			this.btnBrowseLibraryPath.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.hbox5.Add (this.btnBrowseLibraryPath);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.btnBrowseLibraryPath]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.table4.Add (this.hbox5);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4 [this.hbox5]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Path:");
			this.table4.Add (this.label15);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4 [this.label15]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.scrolledwindow11 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow11.CanFocus = true;
			this.scrolledwindow11.Name = "scrolledwindow11";
			this.scrolledwindow11.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow11.Gtk.Container+ContainerChild
			this.tvLibraryPaths = new global::Gtk.TreeView ();
			this.tvLibraryPaths.CanFocus = true;
			this.tvLibraryPaths.Name = "tvLibraryPaths";
			this.scrolledwindow11.Add (this.tvLibraryPaths);
			this.table4.Add (this.scrolledwindow11);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4 [this.scrolledwindow11]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			// Container child table4.Gtk.Table+TableChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.btnRemoveLibraryPath = new global::Gtk.Button ();
			this.btnRemoveLibraryPath.Sensitive = false;
			this.btnRemoveLibraryPath.CanFocus = true;
			this.btnRemoveLibraryPath.Name = "btnRemoveLibraryPath";
			this.btnRemoveLibraryPath.UseUnderline = true;
			this.btnRemoveLibraryPath.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox9.Add (this.btnRemoveLibraryPath);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.btnRemoveLibraryPath]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			this.table4.Add (this.vbox9);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table4 [this.vbox9]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook2.Add (this.table4);
			// Notebook tab
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Library Paths");
			this.notebook2.SetTabLabel (this.table4, this.label10);
			this.label10.ShowAll ();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.table5 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(10));
			this.table5.ColumnSpacing = ((uint)(10));
			this.table5.BorderWidth = ((uint)(3));
			// Container child table5.Gtk.Table+TableChild
			this.btnAddDefaultLib = new global::Gtk.Button ();
			this.btnAddDefaultLib.Sensitive = false;
			this.btnAddDefaultLib.CanFocus = true;
			this.btnAddDefaultLib.Name = "btnAddDefaultLib";
			this.btnAddDefaultLib.UseUnderline = true;
			this.btnAddDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table5.Add (this.btnAddDefaultLib);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table5 [this.btnAddDefaultLib]));
			w29.LeftAttach = ((uint)(2));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.txtDefaultLib = new global::Gtk.Entry ();
			this.txtDefaultLib.CanFocus = true;
			this.txtDefaultLib.Name = "txtDefaultLib";
			this.txtDefaultLib.IsEditable = true;
			this.txtDefaultLib.InvisibleChar = '?';
			this.hbox6.Add (this.txtDefaultLib);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtDefaultLib]));
			w30.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnBrowseDefaultLib = new global::Gtk.Button ();
			this.btnBrowseDefaultLib.CanFocus = true;
			this.btnBrowseDefaultLib.Name = "btnBrowseDefaultLib";
			this.btnBrowseDefaultLib.UseUnderline = true;
			this.btnBrowseDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.hbox6.Add (this.btnBrowseDefaultLib);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.btnBrowseDefaultLib]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.table5.Add (this.hbox6);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table5 [this.hbox6]));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Library:");
			this.table5.Add (this.label16);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table5 [this.label16]));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.scrolledwindow12 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow12.CanFocus = true;
			this.scrolledwindow12.Name = "scrolledwindow12";
			this.scrolledwindow12.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow12.Gtk.Container+ContainerChild
			this.tvDefaultLibs = new global::Gtk.TreeView ();
			this.tvDefaultLibs.CanFocus = true;
			this.tvDefaultLibs.Name = "tvDefaultLibs";
			this.scrolledwindow12.Add (this.tvDefaultLibs);
			this.table5.Add (this.scrolledwindow12);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table5 [this.scrolledwindow12]));
			w35.TopAttach = ((uint)(1));
			w35.BottomAttach = ((uint)(2));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			// Container child table5.Gtk.Table+TableChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.btnRemoveDefaultLib = new global::Gtk.Button ();
			this.btnRemoveDefaultLib.Sensitive = false;
			this.btnRemoveDefaultLib.CanFocus = true;
			this.btnRemoveDefaultLib.Name = "btnRemoveDefaultLib";
			this.btnRemoveDefaultLib.UseUnderline = true;
			this.btnRemoveDefaultLib.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox10.Add (this.btnRemoveDefaultLib);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.btnRemoveDefaultLib]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			this.table5.Add (this.vbox10);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table5 [this.vbox10]));
			w37.TopAttach = ((uint)(1));
			w37.BottomAttach = ((uint)(2));
			w37.LeftAttach = ((uint)(2));
			w37.RightAttach = ((uint)(3));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook2.Add (this.table5);
			global::Gtk.Notebook.NotebookChild w38 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2 [this.table5]));
			w38.Position = 1;
			// Notebook tab
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Default Libraries");
			this.notebook2.SetTabLabel (this.table5, this.label12);
			this.label12.ShowAll ();
			this.vbox8.Add (this.notebook2);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.notebook2]));
			w39.Position = 1;
			this.vbox6.Add (this.vbox8);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox8]));
			w40.Position = 0;
			this.OptionsNotebook.Add (this.vbox6);
			global::Gtk.Notebook.NotebookChild w41 = ((global::Gtk.Notebook.NotebookChild)(this.OptionsNotebook [this.vbox6]));
			w41.Position = 2;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("dmd");
			this.OptionsNotebook.SetTabLabel (this.vbox6, this.label1);
			this.label1.ShowAll ();
			// Notebook tab
			global::Gtk.Label w42 = new global::Gtk.Label ();
			w42.Visible = true;
			this.OptionsNotebook.Add (w42);
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("gdc");
			this.OptionsNotebook.SetTabLabel (w42, this.label5);
			this.label5.ShowAll ();
			// Notebook tab
			global::Gtk.Label w43 = new global::Gtk.Label ();
			w43.Visible = true;
			this.OptionsNotebook.Add (w43);
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("ldc");
			this.OptionsNotebook.SetTabLabel (w43, this.label6);
			this.label6.ShowAll ();
			// Container child OptionsNotebook.Gtk.Notebook+NotebookChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(10));
			this.table2.ColumnSpacing = ((uint)(10));
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.addLibButton = new global::Gtk.Button ();
			this.addLibButton.Sensitive = false;
			this.addLibButton.CanFocus = true;
			this.addLibButton.Name = "addLibButton";
			this.addLibButton.UseUnderline = true;
			this.addLibButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table2.Add (this.addLibButton);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table2 [this.addLibButton]));
			w44.LeftAttach = ((uint)(2));
			w44.RightAttach = ((uint)(3));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Library:");
			this.table2.Add (this.label13);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table2 [this.label13]));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.libAddEntry = new global::Gtk.Entry ();
			this.libAddEntry.CanFocus = true;
			this.libAddEntry.Name = "libAddEntry";
			this.libAddEntry.IsEditable = true;
			this.libAddEntry.InvisibleChar = '?';
			this.table2.Add (this.libAddEntry);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table2 [this.libAddEntry]));
			w46.LeftAttach = ((uint)(1));
			w46.RightAttach = ((uint)(2));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.libTreeView = new global::Gtk.TreeView ();
			this.libTreeView.CanFocus = true;
			this.libTreeView.Name = "libTreeView";
			this.scrolledwindow1.Add (this.libTreeView);
			this.table2.Add (this.scrolledwindow1);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table2 [this.scrolledwindow1]));
			w48.TopAttach = ((uint)(1));
			w48.BottomAttach = ((uint)(2));
			w48.LeftAttach = ((uint)(1));
			w48.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.browseButton = new global::Gtk.Button ();
			this.browseButton.CanFocus = true;
			this.browseButton.Name = "browseButton";
			this.browseButton.UseUnderline = true;
			this.browseButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.vbox4.Add (this.browseButton);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.browseButton]));
			w49.Position = 0;
			w49.Expand = false;
			w49.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.removeLibButton = new global::Gtk.Button ();
			this.removeLibButton.Sensitive = false;
			this.removeLibButton.CanFocus = true;
			this.removeLibButton.Name = "removeLibButton";
			this.removeLibButton.UseUnderline = true;
			this.removeLibButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox4.Add (this.removeLibButton);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.removeLibButton]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			this.table2.Add (this.vbox4);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox4]));
			w51.TopAttach = ((uint)(1));
			w51.BottomAttach = ((uint)(2));
			w51.LeftAttach = ((uint)(2));
			w51.RightAttach = ((uint)(3));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			this.OptionsNotebook.Add (this.table2);
			global::Gtk.Notebook.NotebookChild w52 = ((global::Gtk.Notebook.NotebookChild)(this.OptionsNotebook [this.table2]));
			w52.Position = 5;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Libraries");
			this.OptionsNotebook.SetTabLabel (this.table2, this.label2);
			this.label2.ShowAll ();
			// Container child OptionsNotebook.Gtk.Notebook+NotebookChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			this.vbox7.BorderWidth = ((uint)(3));
			// Container child vbox7.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(10));
			this.table3.ColumnSpacing = ((uint)(10));
			// Container child table3.Gtk.Table+TableChild
			this.includePathAddButton = new global::Gtk.Button ();
			this.includePathAddButton.Sensitive = false;
			this.includePathAddButton.CanFocus = true;
			this.includePathAddButton.Name = "includePathAddButton";
			this.includePathAddButton.UseUnderline = true;
			this.includePathAddButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table3.Add (this.includePathAddButton);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table3 [this.includePathAddButton]));
			w53.LeftAttach = ((uint)(2));
			w53.RightAttach = ((uint)(3));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.includePathEntry = new global::Gtk.Entry ();
			this.includePathEntry.CanFocus = true;
			this.includePathEntry.Name = "includePathEntry";
			this.includePathEntry.IsEditable = true;
			this.includePathEntry.InvisibleChar = '?';
			this.table3.Add (this.includePathEntry);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table3 [this.includePathEntry]));
			w54.LeftAttach = ((uint)(1));
			w54.RightAttach = ((uint)(2));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Include Paths:");
			this.table3.Add (this.label14);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table3 [this.label14]));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.includePathTreeView = new global::Gtk.TreeView ();
			this.includePathTreeView.CanFocus = true;
			this.includePathTreeView.Name = "includePathTreeView";
			this.scrolledwindow2.Add (this.includePathTreeView);
			this.table3.Add (this.scrolledwindow2);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table3 [this.scrolledwindow2]));
			w57.TopAttach = ((uint)(1));
			w57.BottomAttach = ((uint)(2));
			w57.LeftAttach = ((uint)(1));
			w57.RightAttach = ((uint)(2));
			// Container child table3.Gtk.Table+TableChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.includePathBrowseButton = new global::Gtk.Button ();
			this.includePathBrowseButton.CanFocus = true;
			this.includePathBrowseButton.Name = "includePathBrowseButton";
			this.includePathBrowseButton.UseUnderline = true;
			this.includePathBrowseButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.vbox5.Add (this.includePathBrowseButton);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.includePathBrowseButton]));
			w58.Position = 0;
			w58.Expand = false;
			w58.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.includePathRemoveButton = new global::Gtk.Button ();
			this.includePathRemoveButton.Sensitive = false;
			this.includePathRemoveButton.CanFocus = true;
			this.includePathRemoveButton.Name = "includePathRemoveButton";
			this.includePathRemoveButton.UseUnderline = true;
			this.includePathRemoveButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox5.Add (this.includePathRemoveButton);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.includePathRemoveButton]));
			w59.Position = 1;
			w59.Expand = false;
			w59.Fill = false;
			this.table3.Add (this.vbox5);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table3 [this.vbox5]));
			w60.TopAttach = ((uint)(1));
			w60.BottomAttach = ((uint)(2));
			w60.LeftAttach = ((uint)(2));
			w60.RightAttach = ((uint)(3));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox7.Add (this.table3);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.table3]));
			w61.Position = 0;
			this.OptionsNotebook.Add (this.vbox7);
			global::Gtk.Notebook.NotebookChild w62 = ((global::Gtk.Notebook.NotebookChild)(this.OptionsNotebook [this.vbox7]));
			w62.Position = 6;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Include");
			this.OptionsNotebook.SetTabLabel (this.vbox7, this.label3);
			this.label3.ShowAll ();
			this.hbox1.Add (this.OptionsNotebook);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.OptionsNotebook]));
			w63.Position = 1;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
