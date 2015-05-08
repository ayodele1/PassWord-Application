namespace UserInterfaceManager
{
	partial class AboutForm
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
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this._lblProductDescription = new System.Windows.Forms.TextBox();
			this._lblCompanyName = new System.Windows.Forms.Label();
			this._lblAuthor = new System.Windows.Forms.Label();
			this._lblProductName = new System.Windows.Forms.Label();
			this._lblProductVersion = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this._OKbutton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 503F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 272);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.66165F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.33834F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 266);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this._lblProductDescription, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this._lblCompanyName, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this._lblAuthor, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this._lblProductName, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this._lblProductVersion, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this._OKbutton, 0, 5);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(215, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71834F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71835F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71835F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71835F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.62218F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.50443F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 266);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// _lblProductDescription
			// 
			this._lblProductDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this._lblProductDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblProductDescription.Location = new System.Drawing.Point(3, 127);
			this._lblProductDescription.Multiline = true;
			this._lblProductDescription.Name = "_lblProductDescription";
			this._lblProductDescription.ReadOnly = true;
			this._lblProductDescription.Size = new System.Drawing.Size(491, 104);
			this._lblProductDescription.TabIndex = 4;
			// 
			// _lblCompanyName
			// 
			this._lblCompanyName.AutoSize = true;
			this._lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblCompanyName.Location = new System.Drawing.Point(3, 0);
			this._lblCompanyName.Name = "_lblCompanyName";
			this._lblCompanyName.Size = new System.Drawing.Size(491, 31);
			this._lblCompanyName.TabIndex = 0;
			// 
			// _lblAuthor
			// 
			this._lblAuthor.AutoSize = true;
			this._lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblAuthor.Location = new System.Drawing.Point(3, 31);
			this._lblAuthor.Name = "_lblAuthor";
			this._lblAuthor.Size = new System.Drawing.Size(491, 31);
			this._lblAuthor.TabIndex = 1;
			// 
			// _lblProductName
			// 
			this._lblProductName.AutoSize = true;
			this._lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblProductName.Location = new System.Drawing.Point(3, 62);
			this._lblProductName.Name = "_lblProductName";
			this._lblProductName.Size = new System.Drawing.Size(491, 31);
			this._lblProductName.TabIndex = 2;
			// 
			// _lblProductVersion
			// 
			this._lblProductVersion.AutoSize = true;
			this._lblProductVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblProductVersion.Location = new System.Drawing.Point(3, 93);
			this._lblProductVersion.Name = "_lblProductVersion";
			this._lblProductVersion.Size = new System.Drawing.Size(491, 31);
			this._lblProductVersion.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::UserInterfaceManager.Properties.Resources.Defragmentation;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 165);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// _OKbutton
			// 
			this._OKbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._OKbutton.Dock = System.Windows.Forms.DockStyle.Right;
			this._OKbutton.Location = new System.Drawing.Point(386, 237);
			this._OKbutton.Name = "_OKbutton";
			this._OKbutton.Size = new System.Drawing.Size(108, 26);
			this._OKbutton.TabIndex = 5;
			this._OKbutton.Text = "OK";
			this._OKbutton.UseVisualStyleBackColor = true;
			// 
			// AboutForm
			// 
			this.AcceptButton = this._OKbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._OKbutton;
			this.ClientSize = new System.Drawing.Size(715, 272);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutForm";
			this.Load += new System.EventHandler(this.onLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox _lblProductDescription;
		private System.Windows.Forms.Label _lblCompanyName;
		private System.Windows.Forms.Label _lblAuthor;
		private System.Windows.Forms.Label _lblProductName;
		private System.Windows.Forms.Label _lblProductVersion;
		private System.Windows.Forms.Button _OKbutton;
	}
}