namespace KeePass
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.confirmpsswrd_txtb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.psswrd_txtb = new System.Windows.Forms.TextBox();
            this.confirmpsswrd_pnl = new System.Windows.Forms.Panel();
            this.confirmpsswrd_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // confirmpsswrd_txtb
            // 
            this.confirmpsswrd_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpsswrd_txtb.Location = new System.Drawing.Point(152, 11);
            this.confirmpsswrd_txtb.Name = "confirmpsswrd_txtb";
            this.confirmpsswrd_txtb.Size = new System.Drawing.Size(166, 26);
            this.confirmpsswrd_txtb.TabIndex = 1;
            this.confirmpsswrd_txtb.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(90, 217);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(146, 41);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Register";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm password";
            // 
            // psswrd_txtb
            // 
            this.psswrd_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psswrd_txtb.Location = new System.Drawing.Point(154, 64);
            this.psswrd_txtb.Name = "psswrd_txtb";
            this.psswrd_txtb.Size = new System.Drawing.Size(166, 26);
            this.psswrd_txtb.TabIndex = 0;
            this.psswrd_txtb.UseSystemPasswordChar = true;
            // 
            // confirmpsswrd_pnl
            // 
            this.confirmpsswrd_pnl.Controls.Add(this.label2);
            this.confirmpsswrd_pnl.Controls.Add(this.confirmpsswrd_txtb);
            this.confirmpsswrd_pnl.Location = new System.Drawing.Point(2, 109);
            this.confirmpsswrd_pnl.Name = "confirmpsswrd_pnl";
            this.confirmpsswrd_pnl.Size = new System.Drawing.Size(330, 49);
            this.confirmpsswrd_pnl.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(332, 270);
            this.Controls.Add(this.confirmpsswrd_pnl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.psswrd_txtb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.confirmpsswrd_pnl.ResumeLayout(false);
            this.confirmpsswrd_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmpsswrd_txtb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psswrd_txtb;
        private System.Windows.Forms.Panel confirmpsswrd_pnl;
    }
}