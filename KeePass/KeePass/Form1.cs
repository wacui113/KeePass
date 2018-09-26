using KeePass;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KeePass
{
    public partial class FormMain : Form
    {
        public string filePath = null;
        public static KeePassData data { get; set; }

        public FormMain()
        {
            InitializeComponent();
            data = new KeePassData();
            //try
            //{
            //    data = DeserializeFromXML(filePath) as KeePassData;
            //}
            //catch
            //{
            //    Loaddata();
            //}
            LoadListView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ExitMethod())
            {
                Application.Exit();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!ExitMethod())
            {
                e.Cancel = true;
            }
        }

        bool ExitMethod()
        {
            if (filePath != null)
            {
                SerializeToXML(data, filePath);
            }
            else
            {
                if (data.Listdata.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Do you want to save ?", "Message", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.Yes)
                        {
                            SerializeToXML(data, sfd.FileName);
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

        void Loaddata()
        {
            data = new KeePassData();
            data.Listdata = new List<KeePass>();
            data.Listdata.Add(new KeePass()
            {
                title = "abc",
                username = "abc",
                password = "abc",
                grp = KeePass.Listgrp[(int)KeePass.group.General],
                url = "abc",
                note = "abc",
            });
        }

        public void LoadListView()
        {
            listViewMain.Items.Clear();
            if(data.Listdata == null)
            {
                data = new KeePassData();
                data.Listdata = new System.Collections.Generic.List<KeePass>();
            }
            foreach(KeePass item in data.Listdata)
            {
                AddItemtoListView(item);
            }
        }

        public void AddItemtoListView(KeePass keepass)
        {
            ListViewItem lvi = new ListViewItem();
            listViewMain.Items.Add(lvi);
            lvi.Text = keepass.title;
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.username });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ConvertToPsswrdChar(keepass.password) });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.url });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = keepass.note });
        }

        public static string ConvertToPsswrdChar(string psswrd)
        {
            foreach(char item in psswrd)
            {
                psswrd = psswrd.Replace(item, '•');
            }
            return psswrd;
        }

        private void Addtsitem_Click(object sender, EventArgs e)
        {
            AddPKForm af = new AddPKForm();
            af.ShowDialog();
            AddItemtoListView(AddPKForm.keepass);
            AddPKForm.keepass = null;
        }

        private void SerializeToXML(KeePassData Data, string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmls = new XmlSerializer(typeof(KeePassData));

            xmls.Serialize(file, Data);

            file.Close();
        }

        private object DeserializeFromXML(string filepath)
        {
            if (File.Exists(filepath))
            {

                TextReader file = new StreamReader(@filepath);
                try
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(KeePassData));

                    object obj = xmls.Deserialize(file);
                    file.Close();
                    return obj;
                }
                catch
                {
                    file.Close();
                    MessageBox.Show("Cannot open \'" + filepath + "\' file !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new NotImplementedException();
                }
            }
            return null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                SaveFileDialog dg = new SaveFileDialog();
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dg.FileName;
                    SerializeToXML(data, filePath);
                }
                return;
            }
            SerializeToXML(data, filePath);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            if(dg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    data = new KeePassData();
                    data = DeserializeFromXML(dg.SafeFileName) as KeePassData;
                    filePath = dg.FileName;
                    LoadListView();
                }
                catch
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
