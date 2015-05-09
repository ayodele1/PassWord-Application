using GKBusiness;
using GKPassDomainObjects;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterfaceManager
{
    public partial class KeyListControl : UserControl
    {
        #region Non_Public Data Members
        private Key _selectedKey = null;
        private List<Key> _selectedKeys = new List<Key>();
        public bool _edited = false;
        public static event KeySelectedEventHandler KeySelected;

        #endregion

        #region Public Interface
        public KeyListControl()
        {
            InitializeComponent();
        }

        public bool HasSelectedKey()
        {
            if (_selectedKeys.Count != 0)
                return true;
            return false;
        }

        /// <summary>
        /// Returns the Selected Keys in the ListView
        /// </summary>
        public List<Key> SelectedKeys
        {
            get { return _selectedKeys; }
        }
        /// <summary>
        /// Encapsulates the Processes For Editing a Key
        /// </summary>
        public void InvokeKeyEdit()
        {
            KeyPropertiesForm kpf = new KeyPropertiesForm(_selectedKey);
            using (kpf)
            {
                if (kpf.ShowDialog(this) != DialogResult.OK)
                    return;

                _selectedKey.Title = kpf.Title;
                _selectedKey.UserName = kpf.UserName;
                _selectedKey.PassWord = kpf.PassWord;
                _selectedKey.Url = kpf.Url;
                _selectedKey.Notes = kpf.Notes;

                ModifyListItem(_selectedKey);
            }
            _edited = true;
            AutoSizeColumns();
        }
        /// <summary>
        /// Encapsulates the Processes For Adding a Key
        /// </summary>
        public void InvokeKeyAdd()
        {
            if (ContextMgr.SelectedGroup == null)
            {
                MessageBoxHelper.Info(this, "Please Select a Group");
                return;
            }

            KeyPropertiesForm kpf = new KeyPropertiesForm();
            kpf.Text = "Add new Key";
            using (kpf)
            {
                if (kpf.ShowDialog(this) != DialogResult.OK)
                    return;

                Group g = kpf.SelectedGroup;
                Key k = kpf.SelectedKey;
                if (!ContextMgr.AddKeyToGroup(g, k))
                {
                    MessageBoxHelper.Error(this, "Key Could not be Added!");
                    return;
                }
                if (g.ToString() == ContextMgr.SelectedGroup.ToString())
                {
                    AddListViewItem(k);
                }
            }
            _edited = true;
            AutoSizeColumns();
        }
        /// <summary>
        /// Encapsulates the Processes For Editing a Key
        /// </summary>
        public void InvokeKeyDelete()
        {
            DialogResult dr = MessageBoxHelper.QuestionYesNo(this, "This Permanently deletes a Key");
            if (dr == DialogResult.No)
                return;

            foreach (ListViewItem lvi in _keylistView.SelectedItems)
            {
                Key _key = (Key)lvi.Tag;

                if (!ContextMgr.DeleteKeyFromGroup(ContextMgr.SelectedGroup, _key))
                {
                    MessageBoxHelper.Error(this, "Key Could not be Deleted");
                    return;
                }
                DeleteListItem(_key);

            }
            _edited = true;
            AutoSizeColumns();
            MessageBoxHelper.Info(this, "Key Sucessfully Deleted");
        }
        #endregion

        #region Non_Public Properties/Methods
        /// <summary>
        /// AutoSizes the Columns
        /// </summary>
        private void AutoSizeColumns()
        {
            if (_keylistView.Columns.Count != 0)
            {
                _keylistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            if (_keylistView.Items.Count != 0)
            {
                _keylistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        /// <summary>
        /// Adds a new Key to the ListView
        /// </summary>
        /// <param name="k"></param>
        private void AddListViewItem(Key k)
        {
            ListViewItem lvi = _keylistView.Items.Add(k.Title);
            lvi.Tag = k;
            lvi.SubItems.Add(k.UserName);
            lvi.SubItems.Add(k.PassWord);
            lvi.SubItems.Add(k.Url);
            lvi.SubItems.Add(k.Notes);
        }

        /// <summary>
        /// Displays the keys of a group in the ListView
        /// </summary>
        /// <param name="g"></param>
        private void DisplayKeys(Group g)
        {
            _keylistView.BeginUpdate();
            _keylistView.Items.Clear();

            if (g != null)
            {
                foreach (Key k in g.Keys)
                {
                    AddListViewItem(k);
                }
            }
            AutoSizeColumns();
            _keylistView.EndUpdate();
        }
        /// <summary>
        /// Edits the content of a Row of the ListView
        /// </summary>
        /// <param name="_selectedKey"></param>
        private void ModifyListItem(Key _selectedKey)
        {
            ListViewItem lvi = FindRowByTag(_selectedKey);
            if (lvi != null)
            {
                _keylistView.BeginUpdate();
                lvi.Text = _selectedKey.Title;
                lvi.SubItems[1].Text = _selectedKey.UserName;
                lvi.SubItems[2].Text = _selectedKey.PassWord;
                lvi.SubItems[3].Text = _selectedKey.Url;
                lvi.SubItems[4].Text = _selectedKey.Notes;
                _keylistView.EndUpdate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_selectedKey"></param>
        /// <returns></returns>
        private ListViewItem FindRowByTag(Key _selectedKey)
        {
            foreach (ListViewItem lvi in _keylistView.Items)
            {
                if (lvi.Tag == _selectedKey)
                {
                    return lvi;
                }
            }
            return null;
        }
        /// <summary>
        /// Deletes the specified number of Rows from the ListView
        /// </summary>
        /// <param name="k"></param>
        private void DeleteListItem(Key k)
        {
            ListViewItem lvi = FindRowByTag(k);
            lvi.Remove();
        }

        /// <summary>
        /// Copies a key object to the clipboard
        /// </summary>
        private void CopyKeys()
        {
            List<Key> selectedKeys = ContextMgr.SelectedKeys;
            DataObject keyObject = new DataObject("KeyObject", selectedKeys);
            Clipboard.SetDataObject(keyObject);
        }

        private void PasteKeys()
        {
            IDataObject ido = Clipboard.GetDataObject();
            if (ido.GetDataPresent("KeyObject"))
            {
                List<Key> newKeys = (List<Key>)ido.GetData("KeyObject");
                foreach (Key k in newKeys)
                {
                    Key newKey = new Key(k.Title, k.UserName, k.PassWord, k.Url, k.Notes);
                    ContextMgr.AddKeyToGroup(ContextMgr.SelectedGroup, newKey);
                    AddListViewItem(newKey);
                }
            }
        }
        #endregion

        #region EventHandlers
        private void onLoad(object sender, System.EventArgs e)
        {
            AutoSizeColumns();
            Application.Idle += OnIdle;
            ContextMgr.GroupSelected += onGroupSelected;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        void onGroupSelected(Group g)
        {
            DisplayKeys(g);
        }

        void OnIdle(object sender, System.EventArgs e)
        {
            _editKeyButton.Enabled = _keyEditContextMenu.Enabled = _keylistView.SelectedItems.Count == 1;
            _deleteKeyButton.Enabled = _keyDeleteContextMenu.Enabled = _keylistView.SelectedItems.Count != 0;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onKeyAddToolStripClick(object sender, System.EventArgs e)
        {
            InvokeKeyAdd();
        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                onDeleteKey(sender, e);
            }
        }
        private void onEditKeyButtonClick(object sender, System.EventArgs e)
        {
            InvokeKeyEdit();
        }

        private void onKeySelect(object sender, System.EventArgs e)
        {
            ContextMgr.SelectedKeys.Clear();
            foreach (ListViewItem lvi in _keylistView.SelectedItems)
            {
                _selectedKey = (Key)lvi.Tag;
                ContextMgr.SelectedKey = _selectedKey;
                _selectedKeys.Add(_selectedKey);
                ContextMgr.SelectedKeys = _selectedKeys;
            }
            if (_keylistView.SelectedItems.Count < 1)
            {
                ContextMgr.SelectedKey = null;
            }
            if (KeySelected != null)
            {
                KeySelected(ContextMgr.SelectedKey);
            }
        }
        private void onDoubleClick(object sender, MouseEventArgs e)
        {
            onEditKeyButtonClick(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDeleteKey(object sender, System.EventArgs e)
        {
            InvokeKeyDelete();
        }
        #endregion

        private void onDuplicateKey(object sender, System.EventArgs e)
        {
            CopyKeys();
            PasteKeys();
        }
    }
}
