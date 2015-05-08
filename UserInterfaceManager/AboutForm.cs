using GKPassDomainObjects;
using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void onLoad(object sender, EventArgs e)
		{
			this.Text = MyCompany.ProductName;
			_lblCompanyName.Text = MyCompany.Name;
			_lblAuthor.Text = MyCompany.ProductAuthor;
			_lblProductName.Text = MyCompany.ProductName;
			_lblProductVersion.Text = MyCompany.Version;
			_lblProductDescription.Text = MyCompany.ProductDescription;
		}
	}
}
