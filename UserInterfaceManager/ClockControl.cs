using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	public partial class ClockControl : UserControl
	{
		public ClockControl()
		{
			InitializeComponent();
		}

		private void onTick(object sender, EventArgs e)
		{
			_dateTimeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
		}

		private void onWindowsClockShow(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("timedate.cpl");
		}
	}
}
