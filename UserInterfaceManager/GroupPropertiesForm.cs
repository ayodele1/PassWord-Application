using GKBusiness;
using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	/// <summary>
	/// Launches a new dialog to add a new Group
	/// </summary>
	public partial class GroupPropertiesForm : Form
	{
		#region Non_public Data Members
		private string _groupName = null;
		private string ErrorMsg = "Error: GroupName cannot be blank!";
		#endregion

		#region Public Interface

		public GroupPropertiesForm()
		{
			InitializeComponent();
		}
		public GroupPropertiesForm(string GroupName)
			: this()
		{
			_groupName = GroupName;
		}

		public string GroupName
		{
			get { return _gpTBox.Text; }
		}
		#endregion

		#region Event Handlers
		private void onGPTestClick(object sender, EventArgs e)
		{
			_gpTBox.Text = Randomizor.GenerateString(10);

		}

		private void _onGpCancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}

		private void onGpOKButtonClick(object sender, EventArgs e)
		{
			if (!AuthenticationMgr.Validate(_gpTBox.Text))
			{
				MessageBoxHelper.Error(this, ErrorMsg);
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void onLoad(object sender, EventArgs e)
		{
			if (_groupName != null)
			{
				_gpTBox.Text = _groupName;
			}
		}
		#endregion

	}
}
