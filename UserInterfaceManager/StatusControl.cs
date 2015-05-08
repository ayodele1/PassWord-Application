using GKBusiness;
using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	public partial class StatusControl : UserControl
	{
		public StatusControl()
		{
			InitializeComponent();
		}

		private void onLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
		}

		void OnIdle(object sender, EventArgs e)
		{
			if (DesignMode)
				return;
			_totalGroupsLabel.Text = "Total Groups: " + ContextMgr.Document.Groups.Count;

			int _totalKeys = 0;
			int _selectedKeys = 0;

			if (ContextMgr.SelectedGroup != null)
			{
				_totalKeys = ContextMgr.SelectedGroup.Keys.Count;
			}

			_selectedKeys = ContextMgr.SelectedKeys.Count;
			_keysLabel.Text = _selectedKeys + " Selected of " + _totalKeys;
		}

		private void onMouseOver(object sender, EventArgs e)
		{

		}
	}
}
