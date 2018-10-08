using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO.Compression;
namespace KeePass
{
    public partial class FormMain : Form
    {

        public string filePath = null;
        private static KeePassData data;
        public static KeePassData Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        /* Khởi tạo Form */
        public FormMain()
        {
            InitializeComponent();

            Data = new KeePassData();
            Data.Listdata = new List<KeePass>();
        }
    
        #region Method
        bool Exit_Method()
        {
            if (filePath != null)
            {
                SerializeToXML(Data, filePath);
            }
            else
            {
                if (Data.Listdata.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Do you want to save ?", "Message", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.Yes)
                        {
                            SerializeToXML(Data, sfd.FileName);
                        }
                        else return false;
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        void Add_Method()
        {
            AddPKForm af = new AddPKForm();
            af.ShowDialog();
            AddItemtoListView(AddPKForm.keepass);
            AddPKForm.keepass = null;
        }

        void Edit_Method()
        {
            if (MainListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Too many items selected for editing !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EditForm.kp = data.Listdata.Find(x => x.Id == MainListView.SelectedItems[0].Tag.ToString());
            EditForm ef = new EditForm();
            ef.ShowDialog();

            MainListView.Items.Remove(MainListView.SelectedItems[0]);
            AddItemtoListView(EditForm.kp);

            EditForm.kp = null;
        }

        void Delete_Method()
        {
            if (MainListView.SelectedItems.Count < 1)
            {
                MessageBox.Show("No items selected for deleting !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (var item in MainListView.SelectedItems)
            {
                ListViewItem lvi = item as ListViewItem;
                KeePassData.RemoveKP(lvi.Tag);

                MainListView.Items[lvi.Index].Remove();
            }
        }

        void Loaddata()
        {
            Data = new KeePassData();
            Data.Listdata = new List<KeePass>();
            Data.Listdata.Add(new KeePass(
                "abc1",
                "abc1",
                "abc1",
                KeePass.group.Email,
                "abc1",
                "abc1"
            ));

            Data.Listdata.Add(new KeePass(
                "abc2",
                "abc2",
                "abc2",
                KeePass.group.Windows,
                "abc2",
                "abc2"
            ));

            Data.Listdata.Add(new KeePass(
                "abc3",
                "abc3",
                "abc3",
                KeePass.group.Networking,
                "abc3",
                "abc3"
            ));

            Data.Listdata.Add(new KeePass(
                "abc4",
                "abc4",
                "abc4",
                KeePass.group.General,
                "abc4",
                "abc4"
            ));
        }

        public void LoadListView()
        {
            if (MainListView.Items.Count != data.Listdata.Count)
            {
                MainListView.Items.Clear();
            }

            data.Listdata.Sort(new sortKeePass());
            Load_ListViewGroup();
            foreach (KeePass item in Data.Listdata)
            {
                AddItemtoListView(item);
            }
        }

        public void Load_ListViewGroup()
        {

            foreach(string item in KeePass.Listgrp)
            {
                ListViewGroup lvg = new ListViewGroup();
                MainListView.Groups.Add(lvg);
                lvg.Header = item;
            }
        }

        public void AddItemtoListView(KeePass keepass)
        {
            if (keepass == null)
                return;

            ListViewItem lvi = new ListViewItem();
            MainListView.Items.Add(lvi);

            MainListView.Groups[KeePass.Listgrp.IndexOf(keepass.grp)].Items.Add(lvi);

            lvi.Text = keepass.title;
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.username });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ConvertToPsswrdChar(keepass.password) });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.url });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.note });

            lvi.Tag = keepass.Id;
            lvi.ImageIndex = KeePass.Listgrp.IndexOf(keepass.grp) + 1;
        }

        public static string ConvertToPsswrdChar(string psswrd)
        {
            foreach(char item in psswrd)
            {
                psswrd = psswrd.Replace(item, '•');
            }
            return psswrd;
        }

        #region Serialize Method


        private void SerializeToXML(KeePassData Data, string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmls = new XmlSerializer(typeof(KeePassData));

            xmls.Serialize(file, Data);

            file.Close();

            
        }

        private object DeserializeFromXML(string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //TextReader file = new StreamReader(@filepath);
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(KeePassData));

                object obj;
                obj = xmls.Deserialize(file);
                file.Close();
                return obj;
            }
            catch
            {
                file.Close();
                MessageBox.Show("Cannot open \'" + filepath + "\' file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new NotImplementedException();
                return null;
            }
        }
        #endregion

        #endregion

        #region Events
        private void FormMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    data = DeserializeFromXML(filePath) as KeePassData;
            //}
            //catch
            //{
            //    Loaddata();
            //}
            
            Loaddata();
            LoadListView();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Exit_Method())
            {
                e.Cancel = true;
            }
        }

        /* ToolStrip Events */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                filePath = dg.FileName;
                Data = DeserializeFromXML(filePath) as KeePassData;
                LoadListView();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                SaveFileDialog dg = new SaveFileDialog();
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dg.FileName;
                    SerializeToXML(Data, filePath);
                }
                return;
            }
            SerializeToXML(Data, filePath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exit_Method())
            {
                Application.Exit();
            }
        }
        

        /* Toolbar Events */
        private void Addtsitem_Click(object sender, EventArgs e)
        {
            Add_Method();
        }

        private void Edittsitem_Click(object sender, EventArgs e)
        {
            Edit_Method();
        }

        private void Deletetsitem_Click(object sender, EventArgs e)
        {
            Delete_Method();
        }
        

        /* ListView Events */
        private void listViewMain_MouseClick(object sender, MouseEventArgs e)
        { 
           if(e.Button == MouseButtons.Right)
           {
               Point pt = MainListView.PointToScreen(e.Location);
               ListView_ctms.Show(pt);
           }
        }
        
        /* contextMenuStrip Events */
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MainListView.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        /* ToolStripMenu Events */
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Method();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Method();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Method();
        }


        #endregion

        private void MainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level <= 0)
            {
                MainListView.ShowGroups = true;
                LoadListView();
                return;
            }

            MainListView.ShowGroups = false;
            MainListView.Items.Clear();
            foreach (KeePass item in data.Listdata)
            {
                if(item.Grp == e.Node.Text)
                {
                    AddItemtoListView(item);
                }
            }
            //MainListView.RedrawItems(0, MainListView.Items.Count, true);
        }
    }
}
