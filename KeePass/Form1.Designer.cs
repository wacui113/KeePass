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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Windows");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Networking");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Email");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Homebanking");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.Addtsitem = new System.Windows.Forms.ToolStripButton();
            this.Edittsitem = new System.Windows.Forms.ToolStripButton();
            this.Deletetsitem = new System.Windows.Forms.ToolStripButton();
            this.MainListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trv_ImgL = new System.Windows.Forms.ImageList(this.components);
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.ListView_ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.ListView_ctms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
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
            this.Edittsitem.Click += new System.EventHandler(this.Edittsitem_Click);
            // 
            // Deletetsitem
            // 
            this.Deletetsitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deletetsitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Deletetsitem.Image = ((System.Drawing.Image)(resources.GetObject("Deletetsitem.Image")));
            this.Deletetsitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetsitem.Name = "Deletetsitem";
            this.Deletetsitem.Size = new System.Drawing.Size(23, 22);
            this.Deletetsitem.Text = "Delete";
            this.Deletetsitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Deletetsitem.Click += new System.EventHandler(this.Deletetsitem_Click);
            // 
            // MainListView
            // 
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Username,
            this.Password,
            this.URL,
            this.Note});
            this.MainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainListView.FullRowSelect = true;
            this.MainListView.Location = new System.Drawing.Point(0, 0);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(878, 624);
            this.MainListView.SmallImageList = this.trv_ImgL;
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
            // trv_ImgL
            // 
            this.trv_ImgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trv_ImgL.ImageStream")));
            this.trv_ImgL.TransparentColor = System.Drawing.Color.Transparent;
            this.trv_ImgL.Images.SetKeyName(0, "database.png");
            this.trv_ImgL.Images.SetKeyName(1, "general.png");
            this.trv_ImgL.Images.SetKeyName(2, "windows.png");
            this.trv_ImgL.Images.SetKeyName(3, "network.jpg");
            this.trv_ImgL.Images.SetKeyName(4, "internet.png");
            this.trv_ImgL.Images.SetKeyName(5, "email.png");
            this.trv_ImgL.Images.SetKeyName(6, "homebanking.png");
            // 
            // MainTreeView
            // 
            this.MainTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.MainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.ImageIndex = 0;
            this.MainTreeView.ImageList = this.trv_ImgL;
            this.MainTreeView.Indent = 30;
            this.MainTreeView.ItemHeight = 34;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "General";
            treeNode1.Text = "General";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Windows";
            treeNode2.Text = "Windows";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "Networking";
            treeNode3.Text = "Networking";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "Internet";
            treeNode4.Text = "Internet";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "Email";
            treeNode5.Text = "Email";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "Homebanking";
            treeNode6.Text = "Homebanking";
            treeNode7.Name = "Database";
            treeNode7.Text = "Database";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.MainTreeView.RightToLeftLayout = true;
            this.MainTreeView.SelectedImageIndex = 0;
            this.MainTreeView.ShowLines = false;
            this.MainTreeView.Size = new System.Drawing.Size(202, 624);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseClick);
            // 
            // ListView_ctms
            // 
            this.ListView_ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ListView_ctms.Name = "contextMenuStrip1";
            this.ListView_ctms.Size = new System.Drawing.Size(108, 70);
            this.ListView_ctms.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainListView);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 624);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 673);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeePass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ListView_ctms.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList trv_ImgL;
    }
}

