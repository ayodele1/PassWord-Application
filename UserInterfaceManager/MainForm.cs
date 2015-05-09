using GKBusiness;
using GKPassDomainObjects;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UserInterfaceManager
{
    public partial class MainForm : Form
    {
        private string _currentFileLocation = null;
        private bool _fileSaved = false;

        #region Public Interface
        public MainForm()
        {
            InitializeComponent();
        }

        private bool DocumentEdited()
        {
            if ((_groupTreeControl._edited == true) || (_keyListControl._edited == true))
                return true;
            return false;
        }
        #endregion

        #region Non-public Properties/Methods
        private void setTitle(string filename)
        {
            this.Text = filename;
        }
        /// <summary>
        /// Launches a new modal window for the about form
        /// </summary>
        private void LaunchAboutForm()
        {
            AboutForm af = new AboutForm();
            using (af)
            {
                if (af.ShowDialog() != DialogResult.OK)
                    return;
            }
        }
        /// <summary>
        /// Saves current session to a Xml file.[Displays a dialogBox]
        /// </summary>
        /// <param name="currentDocument"></param>
        private bool SaveAs(GKDocument currentDocument)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "KeyPassFiles | *.xml";
            sfd.DefaultExt = ".xml";
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = Assembly.GetExecutingAssembly().Location;
            using (sfd)
            {
                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return false;
                try
                {
                    SaveXml(currentDocument, sfd.FileName);
                }
                catch (XmlException e)
                {
                    MessageBoxHelper.Error(this, "Error in saving file\n" + e.Message);
                    return false;
                }

            }

            //Document is no more edited if file is already saved.
            _groupTreeControl._edited = false;
            _keyListControl._edited = false;
            _currentFileLocation = sfd.FileName;
            setTitle(Path.GetFileName(sfd.FileName));
            return true;
        }
        /// <summary>
        /// Saves the file to the currently open file.[Doesn't display a dialogBox].
        /// </summary>
        /// <param name="currentDocument"></param>
        /// <returns></returns>
        private bool Save(GKDocument currentDocument)
        {
            try
            {
                SaveXml(currentDocument, _currentFileLocation);
            }
            catch (XmlException e)
            {
                MessageBoxHelper.Error(this, "Error in saving file\n" + e.Message);
                return false;
            }
            //Document is no more edited if file is already saved.
            _groupTreeControl._edited = false;
            _keyListControl._edited = false;
            return true;
        }
        /// <summary>
        /// Writes Group and Keys to an xml file for saving
        /// </summary>
        /// <param name="currentDocument"></param>
        /// <param name="fileName"></param>
        private static void SaveXml(GKDocument currentDocument, String fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter xw = XmlWriter.Create(fileName, settings);
            using (xw)
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("KeyPassDocument");
                foreach (Group g in currentDocument.Groups)
                {
                    xw.WriteStartElement("Group");
                    xw.WriteElementString("GroupName", g.Name);

                    foreach (Key k in g.Keys)
                    {
                        xw.WriteStartElement("Keys");
                        xw.WriteElementString("KeyTitle", k.Title);
                        xw.WriteElementString("KeyUserName", k.UserName);
                        xw.WriteElementString("KeyPassWord", k.PassWord);
                        xw.WriteElementString("KeyUrl", k.Url);
                        xw.WriteElementString("KeyNote", k.Notes);
                        xw.WriteEndElement();
                    }
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
            }
            xw.Flush();
            xw.Close();
        }
        /// <summary>
        /// Opens a '.xml' file type.
        /// </summary>
        /// <param name="newDocument"></param>
        private bool OpenXmlFile(GKDocument newDocument)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "KeyPassFiles(.xml) | *.xml | KeyPassEncrypted(.kcf)| *.kcf";
            ofd.DefaultExt = ".xml";
            ofd.InitialDirectory = Assembly.GetExecutingAssembly().Location;
            using (ofd)
            {
                if (ofd.ShowDialog(this) != DialogResult.OK)
                {
                    return false;
                }
                if (ofd.FilterIndex == 1)
                {
                    try
                    {
                        ReadXml(newDocument, ofd.FileName);
                    }
                    catch (XmlException e)
                    {
                        MessageBoxHelper.Error(this, "The xml File is invalid\n" + e.Message);
                        return false;
                    }
                }
                else if (ofd.FilterIndex == 2)
                {
                    OpenEncryptedFile(ofd.FileName, newDocument);
                }

            }
            //Document is no more edited if file is already saved.
            _groupTreeControl._edited = false;
            _keyListControl._edited = false;
            _currentFileLocation = ofd.FileName;
            setTitle(Path.GetFileName(_currentFileLocation));
            return true;
        }

        private void OpenEncryptedFile(string fileName, GKDocument doc)
        {
            GKDocument newDoc;
            byte[] encryptedBuffer = File.ReadAllBytes(fileName);
            byte[] decryptedDocument = CryptoHelper.Decrypt(encryptedBuffer);

            MemoryStream ms = new MemoryStream(decryptedDocument);
            using (ms)
            {
                BinaryFormatter bf = new BinaryFormatter();
                newDoc = (GKDocument)bf.Deserialize(ms);
            }

            foreach (Group g in newDoc.Groups)
            {
                doc.Groups.Add(g);
            }

        }
        /// <summary>
        /// Reads each node of the xml file into a Group-Key Document for viewing
        /// </summary>
        /// <param name="newDocument"></param>
        /// <param name="filePath"></param>
        private static void ReadXml(GKDocument newDocument, string filePath)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(filePath);
            XmlElement rootElement = xd.DocumentElement;
            XmlNodeList groupNodes = rootElement.SelectNodes("/KeyPassDocument/Group");

            foreach (XmlNode node in groupNodes)
            {
                Group g = new Group(node["GroupName"].InnerText);

                XmlNodeList keyNodes = node.SelectNodes(".//Keys");

                foreach (XmlNode knode in keyNodes)
                {
                    Key k = new Key();
                    k.Title = knode["KeyTitle"].InnerText;
                    k.UserName = knode["KeyUserName"].InnerText;
                    k.PassWord = knode["KeyPassWord"].InnerText;
                    k.Url = knode["KeyUrl"].InnerText;
                    k.Notes = knode["KeyNote"].InnerText;
                    g.Keys.Add(k);
                }
                newDocument.Groups.Add(g);
            }
        }

        private void SaveAsEncryptedData()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Assembly.GetExecutingAssembly().Location;
            sfd.Filter = "KeyPassEncrypted | .kcf";
            sfd.DefaultExt = "kcf";
            using (sfd)
            {
                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                GKDocument currentDoc = ContextMgr.Document;
                try
                {
                    MemoryStream ms = new MemoryStream();
                    using (ms)
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(ms, currentDoc);
                    }
                    byte[] buffer = ms.ToArray();
                    byte[] encryptedDocument = CryptoHelper.Encrypt(buffer);

                    string path = Path.GetFullPath(sfd.FileName);

                    File.WriteAllBytes(path, encryptedDocument);
                    setTitle(Path.GetFileName(sfd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.Error(this, ex.Message);
                    return;
                }
                _groupTreeControl._edited = false;
                _keyListControl._edited = false;

            }
        }
        #endregion

        #region MenuBar Manipulation
        private void onViewMenuOpening(object sender, EventArgs e)
        {
            _toolBarMenuItem.Checked = _mainToolStrip.Visible;
            _statusBarMenuItem.Checked = _mainStatusControl.Visible;
        }

        private void onToolBarClick(object sender, EventArgs e)
        {
            _mainToolStrip.Visible = !_mainToolStrip.Visible;
        }

        private void onStatusBarClick(object sender, EventArgs e)
        {
            _mainStatusControl.Visible = !_mainStatusControl.Visible;
        }

        private void onAboutMenuClick(object sender, EventArgs e)
        {
            LaunchAboutForm();
        }

        private void onHelpToolStripClick(object sender, EventArgs e)
        {
            LaunchAboutForm();
        }
        #endregion

        #region EventHandlers
        private void onLoad(object sender, EventArgs e)
        {
            Application.Idle += OnIdle;
            KeyListControl.KeySelected += onKeySelected;
        }

        void OnIdle(object sender, EventArgs e)
        {
            _editGroupToolStrip.Enabled = _deleteGroupToolStrip.Enabled = _groupTreeControl.HasSelectedGroup();
            _editKeyToolStrip.Enabled = _deleteKeyToolStrip.Enabled = _keyListControl.HasSelectedKey();
            _saveButton.Enabled = _saveFileMenu.Enabled = this.DocumentEdited() == true;
        }

        private void onNewDocumentClick(object sender, EventArgs e)
        {
            if (DocumentEdited())
            {
                DialogResult dr = MessageBoxHelper.QuestionYesNoCancel(this, "Document is insaved. Do you want to save?");
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                if (dr == DialogResult.No)
                {
                    _groupTreeControl.ClearDocument();
                }
                if (dr == DialogResult.Yes)
                {
                    onSaveFile(sender, e);
                    if (_fileSaved == false)
                    {
                        return;
                    }
                }
                _groupTreeControl.ClearDocument();
            }
            else
            {
                _groupTreeControl.ClearDocument();
            }
            _groupTreeControl._edited = false;
            _keyListControl._edited = false;
            _currentFileLocation = null;
            setTitle("New Document");
        }

        void onKeySelected(Key k)
        {
            if (k != null)
            {
                _richTextBox.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Title: " + k.Title)
                        .AppendLine("UserName:" + k.UserName)
                        .AppendLine("PassWord: " + k.PassWord)
                        .AppendLine("Url: " + k.Url)
                        .AppendLine("Notes")
                        .AppendLine("----------------------------------")
                        .AppendLine(k.Notes);
                _richTextBox.Text = sb.ToString();
            }
            else
            {
                _richTextBox.Clear();
            }
        }

        private void onGroupAddClick(object sender, EventArgs e)
        {
            _groupTreeControl.InvokeGroupAdd();
        }
        private void onGroupEditClick(object sender, EventArgs e)
        {
            _groupTreeControl.InvokeGroupEdit();
        }

        private void onGroupDeleteClick(object sender, EventArgs e)
        {
            _groupTreeControl.InvokeGroupDelete();
        }
        private void onAddKeyClick(object sender, EventArgs e)
        {
            _keyListControl.InvokeKeyAdd();
        }

        private void onEditKeyClick(object sender, EventArgs e)
        {
            _keyListControl.InvokeKeyEdit();
        }

        private void onDeleteKeyClick(object sender, EventArgs e)
        {
            _keyListControl.InvokeKeyDelete();
        }
        private void onSaveButtonClick(object sender, EventArgs e)
        {
            GKDocument currentDocument = ContextMgr.Document;
            if (_currentFileLocation != null)
            {
                Save(currentDocument);
            }
            if (_currentFileLocation == null)
            {
                SaveAs(currentDocument);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSaveAsFile(object sender, EventArgs e)
        {
            onSaveButtonClick(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSaveFile(object sender, EventArgs e)
        {
            GKDocument currentDocument = ContextMgr.Document;
            if (_currentFileLocation != null)
            {
                Save(currentDocument);

            }
            if (_currentFileLocation == null)
            {
                SaveAs(currentDocument);
            }
            _fileSaved = true;
        }
        private void onOpenFile(object sender, EventArgs e)
        {
            GKDocument newDocument = new GKDocument();
            if (DocumentEdited())
            {
                DialogResult dr = MessageBoxHelper.QuestionYesNoCancel(this, "Document is insaved. Do you want to save?");
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                if (dr == DialogResult.No)
                {
                    if (!OpenXmlFile(newDocument))
                    {
                        return;
                    }
                    _groupTreeControl.ClearDocument();
                }
                if (dr == DialogResult.Yes)
                {
                    onSaveFile(sender, e);
                    if (!OpenXmlFile(newDocument))
                    {
                        return;
                    }
                    _groupTreeControl.ClearDocument();
                }
                ContextMgr.Document = newDocument;
                _groupTreeControl.ViewDocument(newDocument);
            }
            else
            {
                if (!OpenXmlFile(newDocument))
                {
                    return;
                }
                _groupTreeControl.ClearDocument();
                ContextMgr.Document = newDocument;
                _groupTreeControl.ViewDocument(newDocument);
            }
        }
        #endregion

        private void onSaveEncryptedData(object sender, EventArgs e)
        {
            SaveAsEncryptedData();
        }
    }
}
