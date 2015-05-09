namespace UserInterfaceManager
{
    partial class PasswordLoginForm
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
            this._passWordCancel = new System.Windows.Forms.Button();
            this._passWordOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._passWordLabel = new System.Windows.Forms.Label();
            this._passWordTextBox = new System.Windows.Forms.TextBox();
            this._showPassWordCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._showPassWordCheckBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.25926F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.67039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.99441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this._passWordCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this._passWordOk, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _passWordCancel
            // 
            this._passWordCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._passWordCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this._passWordCancel.Location = new System.Drawing.Point(261, 3);
            this._passWordCancel.Name = "_passWordCancel";
            this._passWordCancel.Size = new System.Drawing.Size(95, 35);
            this._passWordCancel.TabIndex = 2;
            this._passWordCancel.Text = "Cancel";
            this._passWordCancel.UseVisualStyleBackColor = true;
            this._passWordCancel.Click += new System.EventHandler(this.onCancel);
            // 
            // _passWordOk
            // 
            this._passWordOk.Dock = System.Windows.Forms.DockStyle.Left;
            this._passWordOk.Location = new System.Drawing.Point(132, 3);
            this._passWordOk.Name = "_passWordOk";
            this._passWordOk.Size = new System.Drawing.Size(93, 35);
            this._passWordOk.TabIndex = 1;
            this._passWordOk.Text = "OK";
            this._passWordOk.UseVisualStyleBackColor = true;
            this._passWordOk.Click += new System.EventHandler(this.onOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Image = global::UserInterfaceManager.Properties.Resources.Logon;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 61);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35573F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.64427F));
            this.tableLayoutPanel3.Controls.Add(this._passWordLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._passWordTextBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 31);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _passWordLabel
            // 
            this._passWordLabel.AutoSize = true;
            this._passWordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passWordLabel.Location = new System.Drawing.Point(3, 0);
            this._passWordLabel.Name = "_passWordLabel";
            this._passWordLabel.Size = new System.Drawing.Size(73, 31);
            this._passWordLabel.TabIndex = 0;
            this._passWordLabel.Text = "PassWord";
            this._passWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _passWordTextBox
            // 
            this._passWordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passWordTextBox.Location = new System.Drawing.Point(82, 3);
            this._passWordTextBox.Name = "_passWordTextBox";
            this._passWordTextBox.PasswordChar = '*';
            this._passWordTextBox.Size = new System.Drawing.Size(304, 20);
            this._passWordTextBox.TabIndex = 0;
            // 
            // _showPassWordCheckBox
            // 
            this._showPassWordCheckBox.AutoSize = true;
            this._showPassWordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._showPassWordCheckBox.Location = new System.Drawing.Point(3, 101);
            this._showPassWordCheckBox.Name = "_showPassWordCheckBox";
            this._showPassWordCheckBox.Size = new System.Drawing.Size(389, 28);
            this._showPassWordCheckBox.TabIndex = 3;
            this._showPassWordCheckBox.Text = "Show PassWord Characters";
            this._showPassWordCheckBox.UseVisualStyleBackColor = true;
            this._showPassWordCheckBox.CheckedChanged += new System.EventHandler(this.onShowPassWord);
            // 
            // PasswordLoginForm
            // 
            this.AcceptButton = this._passWordOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._passWordCancel;
            this.ClientSize = new System.Drawing.Size(395, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PasswordLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassWord";
            this.Load += new System.EventHandler(this.onLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _passWordCancel;
        private System.Windows.Forms.Button _passWordOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label _passWordLabel;
        private System.Windows.Forms.TextBox _passWordTextBox;
        private System.Windows.Forms.CheckBox _showPassWordCheckBox;
    }
}