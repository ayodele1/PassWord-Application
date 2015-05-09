namespace UserInterfaceManager
{
	partial class KeyListControl
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._keyAddToolStrip = new System.Windows.Forms.ToolStripButton();
            this._editKeyButton = new System.Windows.Forms.ToolStripButton();
            this._deleteKeyButton = new System.Windows.Forms.ToolStripButton();
            this._keylistView = new System.Windows.Forms.ListView();
            this._keyTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._keyUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._keyPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._keyUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._keyNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._keyListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._keyAddContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._keyEditContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._keyDeleteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._duplicateKeyContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this._keyListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._keyAddToolStrip,
            this._editKeyButton,
            this._deleteKeyButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _keyAddToolStrip
            // 
            this._keyAddToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._keyAddToolStrip.Image = global::UserInterfaceManager.Properties.Resources.Entry;
            this._keyAddToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._keyAddToolStrip.Name = "_keyAddToolStrip";
            this._keyAddToolStrip.Size = new System.Drawing.Size(23, 22);
            this._keyAddToolStrip.Text = "toolStripButton1";
            this._keyAddToolStrip.Click += new System.EventHandler(this.onKeyAddToolStripClick);
            // 
            // _editKeyButton
            // 
            this._editKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._editKeyButton.Image = global::UserInterfaceManager.Properties.Resources.Edit;
            this._editKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editKeyButton.Name = "_editKeyButton";
            this._editKeyButton.Size = new System.Drawing.Size(23, 22);
            this._editKeyButton.Text = "toolStripButton2";
            this._editKeyButton.Click += new System.EventHandler(this.onEditKeyButtonClick);
            // 
            // _deleteKeyButton
            // 
            this._deleteKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._deleteKeyButton.Image = global::UserInterfaceManager.Properties.Resources.Delete;
            this._deleteKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteKeyButton.Name = "_deleteKeyButton";
            this._deleteKeyButton.Size = new System.Drawing.Size(23, 22);
            this._deleteKeyButton.Text = "toolStripButton3";
            this._deleteKeyButton.Click += new System.EventHandler(this.onDeleteKey);
            // 
            // _keylistView
            // 
            this._keylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._keyTitle,
            this._keyUserName,
            this._keyPassword,
            this._keyUrl,
            this._keyNotes});
            this._keylistView.ContextMenuStrip = this._keyListContextMenu;
            this._keylistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keylistView.FullRowSelect = true;
            this._keylistView.GridLines = true;
            this._keylistView.HideSelection = false;
            this._keylistView.Location = new System.Drawing.Point(0, 25);
            this._keylistView.Name = "_keylistView";
            this._keylistView.Size = new System.Drawing.Size(480, 183);
            this._keylistView.TabIndex = 1;
            this._keylistView.UseCompatibleStateImageBehavior = false;
            this._keylistView.View = System.Windows.Forms.View.Details;
            this._keylistView.SelectedIndexChanged += new System.EventHandler(this.onKeySelect);
            this._keylistView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this._keylistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onDoubleClick);
            // 
            // _keyTitle
            // 
            this._keyTitle.Text = "Title";
            // 
            // _keyUserName
            // 
            this._keyUserName.Text = "UserName";
            // 
            // _keyPassword
            // 
            this._keyPassword.Text = "Password";
            // 
            // _keyUrl
            // 
            this._keyUrl.Text = "Url";
            this._keyUrl.Width = 128;
            // 
            // _keyNotes
            // 
            this._keyNotes.Text = "Notes";
            this._keyNotes.Width = 160;
            // 
            // _keyListContextMenu
            // 
            this._keyListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._keyAddContextMenu,
            this._keyEditContextMenu,
            this._keyDeleteContextMenu,
            this._duplicateKeyContextMenu});
            this._keyListContextMenu.Name = "_keyListContextMenu";
            this._keyListContextMenu.Size = new System.Drawing.Size(194, 114);
            // 
            // _keyAddContextMenu
            // 
            this._keyAddContextMenu.Name = "_keyAddContextMenu";
            this._keyAddContextMenu.Size = new System.Drawing.Size(193, 22);
            this._keyAddContextMenu.Text = "Add Key ";
            this._keyAddContextMenu.Click += new System.EventHandler(this.onKeyAddToolStripClick);
            // 
            // _keyEditContextMenu
            // 
            this._keyEditContextMenu.Name = "_keyEditContextMenu";
            this._keyEditContextMenu.Size = new System.Drawing.Size(193, 22);
            this._keyEditContextMenu.Text = "Edit Key";
            this._keyEditContextMenu.Click += new System.EventHandler(this.onEditKeyButtonClick);
            // 
            // _keyDeleteContextMenu
            // 
            this._keyDeleteContextMenu.Name = "_keyDeleteContextMenu";
            this._keyDeleteContextMenu.Size = new System.Drawing.Size(193, 22);
            this._keyDeleteContextMenu.Text = "Delete Key(s)";
            this._keyDeleteContextMenu.Click += new System.EventHandler(this.onDeleteKey);
            // 
            // _duplicateKeyContextMenu
            // 
            this._duplicateKeyContextMenu.Name = "_duplicateKeyContextMenu";
            this._duplicateKeyContextMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._duplicateKeyContextMenu.Size = new System.Drawing.Size(193, 22);
            this._duplicateKeyContextMenu.Text = "Duplicate Keys";
            this._duplicateKeyContextMenu.Click += new System.EventHandler(this.onDuplicateKey);
            // 
            // KeyListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._keylistView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "KeyListControl";
            this.Size = new System.Drawing.Size(480, 208);
            this.Load += new System.EventHandler(this.onLoad);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._keyListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton _keyAddToolStrip;
		private System.Windows.Forms.ToolStripButton _editKeyButton;
		private System.Windows.Forms.ToolStripButton _deleteKeyButton;
		private System.Windows.Forms.ListView _keylistView;
		private System.Windows.Forms.ColumnHeader _keyTitle;
		private System.Windows.Forms.ColumnHeader _keyUserName;
		private System.Windows.Forms.ColumnHeader _keyPassword;
		private System.Windows.Forms.ColumnHeader _keyUrl;
		private System.Windows.Forms.ColumnHeader _keyNotes;
		private System.Windows.Forms.ContextMenuStrip _keyListContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _keyAddContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _keyEditContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _keyDeleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _duplicateKeyContextMenu;
	}
}
