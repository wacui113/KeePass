using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeePass
{
    public partial class EditForm : Form
    {
        public static KeePass kp;

        public EditForm()
        {
            InitializeComponent();

            LoadSelectedItemInfo();
        }

        bool txtbHasData()
        {
            var c = AddPKForm.GetAll(this, typeof(TextBox));
            foreach (Control item in c)
            {
                if (item.Text != "")
                {
                    if (item.Name.Contains("note") || item.Name.Contains("url"))
                        continue;
                    else
                        return true;
                }
            }

            return false;
        }

        public void LoadSelectedItemInfo()
        {
            title_txtb.Text = kp.Title;
            usern_txtb.Text = kp.Username;
            psswrd_txtb.Text = DataEncryptor.Decrypt(kp.Password);

            group_cbb.DataSource = Enum.GetValues(typeof(KeePass.group));
            group_cbb.SelectedIndex = KeePass.Listgrp.IndexOf(kp.Grp.ToString());

            url_txtb.Text = kp.Url;
            note_txtb.Text = kp.Note;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(!txtbHasData())
            {
                MessageBox.Show("Không thể để trống !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            kp.Title = title_txtb.Text;
            kp.Username = usern_txtb.Text;
            kp.Password = psswrd_txtb.Text;

            kp.Grp = KeePass.Listgrp[group_cbb.SelectedIndex];

            kp.Url = url_txtb.Text;
            kp.Note = note_txtb.Text;

            this.Close();
        }

        private void ShowPssBtn_MouseDown(object sender, MouseEventArgs e)
        {
            psswrd_txtb.UseSystemPasswordChar = false;
        }

        private void ShowPssBtn_MouseUp(object sender, MouseEventArgs e)
        {
            psswrd_txtb.UseSystemPasswordChar = true;
        }
    }
}
