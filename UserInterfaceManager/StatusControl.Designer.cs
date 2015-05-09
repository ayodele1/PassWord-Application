namespace UserInterfaceManager
{
	partial class StatusControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clockControl1 = new UserInterfaceManager.ClockControl();
            this._comboBoxLogger = new System.Windows.Forms.ComboBox();
            this._totalGroupsLabel = new System.Windows.Forms.Label();
            this._keysLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.59763F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.27466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46635F));
            this.tableLayoutPanel1.Controls.Add(this.clockControl1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._comboBoxLogger, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._totalGroupsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._keysLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clockControl1
            // 
            this.clockControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockControl1.Location = new System.Drawing.Point(867, 9);
            this.clockControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.Size = new System.Drawing.Size(157, 22);
            this.clockControl1.TabIndex = 0;
            // 
            // _comboBoxLogger
            // 
            this._comboBoxLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBoxLogger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLogger.FormattingEnabled = true;
            this._comboBoxLogger.Location = new System.Drawing.Point(5, 6);
            this._comboBoxLogger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._comboBoxLogger.Name = "_comboBoxLogger";
            this._comboBoxLogger.Size = new System.Drawing.Size(470, 29);
            this._comboBoxLogger.TabIndex = 1;
            // 
            // _totalGroupsLabel
            // 
            this._totalGroupsLabel.AutoSize = true;
            this._totalGroupsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._totalGroupsLabel.Location = new System.Drawing.Point(483, 1);
            this._totalGroupsLabel.Name = "_totalGroupsLabel";
            this._totalGroupsLabel.Size = new System.Drawing.Size(123, 38);
            this._totalGroupsLabel.TabIndex = 2;
            this._totalGroupsLabel.Text = "Total Groups";
            this._totalGroupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _keysLabel
            // 
            this._keysLabel.AutoSize = true;
            this._keysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keysLabel.Location = new System.Drawing.Point(613, 1);
            this._keysLabel.Name = "_keysLabel";
            this._keysLabel.Size = new System.Drawing.Size(243, 38);
            this._keysLabel.TabIndex = 3;
            this._keysLabel.Text = "X of Y selected Keys";
            this._keysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatusControl";
            this.Size = new System.Drawing.Size(1032, 40);
            this.Load += new System.EventHandler(this.onLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private ClockControl clockControl1;
		private System.Windows.Forms.ComboBox _comboBoxLogger;
		private System.Windows.Forms.Label _totalGroupsLabel;
		private System.Windows.Forms.Label _keysLabel;
	}
}
