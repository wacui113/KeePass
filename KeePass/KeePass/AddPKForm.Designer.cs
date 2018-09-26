﻿namespace KeePass
{
    partial class AddPKForm
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
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ShowPssBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title_txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usern_txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.psswrd_txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.url_txtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.note_txtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.group_cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(78, 359);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(125, 51);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(321, 359);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(125, 51);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ShowPssBtn
            // 
            this.ShowPssBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPssBtn.Location = new System.Drawing.Point(390, 109);
            this.ShowPssBtn.Name = "ShowPssBtn";
            this.ShowPssBtn.Size = new System.Drawing.Size(56, 32);
            this.ShowPssBtn.TabIndex = 10;
            this.ShowPssBtn.Text = "Show";
            this.ShowPssBtn.UseVisualStyleBackColor = true;
            this.ShowPssBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPssBtn_MouseDown);
            this.ShowPssBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPssBtn_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title (*)";
            // 
            // title_txtb
            // 
            this.title_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtb.Location = new System.Drawing.Point(195, 30);
            this.title_txtb.Name = "title_txtb";
            this.title_txtb.Size = new System.Drawing.Size(251, 24);
            this.title_txtb.TabIndex = 0;
            this.title_txtb.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "User name (*)";
            // 
            // usern_txtb
            // 
            this.usern_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern_txtb.Location = new System.Drawing.Point(195, 74);
            this.usern_txtb.Name = "usern_txtb";
            this.usern_txtb.Size = new System.Drawing.Size(251, 24);
            this.usern_txtb.TabIndex = 1;
            this.usern_txtb.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password (*)";
            // 
            // psswrd_txtb
            // 
            this.psswrd_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psswrd_txtb.Location = new System.Drawing.Point(195, 113);
            this.psswrd_txtb.Name = "psswrd_txtb";
            this.psswrd_txtb.Size = new System.Drawing.Size(189, 24);
            this.psswrd_txtb.TabIndex = 2;
            this.psswrd_txtb.Tag = "1";
            this.psswrd_txtb.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL";
            // 
            // url_txtb
            // 
            this.url_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_txtb.Location = new System.Drawing.Point(195, 196);
            this.url_txtb.Name = "url_txtb";
            this.url_txtb.Size = new System.Drawing.Size(251, 24);
            this.url_txtb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Note";
            // 
            // note_txtb
            // 
            this.note_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_txtb.Location = new System.Drawing.Point(195, 238);
            this.note_txtb.Multiline = true;
            this.note_txtb.Name = "note_txtb";
            this.note_txtb.Size = new System.Drawing.Size(251, 97);
            this.note_txtb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Group (*)";
            // 
            // group_cbb
            // 
            this.group_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_cbb.FormattingEnabled = true;
            this.group_cbb.Location = new System.Drawing.Point(195, 151);
            this.group_cbb.Name = "group_cbb";
            this.group_cbb.Size = new System.Drawing.Size(251, 26);
            this.group_cbb.TabIndex = 3;
            this.group_cbb.Tag = "1";
            // 
            // AddPKForm
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.group_cbb);
            this.Controls.Add(this.note_txtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.url_txtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.psswrd_txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usern_txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_txtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPssBtn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPKForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ShowPssBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usern_txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox psswrd_txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox url_txtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox note_txtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox group_cbb;
    }
}