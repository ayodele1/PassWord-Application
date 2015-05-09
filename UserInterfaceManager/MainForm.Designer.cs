namespace UserInterfaceManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._addGroupToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._editGroupToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteGroupToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._addKeyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._editKeyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteKeyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolBarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusBarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._newButton = new System.Windows.Forms.ToolStripButton();
            this._openFileButton = new System.Windows.Forms.ToolStripButton();
            this._saveButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._helpToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._groupTreeControl = new UserInterfaceManager.GroupTreeControl();
            this._keyListControl = new UserInterfaceManager.KeyListControl();
            this._mainStatusControl = new UserInterfaceManager.StatusControl();
            this.menuStrip1.SuspendLayout();
            this._mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this._viewMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newMenuItem,
            this._openMenuItem,
            this.toolStripSeparator,
            this._saveFileMenu,
            this._saveAsFileMenu,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _newMenuItem
            // 
            this._newMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_newMenuItem.Image")));
            this._newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newMenuItem.Name = "_newMenuItem";
            this._newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._newMenuItem.Size = new System.Drawing.Size(157, 22);
            this._newMenuItem.Text = "&New";
            this._newMenuItem.Click += new System.EventHandler(this.onNewDocumentClick);
            // 
            // _openMenuItem
            // 
            this._openMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_openMenuItem.Image")));
            this._openMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openMenuItem.Name = "_openMenuItem";
            this._openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._openMenuItem.Size = new System.Drawing.Size(157, 22);
            this._openMenuItem.Text = "&Open";
            this._openMenuItem.Click += new System.EventHandler(this.onOpenFile);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(154, 6);
            // 
            // _saveFileMenu
            // 
            this._saveFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("_saveFileMenu.Image")));
            this._saveFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveFileMenu.Name = "_saveFileMenu";
            this._saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._saveFileMenu.Size = new System.Drawing.Size(157, 22);
            this._saveFileMenu.Text = "&Save";
            this._saveFileMenu.Click += new System.EventHandler(this.onSaveFile);
            // 
            // _saveAsFileMenu
            // 
            this._saveAsFileMenu.Name = "_saveAsFileMenu";
            this._saveAsFileMenu.Size = new System.Drawing.Size(157, 22);
            this._saveAsFileMenu.Text = "Save &As";
            this._saveAsFileMenu.Click += new System.EventHandler(this.onSaveAsFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addGroupToolStrip,
            this._editGroupToolStrip,
            this._deleteGroupToolStrip,
            this.toolStripSeparator3,
            this._addKeyToolStrip,
            this._editKeyToolStrip,
            this._deleteKeyToolStrip});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // _addGroupToolStrip
            // 
            this._addGroupToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Folder;
            this._addGroupToolStrip.Name = "_addGroupToolStrip";
            this._addGroupToolStrip.Size = new System.Drawing.Size(177, 22);
            this._addGroupToolStrip.Text = "Add Group";
            this._addGroupToolStrip.Click += new System.EventHandler(this.onGroupAddClick);
            // 
            // _editGroupToolStrip
            // 
            this._editGroupToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Folder_blue;
            this._editGroupToolStrip.Name = "_editGroupToolStrip";
            this._editGroupToolStrip.Size = new System.Drawing.Size(177, 22);
            this._editGroupToolStrip.Text = "Edit Group";
            this._editGroupToolStrip.Click += new System.EventHandler(this.onGroupEditClick);
            // 
            // _deleteGroupToolStrip
            // 
            this._deleteGroupToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Delete;
            this._deleteGroupToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteGroupToolStrip.Name = "_deleteGroupToolStrip";
            this._deleteGroupToolStrip.Size = new System.Drawing.Size(177, 22);
            this._deleteGroupToolStrip.Text = "Delete Group";
            this._deleteGroupToolStrip.Click += new System.EventHandler(this.onGroupDeleteClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // _addKeyToolStrip
            // 
            this._addKeyToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Entry;
            this._addKeyToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addKeyToolStrip.Name = "_addKeyToolStrip";
            this._addKeyToolStrip.Size = new System.Drawing.Size(177, 22);
            this._addKeyToolStrip.Text = "Add Key Entry";
            this._addKeyToolStrip.Click += new System.EventHandler(this.onAddKeyClick);
            // 
            // _editKeyToolStrip
            // 
            this._editKeyToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Edit;
            this._editKeyToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editKeyToolStrip.Name = "_editKeyToolStrip";
            this._editKeyToolStrip.Size = new System.Drawing.Size(177, 22);
            this._editKeyToolStrip.Text = "Edit Key Entry";
            this._editKeyToolStrip.Click += new System.EventHandler(this.onEditKeyClick);
            // 
            // _deleteKeyToolStrip
            // 
            this._deleteKeyToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Delete;
            this._deleteKeyToolStrip.Name = "_deleteKeyToolStrip";
            this._deleteKeyToolStrip.Size = new System.Drawing.Size(177, 22);
            this._deleteKeyToolStrip.Text = "Delete Key Entry";
            this._deleteKeyToolStrip.Click += new System.EventHandler(this.onDeleteKeyClick);
            // 
            // _viewMenuItem
            // 
            this._viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolBarMenuItem,
            this._statusBarMenuItem});
            this._viewMenuItem.Name = "_viewMenuItem";
            this._viewMenuItem.Size = new System.Drawing.Size(48, 21);
            this._viewMenuItem.Text = "View";
            this._viewMenuItem.DropDownOpening += new System.EventHandler(this.onViewMenuOpening);
            // 
            // _toolBarMenuItem
            // 
            this._toolBarMenuItem.Name = "_toolBarMenuItem";
            this._toolBarMenuItem.Size = new System.Drawing.Size(134, 22);
            this._toolBarMenuItem.Text = "ToolBar";
            this._toolBarMenuItem.Click += new System.EventHandler(this.onToolBarClick);
            // 
            // _statusBarMenuItem
            // 
            this._statusBarMenuItem.Name = "_statusBarMenuItem";
            this._statusBarMenuItem.Size = new System.Drawing.Size(134, 22);
            this._statusBarMenuItem.Text = "StatusBar";
            this._statusBarMenuItem.Click += new System.EventHandler(this.onStatusBarClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this._aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(128, 6);
            // 
            // _aboutMenu
            // 
            this._aboutMenu.Name = "_aboutMenu";
            this._aboutMenu.Size = new System.Drawing.Size(131, 22);
            this._aboutMenu.Text = "&About...";
            this._aboutMenu.Click += new System.EventHandler(this.onAboutMenuClick);
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newButton,
            this._openFileButton,
            this._saveButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this._helpToolStrip});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 25);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(1027, 25);
            this._mainToolStrip.TabIndex = 1;
            this._mainToolStrip.Text = "toolStrip1";
            // 
            // _newButton
            // 
            this._newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._newButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._newButton.Image = ((System.Drawing.Image)(resources.GetObject("_newButton.Image")));
            this._newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(23, 22);
            this._newButton.Text = "&New";
            this._newButton.Click += new System.EventHandler(this.onNewDocumentClick);
            // 
            // _openFileButton
            // 
            this._openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("_openFileButton.Image")));
            this._openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openFileButton.Name = "_openFileButton";
            this._openFileButton.Size = new System.Drawing.Size(23, 22);
            this._openFileButton.Text = "&Open";
            this._openFileButton.Click += new System.EventHandler(this.onOpenFile);
            // 
            // _saveButton
            // 
            this._saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._saveButton.Image = ((System.Drawing.Image)(resources.GetObject("_saveButton.Image")));
            this._saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(23, 22);
            this._saveButton.Text = "&Save";
            this._saveButton.Click += new System.EventHandler(this.onSaveButtonClick);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // _helpToolStrip
            // 
            this._helpToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._helpToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_helpToolStrip.Image")));
            this._helpToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._helpToolStrip.Name = "_helpToolStrip";
            this._helpToolStrip.Size = new System.Drawing.Size(23, 22);
            this._helpToolStrip.Text = "He&lp";
            this._helpToolStrip.Click += new System.EventHandler(this.onHelpToolStripClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._groupTreeControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 410);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._keyListControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._richTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(681, 410);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.TabIndex = 0;
            // 
            // _richTextBox
            // 
            this._richTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._richTextBox.Location = new System.Drawing.Point(0, 0);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(677, 150);
            this._richTextBox.TabIndex = 0;
            this._richTextBox.Text = "";
            this._richTextBox.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // _groupTreeControl
            // 
            this._groupTreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupTreeControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupTreeControl.Location = new System.Drawing.Point(0, 0);
            this._groupTreeControl.Margin = new System.Windows.Forms.Padding(4);
            this._groupTreeControl.Name = "_groupTreeControl";
            this._groupTreeControl.Size = new System.Drawing.Size(338, 406);
            this._groupTreeControl.TabIndex = 0;
            // 
            // _keyListControl
            // 
            this._keyListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keyListControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._keyListControl.Location = new System.Drawing.Point(0, 0);
            this._keyListControl.Margin = new System.Windows.Forms.Padding(4);
            this._keyListControl.Name = "_keyListControl";
            this._keyListControl.Size = new System.Drawing.Size(677, 248);
            this._keyListControl.TabIndex = 0;
            // 
            // _mainStatusControl
            // 
            this._mainStatusControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._mainStatusControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._mainStatusControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainStatusControl.Location = new System.Drawing.Point(0, 460);
            this._mainStatusControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._mainStatusControl.Name = "_mainStatusControl";
            this._mainStatusControl.Size = new System.Drawing.Size(1027, 42);
            this._mainStatusControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 502);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._mainStatusControl);
            this.Controls.Add(this._mainToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.onLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _newMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _openMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem _saveFileMenu;
		private System.Windows.Forms.ToolStripMenuItem _saveAsFileMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _addGroupToolStrip;
		private System.Windows.Forms.ToolStripMenuItem _editGroupToolStrip;
		private System.Windows.Forms.ToolStripMenuItem _deleteGroupToolStrip;
		private System.Windows.Forms.ToolStripMenuItem _addKeyToolStrip;
		private System.Windows.Forms.ToolStripMenuItem _editKeyToolStrip;
		private System.Windows.Forms.ToolStripMenuItem _deleteKeyToolStrip;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem _aboutMenu;
		private System.Windows.Forms.ToolStrip _mainToolStrip;
		private System.Windows.Forms.ToolStripButton _newButton;
		private System.Windows.Forms.ToolStripButton _openFileButton;
		private System.Windows.Forms.ToolStripButton _saveButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton _helpToolStrip;
		private StatusControl _mainStatusControl;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ToolStripMenuItem _viewMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _toolBarMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _statusBarMenuItem;
		private GroupTreeControl _groupTreeControl;
		private KeyListControl _keyListControl;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RichTextBox _richTextBox;
	}
}