
namespace GKPassDomainObjects
{
	public class Key
	{
		#region Non-Public Data Members
		private string _title;
		private string _username;
		private string _password;
		private string _url;
		private Group _group;
		private string _notes;
		#endregion

		#region Public Interface
		public Key()
		{

		}

		public Key(string Title, string UserName, string Password, string Url, string Notes)
		{
			_title = Title;
			_username = UserName;
			_password = Password;
			_url = Url;
			_notes = Notes;
		}
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}
		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}
		public string PassWord
		{
			get { return _password; }
			set { _password = value; }
		}
		public string Url
		{
			get { return _url; }
			set { _url = value; }
		}
		public Group Group
		{
			get { return _group; }
			set { _group = value; }
		}

		public string Notes
		{
			get { return _notes; }
			set { _notes = value; }
		}
		#endregion

	}
}
