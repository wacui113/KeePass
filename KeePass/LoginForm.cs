using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Security.AccessControl;

namespace KeePass
{
    public partial class LoginForm : Form
    {
        private string filePath = "bquot.dat";

        public static string psswrdHash_str;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                login_btn.Text = "Login";
                confirmpsswrd_pnl.Visible = false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            switch (login_btn.Text)
            {
                case "Register":
                    if (psswrd_txtb.Text != confirmpsswrd_txtb.Text)
                    {
                        MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    psswrdHash_str = Encryptor.MD5Hash(psswrd_txtb.Text);
                    File.WriteAllText(filePath, psswrdHash_str);
                    File.SetAttributes(filePath, FileAttributes.Hidden | FileAttributes.ReadOnly);

                    break;

                case "Login":
                    psswrdHash_str = File.ReadAllText(filePath);

                    if (Encryptor.MD5Hash(psswrd_txtb.Text) != psswrdHash_str)
                    {
                        MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            /* Đóng Form hiện tại & Mở Form mới 
             Source: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form */
            this.Hide();
            var form = new FormMain();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
