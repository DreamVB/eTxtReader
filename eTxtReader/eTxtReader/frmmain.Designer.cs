namespace eTxtReader
{
    partial class frmmain
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Book");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.spl1 = new System.Windows.Forms.SplitContainer();
            this.sTabBook = new System.Windows.Forms.TabControl();
            this.TabContents = new System.Windows.Forms.TabPage();
            this.tvContents = new System.Windows.Forms.TreeView();
            this.ImgLst1 = new System.Windows.Forms.ImageList(this.components);
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.webV = new System.Windows.Forms.WebBrowser();
            this.mnuWEB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).BeginInit();
            this.spl1.Panel1.SuspendLayout();
            this.spl1.Panel2.SuspendLayout();
            this.spl1.SuspendLayout();
            this.sTabBook.SuspendLayout();
            this.TabContents.SuspendLayout();
            this.mnuWEB.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(210, 30);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy,
            this.toolStripSeparator1,
            this.mnuSelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(230, 30);
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSelectAll.Size = new System.Drawing.Size(230, 30);
            this.mnuSelectAll.Text = "Select &All";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 29);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(117, 30);
            this.mnuAbout.Text = "#0";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // spl1
            // 
            this.spl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl1.Location = new System.Drawing.Point(0, 33);
            this.spl1.Name = "spl1";
            // 
            // spl1.Panel1
            // 
            this.spl1.Panel1.Controls.Add(this.sTabBook);
            // 
            // spl1.Panel2
            // 
            this.spl1.Panel2.Controls.Add(this.webV);
            this.spl1.Size = new System.Drawing.Size(799, 491);
            this.spl1.SplitterDistance = 266;
            this.spl1.TabIndex = 2;
            // 
            // sTabBook
            // 
            this.sTabBook.Controls.Add(this.TabContents);
            this.sTabBook.Controls.Add(this.tabSearch);
            this.sTabBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTabBook.Location = new System.Drawing.Point(0, 0);
            this.sTabBook.Name = "sTabBook";
            this.sTabBook.SelectedIndex = 0;
            this.sTabBook.Size = new System.Drawing.Size(266, 491);
            this.sTabBook.TabIndex = 0;
            // 
            // TabContents
            // 
            this.TabContents.Controls.Add(this.tvContents);
            this.TabContents.Location = new System.Drawing.Point(4, 29);
            this.TabContents.Name = "TabContents";
            this.TabContents.Padding = new System.Windows.Forms.Padding(3);
            this.TabContents.Size = new System.Drawing.Size(258, 458);
            this.TabContents.TabIndex = 0;
            this.TabContents.Text = "Contents";
            this.TabContents.UseVisualStyleBackColor = true;
            // 
            // tvContents
            // 
            this.tvContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvContents.ImageIndex = 0;
            this.tvContents.ImageList = this.ImgLst1;
            this.tvContents.Location = new System.Drawing.Point(3, 3);
            this.tvContents.Name = "tvContents";
            treeNode2.Name = "Node0";
            treeNode2.Tag = "M_TOP";
            treeNode2.Text = "Book";
            this.tvContents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvContents.SelectedImageIndex = 0;
            this.tvContents.Size = new System.Drawing.Size(252, 452);
            this.tvContents.TabIndex = 0;
            this.tvContents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvContents_AfterSelect);
            // 
            // ImgLst1
            // 
            this.ImgLst1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst1.ImageStream")));
            this.ImgLst1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst1.Images.SetKeyName(0, "home.png");
            this.ImgLst1.Images.SetKeyName(1, "page.png");
            // 
            // tabSearch
            // 
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(258, 458);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // webV
            // 
            this.webV.ContextMenuStrip = this.mnuWEB;
            this.webV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webV.Location = new System.Drawing.Point(0, 0);
            this.webV.MinimumSize = new System.Drawing.Size(20, 20);
            this.webV.Name = "webV";
            this.webV.Size = new System.Drawing.Size(529, 491);
            this.webV.TabIndex = 0;
            // 
            // mnuWEB
            // 
            this.mnuWEB.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuWEB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy1,
            this.mnuSelectAll1,
            this.toolStripSeparator2,
            this.mnuFind,
            this.toolStripSeparator3,
            this.mnuPrint,
            this.toolStripSeparator4,
            this.mnuZoomIn,
            this.mnuZoomOut});
            this.mnuWEB.Name = "mnuWEB";
            this.mnuWEB.Size = new System.Drawing.Size(236, 202);
            // 
            // mnuCopy1
            // 
            this.mnuCopy1.Name = "mnuCopy1";
            this.mnuCopy1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy1.Size = new System.Drawing.Size(235, 30);
            this.mnuCopy1.Text = "Copy";
            this.mnuCopy1.Click += new System.EventHandler(this.mnuCopy1_Click);
            // 
            // mnuSelectAll1
            // 
            this.mnuSelectAll1.Name = "mnuSelectAll1";
            this.mnuSelectAll1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSelectAll1.Size = new System.Drawing.Size(235, 30);
            this.mnuSelectAll1.Text = "Select All";
            this.mnuSelectAll1.Click += new System.EventHandler(this.mnuSelectAll1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFind.Size = new System.Drawing.Size(235, 30);
            this.mnuFind.Text = "Find";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(235, 30);
            this.mnuPrint.Text = "Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // mnuZoomIn
            // 
            this.mnuZoomIn.Name = "mnuZoomIn";
            this.mnuZoomIn.ShortcutKeyDisplayString = "Ctrl + +";
            this.mnuZoomIn.Size = new System.Drawing.Size(235, 30);
            this.mnuZoomIn.Text = "Zoom In";
            this.mnuZoomIn.Click += new System.EventHandler(this.mnuZoomIn_Click);
            // 
            // mnuZoomOut
            // 
            this.mnuZoomOut.Name = "mnuZoomOut";
            this.mnuZoomOut.ShortcutKeyDisplayString = "Ctrl + -";
            this.mnuZoomOut.Size = new System.Drawing.Size(235, 30);
            this.mnuZoomOut.Text = "Zoom Out";
            this.mnuZoomOut.Click += new System.EventHandler(this.mnuZoomOut_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrint1,
            this.mnuHome,
            this.mnuStop,
            this.mnuRefresh});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // mnuPrint1
            // 
            this.mnuPrint1.Name = "mnuPrint1";
            this.mnuPrint1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint1.Size = new System.Drawing.Size(210, 30);
            this.mnuPrint1.Text = "&Print...";
            this.mnuPrint1.Click += new System.EventHandler(this.mnuPrint1_Click);
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuHome.Size = new System.Drawing.Size(210, 30);
            this.mnuHome.Text = "&Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(210, 30);
            this.mnuStop.Text = "&Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(210, 30);
            this.mnuRefresh.Text = "&Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 546);
            this.Controls.Add(this.spl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eTxt Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.Shown += new System.EventHandler(this.frmmain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spl1.Panel1.ResumeLayout(false);
            this.spl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).EndInit();
            this.spl1.ResumeLayout(false);
            this.sTabBook.ResumeLayout(false);
            this.TabContents.ResumeLayout(false);
            this.mnuWEB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.SplitContainer spl1;
        private System.Windows.Forms.TabControl sTabBook;
        private System.Windows.Forms.TabPage TabContents;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TreeView tvContents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ImageList ImgLst1;
        private System.Windows.Forms.WebBrowser webV;
        private System.Windows.Forms.ContextMenuStrip mnuWEB;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll1;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomIn;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomOut;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
    }
}

