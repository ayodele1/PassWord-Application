using GKBusiness;
using GKPassDomainObjects;
using System;
using System.Windows.Forms;

namespace UserInterfaceManager
{
	public partial class GroupTreeControl : UserControl
	{
		#region Non-Public Data Member
		public bool _edited = false;
		#endregion
		#region Public Interface
		public GroupTreeControl()
		{
			InitializeComponent();
		}

		public bool HasSelectedGroup()
		{
			if (_groupTreeView.SelectedNode != null)
				return true;
			return false;
		}
		/// <summary>
		/// Process For Adding a Group
		/// </summary>
		public void InvokeGroupAdd()
		{
			GroupPropertiesForm gpf = new GroupPropertiesForm();
			using (gpf)
			{
				gpf.Text = "Add New Group";
				if (gpf.ShowDialog(this) != DialogResult.OK)
					return;

				Group newGroup = new Group(gpf.GroupName, 0);
				if (!ContextMgr.AddNewGroup(newGroup))
				{
					MessageBoxHelper.Error(this, "Group could not be added!");
					return;
				}

				AddTreeNode(newGroup);
			}
			_edited = true;
		}
		/// <summary>
		/// Process for Editing a Group
		/// </summary>
		public void InvokeGroupEdit()
		{
			GroupPropertiesForm gpf = new GroupPropertiesForm(_groupTreeView.SelectedNode.Name);
			gpf.Text = "Edit Group";
			using (gpf)
			{
				if (gpf.ShowDialog(this) != DialogResult.OK)
					return;
				Group editGroup = (Group)_groupTreeView.SelectedNode.Tag;
				editGroup.Name = gpf.GroupName;
				ModifyTreeNode(editGroup);
			}
			_edited = true;
		}
		/// <summary>
		/// Process for Deleting a Group
		/// </summary>
		public void InvokeGroupDelete()
		{
			DialogResult dr = MessageBoxHelper.QuestionYesNo(this, "This permanently deletes a Group\n Are You Sure?");
			if (dr == DialogResult.No)
				return;
			Group deleteGroup = (Group)_groupTreeView.SelectedNode.Tag;

			if (!ContextMgr.Deletegroup(deleteGroup))
			{
				MessageBoxHelper.Error(this, "Group could not be deleted!");
				return;
			}
			DeleteTreeNode(deleteGroup);
			ContextMgr.FireGroupSelected();
			MessageBoxHelper.Info(this, "Group Deleted!");
			_edited = true;
		}
		#endregion

		#region Non-Public Properties/Methods
		/// <summary>
		/// Add a new TreeNode
		/// </summary>
		/// <param name="g"></param>
		private void AddTreeNode(Group g)
		{
			TreeNode node = new TreeNode(g.Name, g.ImageIndex, g.ImageIndex);
			node.Name = g.Name;
			node.Tag = g;
			_groupTreeView.SelectedNode = node;
			_groupTreeView.Nodes.Add(node);
		}

		/// <summary>
		/// Modifies the Text of a TreeNode
		/// </summary>
		/// <param name="g"></param>
		private void ModifyTreeNode(Group g)
		{
			TreeNode node = _groupTreeView.SelectedNode;
			node.Text = node.Name = g.Name;
			node.Tag = g;
		}
		/// <summary>
		/// Deletes a TreeNode from the TreeView
		/// </summary>
		/// <param name="deleteGroup"></param>
		private void DeleteTreeNode(Group g)
		{
			TreeNode node = FindNodeByTag(g);
			node.Remove();

			if (_groupTreeView.SelectedNode == null)
			{
				ContextMgr.SelectedGroup = null;
			}
		}

		/// <summary>
		/// Returns the corresponding Node of the Group
		/// </summary>
		/// <param name="g"></param>
		/// <returns></returns>
		private TreeNode FindNodeByTag(Group g)
		{
			foreach (TreeNode n in _groupTreeView.Nodes)
			{
				if (n.Tag == g)
					return n;
			}
			return null;
		}
		/// <summary>
		/// Clears the interface and refreshes the Document
		/// </summary>
		public void ClearDocument()
		{
			foreach (Group g in ContextMgr.Document.Groups)
			{
				DeleteTreeNode(g);
				ContextMgr.FireGroupSelected();
			}
			ContextMgr.Document.Groups.Clear();
		}

		/// <summary>
		/// Opens up a valid file in the interface
		/// </summary>
		/// <param name="doc"></param>
		public void ViewDocument(GKDocument doc)
		{
			foreach (Group g in ContextMgr.Document.Groups)
			{
				AddTreeNode(g);
			}
		}

		#endregion

		#region EventHandler
		private void onGroupAddClick(object sender, EventArgs e)
		{
			InvokeGroupAdd();
		}

		private void onGroupEditClick(object sender, EventArgs e)
		{
			InvokeGroupEdit();
		}

		private void onGroupDeleteClick(object sender, EventArgs e)
		{
			InvokeGroupDelete();
		}
		private void onGroupSelect(object sender, TreeViewEventArgs e)
		{
			ContextMgr.SelectedGroup = (Group)e.Node.Tag;
		}

		private void onLoad(object sender, EventArgs e)
		{
			Application.Idle += onIdle;
		}

		void onIdle(object sender, EventArgs e)
		{
			_groupEditToolStrip.Enabled = _groupDeleteToolStrip.Enabled = _groupTreeView.SelectedNode != null;
			_editGroupContextMenu.Enabled = _deleteGroupContextMenu.Enabled = _groupTreeView.SelectedNode != null;

		}

		private void onKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				onGroupDeleteClick(sender, e);
			}
		}

		private void onNodeDoubleClick(object sender, EventArgs e)
		{
			onGroupEditClick(sender, e);
		}
		#endregion
	}
}
