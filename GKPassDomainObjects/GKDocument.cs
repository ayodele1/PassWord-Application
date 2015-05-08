using System.Collections.Generic;

namespace GKPassDomainObjects
{
	public class GKDocument
	{
		#region Non-Public Data Members
		private List<Group> _groups = new List<Group>();
		#endregion

		#region Public Interface
		public GKDocument()
		{

		}

		public GKDocument(List<Group> Groups)
		{
			_groups = Groups;
		}

		public List<Group> Groups
		{
			get { return _groups; }
			set { _groups = value; }
		}
		#endregion
	}
}
