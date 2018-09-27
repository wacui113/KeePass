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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Networking");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Homebanking");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.Addtsitem = new System.Windows.Forms.ToolStripButton();
            this.Edittsitem = new System.Windows.Forms.ToolStripButton();
            this.Deletetsitem = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.MainListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.ListView_ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.ListView_ctms.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1084, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addtsitem,
            this.Edittsitem,
            this.Deletetsitem});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1084, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "MainToolStrip";
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
            // Edittsitem
            // 
            this.Edittsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edittsitem.Image = ((System.Drawing.Image)(resources.GetObject("Edittsitem.Image")));
            this.Edittsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edittsitem.Name = "Edittsitem";
            this.Edittsitem.Size = new System.Drawing.Size(23, 22);
            this.Edittsitem.Text = "Edit";
            // 
            // Deletetsitem
            // 
            this.Deletetsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Deletetsitem.Image = ((System.Drawing.Image)(resources.GetObject("Deletetsitem.Image")));
            this.Deletetsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetsitem.Name = "Deletetsitem";
            this.Deletetsitem.Size = new System.Drawing.Size(23, 22);
            this.Deletetsitem.Text = "Delete";
            this.Deletetsitem.Click += new System.EventHandler(this.Deletetsitem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.MainListView);
            this.pnlMain.Controls.Add(this.MainTreeView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 624);
            this.pnlMain.TabIndex = 2;
            // 
            // MainListView
            // 
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Username,
            this.Password,
            this.URL,
            this.Note});
            this.MainListView.FullRowSelect = true;
            this.MainListView.Location = new System.Drawing.Point(184, 0);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(900, 624);
            this.MainListView.TabIndex = 1;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            this.MainListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMain_MouseClick);
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
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            treeNode6.Name = "General";
            treeNode6.Text = "General";
            treeNode7.Name = "Networking";
            treeNode7.Text = "Networking";
            treeNode8.Name = "Internet";
            treeNode8.Text = "Internet";
            treeNode9.Name = "Homebanking";
            treeNode9.Text = "Homebanking";
            treeNode10.Name = "Database";
            treeNode10.Text = "Database";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.MainTreeView.Size = new System.Drawing.Size(184, 624);
            this.MainTreeView.TabIndex = 0;
            // 
            // ListView_ctms
            // 
            this.ListView_ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyPasswordToolStripMenuItem,
            this.gotoURLToolStripMenuItem});
            this.ListView_ctms.Name = "contextMenuStrip1";
            this.ListView_ctms.Size = new System.Drawing.Size(153, 142);
            this.ListView_ctms.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy password";
            // 
            // gotoURLToolStripMenuItem
            // 
            this.gotoURLToolStripMenuItem.Name = "gotoURLToolStripMenuItem";
            this.gotoURLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gotoURLToolStripMenuItem.Text = "Goto URL";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 673);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeePass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ListView_ctms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripButton Addtsitem;
        private System.Windows.Forms.ToolStripButton Deletetsitem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Edittsitem;
        private System.Windows.Forms.ContextMenuStrip ListView_ctms;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoURLToolStripMenuItem;
    }
}

