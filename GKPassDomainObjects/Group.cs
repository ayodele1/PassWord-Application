using System.Collections.Generic;

namespace GKPassDomainObjects
{
	public class Group
	{
		#region Non_public Data members
		private string _name;
		private int _imageIndex = 0;
		private List<Key> _keys = new List<Key>();
		#endregion

		#region Public Interface
		public Group()
		{

		}
		public Group(string Name)
		{
			_name = Name;
		}
		public Group(string Name, int ImageIndex)
		{
			_name = Name;
			_imageIndex = ImageIndex;
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int ImageIndex
		{
			get { return _imageIndex; }
			set { _imageIndex = value; }
		}

		public List<Key> Keys
		{
			get { return _keys; }
			set { _keys = value; }
		}

		public override string ToString()
		{
			return Name;
		}
		#endregion

	}
}
