using GKPassDomainObjects;
using System.Collections.Generic;

namespace GKBusiness
{
	public delegate void GroupSelectedEventHandler(Group g);
	public static class ContextMgr
	{
		#region Non_Public Data Members

		private static GKDocument _document = new GKDocument();
		private static Group _selectedGroup = null;
		private static List<Key> _selectedKeys = new List<Key>();
		public static event GroupSelectedEventHandler GroupSelected;

		#endregion

		#region Public interface

		/// <summary>
		/// Returns the item(group) in the Selected node of the GroupTreeControl
		/// </summary>
		public static Group SelectedGroup
		{
			get { return _selectedGroup; }
			set
			{
				_selectedGroup = value;

				if (_selectedGroup != null)
					GroupSelected(_selectedGroup);

			}
		}
		public static List<Key> SelectedKeys
		{
			get { return _selectedKeys; }
			set { _selectedKeys = value; }
		}
		public static void FireGroupSelected()
		{
			if (GroupSelected != null)
			{
				GroupSelected.Invoke(_selectedGroup);
			}
		}
		/// <summary>
		/// Returns the Document that contains the Groups
		/// </summary>
		public static GKDocument Document
		{
			get { return _document; }
			set { _document = value; }
		}

		/// <summary>
		/// Adds a new Group
		/// </summary>
		/// <param name="Group"></param>
		/// <returns></returns>
		public static bool AddNewGroup(Group group)
		{
			_document.Groups.Add(group);
			return true;
		}

		/// <summary>
		/// Deletes a particular Group
		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public static bool Deletegroup(Group group)
		{
			Group currentGroup = FindGroup(group);
			if (currentGroup == null)
			{
				return false;
			}
			//First Delete the Keys of the Group
			DeleteAllKeys(currentGroup);

			_document.Groups.Remove(group);
			return true;
		}

		private static Group FindGroup(Group group)
		{
			Group match = _document.Groups.Find(g => g == group);
			return match;
		}

		/// <summary>
		/// Deletes all the Keys in a particular group
		/// </summary>
		/// <param name="g"></param>
		private static void DeleteAllKeys(Group g)
		{
			g.Keys.Clear();
		}

		/// <summary>
		/// Adds a Key to a Group
		/// </summary>
		/// <param name="g"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public static bool AddKeyToGroup(Group g, Key k)
		{
			Group currentGroup = FindGroup(g);
			if (g == null)
			{
				return false;
			}
			currentGroup.Keys.Add(k);
			return true;
		}

		public static bool DeleteKeyFromGroup(Group g, Key k)
		{
			Key currentKey = FindKey(g, k);
			g.Keys.Remove(currentKey);
			return true;
		}

		private static Key FindKey(Group g, Key k)
		{
			Key _key = g.Keys.Find(s => s == k);
			if (_key != null)
			{
				return _key;
			}
			return null;
		}
		#endregion
	}
}
