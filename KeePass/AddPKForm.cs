using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KeePass
{
    public partial class AddPKForm : Form
    {
        public static KeePass keepass;

        public AddPKForm()
        {
            InitializeComponent();

            group_cbb.DataSource = Enum.GetValues(typeof(KeePass.group));
            group_cbb.SelectedIndex = -1;
        }

        #region Method

        // Get All-Control with <Type>
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        bool txtbHasData()
        {
            var c = GetAll(this, typeof(TextBox));
            foreach(Control item in c)
            {
                if(item.Text != "")
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region Events

        private void ShowPssBtn_MouseUp(object sender, MouseEventArgs e)
        {
            psswrd_txtb.UseSystemPasswordChar = true;
        }

        private void ShowPssBtn_MouseDown(object sender, MouseEventArgs e)
        {
            psswrd_txtb.UseSystemPasswordChar = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //if (!txtbHasData() && group_cbb.SelectedIndex <= -1)
            //{
            //    MessageBox.Show("Requirement(*) field cannot be empty !", "Message", MessageBoxButtons.OK);
            //}
            //else
            //{
                keepass = new KeePass(
                    title_txtb.Text,
                    usern_txtb.Text,
                    psswrd_txtb.Text,
                    (KeePass.group)Enum.Parse(typeof(KeePass.group), group_cbb.SelectedValue.ToString()),
                    url_txtb.Text,
                    note_txtb.Text
                );
                FormMain.Data.Listdata.Add(keepass);
                this.Close();
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if(txtbHasData() /*&& group_cbb.SelectedIndex < 0*/)
            {
                this.Close();
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Do you want to quit ?", "Message", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        #endregion
    }
}
