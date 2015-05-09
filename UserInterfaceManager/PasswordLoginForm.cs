using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
    public partial class PasswordLoginForm : Form
    {
        public PasswordLoginForm()
        {
            InitializeComponent();
        }

        private string _defaultPassWord = "FooBarMeow";

        private void onLoad(object sender, EventArgs e)
        {
            _passWordTextBox.Text = _defaultPassWord;
        }

        private void onOk(object sender, EventArgs e)
        {
            if (!ValidatePassWord())
            {
                MessageBox.Show("Invalid PassWord!");
                return;
            }
            else
            {
                MainForm f = new MainForm();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }

        }

        #region PassWordCheck
        private bool ValidatePassWord()
        {
            if (_passWordTextBox.Text != _defaultPassWord)
                return false;
            return true;
        }
        #endregion

        private void onCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void onShowPassWord(object sender, EventArgs e)
        {
            _passWordTextBox.PasswordChar = _showPassWordCheckBox.Checked ? '\0' : '*';
        }
    }
}
