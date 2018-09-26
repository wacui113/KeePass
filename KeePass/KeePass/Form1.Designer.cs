namespace KeePass
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Networking");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Homebanking");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Addtsitem = new System.Windows.Forms.ToolStripButton();
            this.Savetsitem = new System.Windows.Forms.ToolStripButton();
            this.Deletetsitem = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.SaveAstsitem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addtsitem,
            this.Savetsitem,
            this.SaveAstsitem,
            this.Deletetsitem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip";
            // 
            // Addtsitem
            // 
            this.Addtsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Addtsitem.Image = ((System.Drawing.Image)(resources.GetObject("Addtsitem.Image")));
            this.Addtsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addtsitem.Name = "Addtsitem";
            this.Addtsitem.Size = new System.Drawing.Size(23, 22);
            this.Addtsitem.Text = "toolStripButton1";
            this.Addtsitem.ToolTipText = "Add";
            this.Addtsitem.Click += new System.EventHandler(this.Addtsitem_Click);
            // 
            // Savetsitem
            // 
            this.Savetsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Savetsitem.Image = ((System.Drawing.Image)(resources.GetObject("Savetsitem.Image")));
            this.Savetsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Savetsitem.Name = "Savetsitem";
            this.Savetsitem.Size = new System.Drawing.Size(23, 22);
            this.Savetsitem.Text = "Save";
            // 
            // Deletetsitem
            // 
            this.Deletetsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Deletetsitem.Image = ((System.Drawing.Image)(resources.GetObject("Deletetsitem.Image")));
            this.Deletetsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetsitem.Name = "Deletetsitem";
            this.Deletetsitem.Size = new System.Drawing.Size(23, 22);
            this.Deletetsitem.Text = "Delete";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.listViewMain);
            this.pnlMain.Controls.Add(this.treeViewMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 624);
            this.pnlMain.TabIndex = 2;
            // 
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Username,
            this.Password,
            this.URL,
            this.Note});
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.Location = new System.Drawing.Point(184, 0);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(900, 624);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 83;
            // 
            // Username
            // 
            this.Username.Text = "User name";
            this.Username.Width = 161;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 187;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 254;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 211;
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.Name = "General";
            treeNode1.Text = "General";
            treeNode2.Name = "Networking";
            treeNode2.Text = "Networking";
            treeNode3.Name = "Internet";
            treeNode3.Text = "Internet";
            treeNode4.Name = "Homebanking";
            treeNode4.Text = "Homebanking";
            treeNode5.Name = "Database";
            treeNode5.Text = "Database";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewMain.Size = new System.Drawing.Size(184, 624);
            this.treeViewMain.TabIndex = 0;
            // 
            // SaveAstsitem
            // 
            this.SaveAstsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAstsitem.Image = ((System.Drawing.Image)(resources.GetObject("SaveAstsitem.Image")));
            this.SaveAstsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAstsitem.Name = "SaveAstsitem";
            this.SaveAstsitem.Size = new System.Drawing.Size(23, 22);
            this.SaveAstsitem.Text = "Save As";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 673);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeePass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.ToolStripButton Addtsitem;
        private System.Windows.Forms.ToolStripButton Deletetsitem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Savetsitem;
        private System.Windows.Forms.ToolStripButton SaveAstsitem;
    }
}

