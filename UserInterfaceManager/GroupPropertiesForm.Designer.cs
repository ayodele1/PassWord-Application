namespace UserInterfaceManager
{
	partial class GroupPropertiesForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this._gpTBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this._gpCancelButton = new System.Windows.Forms.Button();
			this._gpOKButton = new System.Windows.Forms.Button();
			this._gpTestButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.76471F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.23529F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 85);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.90017F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.09983F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this._gpTBox, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(427, 38);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "GroupName:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _gpTBox
			// 
			this._gpTBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._gpTBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._gpTBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this._gpTBox.Location = new System.Drawing.Point(79, 3);
			this._gpTBox.Name = "_gpTBox";
			this._gpTBox.Size = new System.Drawing.Size(345, 25);
			this._gpTBox.TabIndex = 0;
			this._gpTBox.WordWrap = false;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this._gpCancelButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this._gpOKButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this._gpTestButton, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 47);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(427, 35);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// _gpCancelButton
			// 
			this._gpCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._gpCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._gpCancelButton.Location = new System.Drawing.Point(306, 3);
			this._gpCancelButton.Name = "_gpCancelButton";
			this._gpCancelButton.Size = new System.Drawing.Size(118, 29);
			this._gpCancelButton.TabIndex = 4;
			this._gpCancelButton.Text = "Cancel";
			this._gpCancelButton.UseVisualStyleBackColor = true;
			this._gpCancelButton.Click += new System.EventHandler(this._onGpCancelButtonClick);
			// 
			// _gpOKButton
			// 
			this._gpOKButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._gpOKButton.Location = new System.Drawing.Point(163, 3);
			this._gpOKButton.Name = "_gpOKButton";
			this._gpOKButton.Size = new System.Drawing.Size(118, 29);
			this._gpOKButton.TabIndex = 3;
			this._gpOKButton.Text = "OK";
			this._gpOKButton.UseVisualStyleBackColor = true;
			this._gpOKButton.Click += new System.EventHandler(this.onGpOKButtonClick);
			// 
			// _gpTestButton
			// 
			this._gpTestButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._gpTestButton.Location = new System.Drawing.Point(21, 3);
			this._gpTestButton.Name = "_gpTestButton";
			this._gpTestButton.Size = new System.Drawing.Size(118, 29);
			this._gpTestButton.TabIndex = 2;
			this._gpTestButton.Text = "Test";
			this._gpTestButton.UseVisualStyleBackColor = true;
			this._gpTestButton.Click += new System.EventHandler(this.onGPTestClick);
			// 
			// GroupPropertiesForm
			// 
			this.AcceptButton = this._gpOKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._gpCancelButton;
			this.ClientSize = new System.Drawing.Size(433, 85);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "GroupPropertiesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add New Group";
			this.Load += new System.EventHandler(this.onLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _gpTBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button _gpCancelButton;
		private System.Windows.Forms.Button _gpOKButton;
		private System.Windows.Forms.Button _gpTestButton;
	}
}