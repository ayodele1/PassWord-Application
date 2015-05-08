namespace UserInterfaceManager
{
	partial class GroupTreeControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTreeControl));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._groupAddToolStrip = new System.Windows.Forms.ToolStripButton();
			this._groupEditToolStrip = new System.Windows.Forms.ToolStripButton();
			this._groupDeleteToolStrip = new System.Windows.Forms.ToolStripButton();
			this._groupTreeView = new System.Windows.Forms.TreeView();
			this._groupTreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._addGroupContextMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._editGroupContextMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._deleteGroupContextMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1.SuspendLayout();
			this._groupTreeContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._groupAddToolStrip,
            this._groupEditToolStrip,
            this._groupDeleteToolStrip});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(32, 317);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// _groupAddToolStrip
			// 
			this._groupAddToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._groupAddToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._groupAddToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Folder;
			this._groupAddToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._groupAddToolStrip.Name = "_groupAddToolStrip";
			this._groupAddToolStrip.Size = new System.Drawing.Size(29, 20);
			this._groupAddToolStrip.Text = "toolStripButton1";
			this._groupAddToolStrip.Click += new System.EventHandler(this.onGroupAddClick);
			// 
			// _groupEditToolStrip
			// 
			this._groupEditToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._groupEditToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Folder_blue;
			this._groupEditToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._groupEditToolStrip.Name = "_groupEditToolStrip";
			this._groupEditToolStrip.Size = new System.Drawing.Size(29, 20);
			this._groupEditToolStrip.Text = "toolStripButton2";
			this._groupEditToolStrip.Click += new System.EventHandler(this.onGroupEditClick);
			// 
			// _groupDeleteToolStrip
			// 
			this._groupDeleteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._groupDeleteToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Delete;
			this._groupDeleteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._groupDeleteToolStrip.Name = "_groupDeleteToolStrip";
			this._groupDeleteToolStrip.Size = new System.Drawing.Size(29, 20);
			this._groupDeleteToolStrip.Text = "toolStripButton3";
			this._groupDeleteToolStrip.Click += new System.EventHandler(this.onGroupDeleteClick);
			// 
			// _groupTreeView
			// 
			this._groupTreeView.ContextMenuStrip = this._groupTreeContextMenu;
			this._groupTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._groupTreeView.HideSelection = false;
			this._groupTreeView.ImageIndex = 0;
			this._groupTreeView.ImageList = this.imageList;
			this._groupTreeView.Location = new System.Drawing.Point(32, 0);
			this._groupTreeView.Name = "_groupTreeView";
			this._groupTreeView.SelectedImageIndex = 0;
			this._groupTreeView.Size = new System.Drawing.Size(270, 317);
			this._groupTreeView.TabIndex = 1;
			this._groupTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.onGroupSelect);
			this._groupTreeView.DoubleClick += new System.EventHandler(this.onNodeDoubleClick);
			this._groupTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
			// 
			// _groupTreeContextMenu
			// 
			this._groupTreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addGroupContextMenu,
            this._editGroupContextMenu,
            this._deleteGroupContextMenu});
			this._groupTreeContextMenu.Name = "_groupTreeContextMenu";
			this._groupTreeContextMenu.Size = new System.Drawing.Size(141, 70);
			// 
			// _addGroupContextMenu
			// 
			this._addGroupContextMenu.Name = "_addGroupContextMenu";
			this._addGroupContextMenu.Size = new System.Drawing.Size(140, 22);
			this._addGroupContextMenu.Text = "Add Group";
			this._addGroupContextMenu.Click += new System.EventHandler(this.onGroupAddClick);
			// 
			// _editGroupContextMenu
			// 
			this._editGroupContextMenu.Name = "_editGroupContextMenu";
			this._editGroupContextMenu.Size = new System.Drawing.Size(140, 22);
			this._editGroupContextMenu.Text = "Edit Group";
			this._editGroupContextMenu.Click += new System.EventHandler(this.onGroupEditClick);
			// 
			// _deleteGroupContextMenu
			// 
			this._deleteGroupContextMenu.Name = "_deleteGroupContextMenu";
			this._deleteGroupContextMenu.Size = new System.Drawing.Size(140, 22);
			this._deleteGroupContextMenu.Text = "DeleteGroup";
			this._deleteGroupContextMenu.Click += new System.EventHandler(this.onGroupDeleteClick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Lock.ico");
			// 
			// GroupTreeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._groupTreeView);
			this.Controls.Add(this.toolStrip1);
			this.Name = "GroupTreeControl";
			this.Size = new System.Drawing.Size(302, 317);
			this.Load += new System.EventHandler(this.onLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this._groupTreeContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton _groupAddToolStrip;
		private System.Windows.Forms.ToolStripButton _groupEditToolStrip;
		private System.Windows.Forms.ToolStripButton _groupDeleteToolStrip;
		private System.Windows.Forms.TreeView _groupTreeView;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ContextMenuStrip _groupTreeContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _addGroupContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _editGroupContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _deleteGroupContextMenu;
	}
}
