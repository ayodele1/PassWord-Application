using GKBusiness;
using GKPassDomainObjects;
using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	public partial class KeyPropertiesForm : Form
	{
		#region Non-Public Data Members
		private Group _group = null;
		private Key _key = null;
		#endregion

		#region Public Interface
		public KeyPropertiesForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Initializes a KeyPropertiesForm with a Key value
		/// </summary>
		/// <param name="k"></param>
		public KeyPropertiesForm(Key k)
			: this()
		{
			_key = k;
		}

		/// <summary>
		/// Returns the currently selected Item of the ComboBox
		/// </summary>
		public Group SelectedGroup
		{
			get { return _group; }
			set { _group = value; }
		}

		/// <summary>
		/// Returns the Key Values of the Form
		/// </summary>
		public Key SelectedKey
		{
			get { return _key; }
			set { _key = value; }
		}

		public string Title
		{
			get { return _titleTbox.Text; }
		}
		public string UserName
		{
			get { return _userNameTbox.Text; }
		}
		public string PassWord
		{
			get { return _passWordTbox.Text; }
		}
		public string Url
		{
			get { return _urlTbox.Text; }
		}
		public string Notes
		{
			get { return _notesRichTBox.Text; }
		}
		#endregion

		#region Non-Public Properties/Methods
		private bool ValidateInput()
		{
			if (string.IsNullOrEmpty(_titleTbox.Text))
			{
				MessageBoxHelper.Error(this, "Key Title Cannot be blank!");
				return false;
			}

			if (string.IsNullOrEmpty(_userNameTbox.Text))
			{
				MessageBoxHelper.Error(this, "Key UserName Cannot be blank!");
				return false;
			}

			if (string.IsNullOrEmpty(_passWordTbox.Text))
			{
				MessageBoxHelper.Error(this, "Key PassWord Cannot be blank!");
				return false;
			}

			if (string.IsNullOrEmpty(_confmPasswdTbox.Text))
			{
				MessageBoxHelper.Error(this, "Please Enter Your Password again!");
				return false;
			}

			if (!string.Equals(_passWordTbox.Text, _confmPasswdTbox.Text))
			{
				MessageBoxHelper.Error(this, "PassWords do not match");
				return false;
			}
			return true;
		}
		#endregion

		#region Event Handlers
		private void onLoad(object sender, EventArgs e)
		{
			foreach (Group g in ContextMgr.Document.Groups)
			{
				_keyComboBox.Items.Add(g);
			}
			_keyComboBox.SelectedItem = ContextMgr.SelectedGroup;

			if (_key != null)
			{
				this.Text = "Edit Key";
				_titleTbox.Text = _key.Title;
				_userNameTbox.Text = _key.UserName;
				_passWordTbox.Text = _key.PassWord;
				_confmPasswdTbox.Text = _key.PassWord;
				_urlTbox.Text = _key.Url;
				_notesRichTBox.Text = _key.Notes;
				_keyComboBox.Enabled = false;
			}
		}
		private void onKpCancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}

		private void onKpTestButtonClick(object sender, EventArgs e)
		{
			_titleTbox.Text = Randomizor.GenerateString(10);
			_userNameTbox.Text = Randomizor.GenerateString(13);
			_passWordTbox.Text = _confmPasswdTbox.Text = Randomizor.GenerateString(14);
			_urlTbox.Text = Randomizor.GenerateString(20);
			_notesRichTBox.Text = Randomizor.GenerateString(40);
		}
		private void onKpOkButtonClick(object sender, EventArgs e)
		{
			if (!ValidateInput())
				return;
			if (_key == null)
			{
				_key = new Key();
				_key.Title = _titleTbox.Text;
				_key.UserName = _userNameTbox.Text;
				_key.PassWord = _passWordTbox.Text;
				_key.Url = _urlTbox.Text;
				_key.Notes = _notesRichTBox.Text;
			}
			_group = (Group)_keyComboBox.SelectedItem;

			DialogResult = DialogResult.OK;
			Close();
		}
		#endregion
	}
}
