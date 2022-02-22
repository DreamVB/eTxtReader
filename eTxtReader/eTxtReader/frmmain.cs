using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilePackNET;
using System.IO;

namespace eTxtReader
{
    public partial class frmmain : Form
    {
        private FilePackNET.bjPak book = null;
        private string ExtractTemp = string.Empty;
        private List<string> TempFiles = new List<string>();

        public frmmain()
        {
            InitializeComponent();
            webV.IsWebBrowserContextMenuEnabled = false;
            webV.ContextMenuStrip = mnuWEB;
            webV.ScriptErrorsSuppressed = true;
            webV.WebBrowserShortcutsEnabled = false;
            webV.TabStop = false;
        }
        #region File Stuff
        private string FixPath(string Path)
        {
            if (Path.EndsWith("\\"))
                return Path;
            return Path + "\\";
        }

        private void RemoveTempFiles()
        {
            int count = 0;
            string lzFile = string.Empty;

            while (count < TempFiles.Count())
            {
                lzFile = TempFiles[count];

                if (File.Exists(lzFile))
                {
                    try
                    {
                        File.Delete(lzFile);
                    }
                    catch
                    {

                    }
                }
                count++;
            }
            //Delete the temp folder.
            if (Directory.Exists(ExtractTemp))
            {
                Directory.Delete(ExtractTemp);
            }
            //Clear temp file list
            TempFiles.Clear();
        }

        private void CreateExtractPath()
        {
            string s0 = Path.GetRandomFileName();

            ExtractTemp = Path.GetTempPath() + s0;

            if (!Directory.Exists(ExtractTemp))
            {
                Directory.CreateDirectory(ExtractTemp);
            }
        }

        private void ExtractAllPages()
        {
            CreateExtractPath();

            string lzFile = string.Empty;
            int count = 0;

            while (count < book.FileCount)
            {
                //Get filename
                lzFile = FixPath(ExtractTemp) + book.GetFile(count).Filename;
                //Store into the temp list obj
                TempFiles.Add(lzFile);
                try
                {
                    //Write each file to the extact temp path
                    File.WriteAllBytes(lzFile, book.GetFile(count).data);
                    //Get file ext
                    string lzExt = new FileInfo(lzFile).Extension.ToUpper();
                    //We want to add webpages to the treeview so we check the files ext
                    if (lzExt.Equals(".HTML") || lzExt.Equals(".HTM"))
                    {
                        //Make new treenode
                        TreeNode tn = new TreeNode();
                        //Set the treenode text to the book page name
                        tn.Text = book.GetFile(count).PageName;
                        //Set image
                        tn.ImageIndex = 1;
                        //Set select image
                        tn.SelectedImageIndex = 1;
                        //Set the node tag to the filename
                        tn.Tag = lzFile;
                        //Add node to treeview
                        tvContents.Nodes[0].Nodes.Add(tn);
                    }
                }
                catch
                {

                }
                //INC Counter
                count++;
            }
            //Clear book
            book.ClearFiles();
        }
        #endregion

        private void LoadPage(int Index)
        {
            string lzFile = string.Empty;
            //Get the page to load
            lzFile = (string)tvContents.SelectedNode.Tag;
            //Show in web broswer
            webV.Navigate(lzFile);
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            //Get command line args
            string[] lzFile = Environment.GetCommandLineArgs();

            string lzBookInfo = string.Empty;

            if (lzFile.Length <= 1)
            {
                MessageBox.Show("No File Nound.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                //Set broswer to blank page
                webV.Url = new Uri("about:blank");

                book = new bjPak();
                //Open package file.
                book.OpenPack(lzFile[1]);
                //Extract all pages in the package file.
                ExtractAllPages();
                //Clear string array
                Array.Clear(lzFile, 0, lzFile.Length);
                //Load book info
                lzBookInfo = FixPath(ExtractTemp) + "main.info";

                if (!File.Exists(lzBookInfo))
                {
                    MessageBox.Show("Cannot Load Book Info.",Text,
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }

                cBookInfo.BookFolder = FixPath(ExtractTemp);
                cBookInfo.LoadBookInfo(cBookInfo.BookFolder + "main.info");
                //Set caption with book title.
                this.Text = cBookInfo.BookTitle;
                mnuAbout.Text = "&About" + cBookInfo.BookTitle + "...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void tvContents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((string)e.Node.Tag != "M_TOP")
            {
                LoadPage(e.Node.Index);
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            mnuCopy1_Click(sender, e);
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            mnuSelectAll1_Click(sender, e);
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (book != null)
            {
                //Remove the books files from temp
                RemoveTempFiles();
            }
        }

        private void frmmain_Shown(object sender, EventArgs e)
        {
            if (tvContents.Nodes[0].Nodes.Count > 0)
            {
                TreeNode tn = tvContents.Nodes[0].Nodes[0];
                tvContents.SelectedNode = tn;
                tvContents.Focus();
            }
        }

        private void mnuSelectAll1_Click(object sender, EventArgs e)
        {
            try
            {
                this.webV.Document.ExecCommand("SelectAll", false, (object)null);
            }
            catch
            {

            }
        }

        private void mnuCopy1_Click(object sender, EventArgs e)
        {
            try
            {
                this.webV.Document.ExecCommand("Copy", false, (object)null);
            }
            catch
            {

            }
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            try
            {
                webV.Focus();
                SendKeys.Send("^f");
            }
            catch
            {

            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.ShowDialog();
        }

        private void mnuZoomIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.webV.Focus();
                SendKeys.SendWait("^=");
            }
            catch
            {

            }
        }

        private void mnuZoomOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.webV.Focus();
                SendKeys.SendWait("^-");
            }
            catch
            {

            }
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.webV.Document.ExecCommand("Print", false, (object)null);
            }
            catch
            {

            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPrint1_Click(object sender, EventArgs e)
        {
            mnuPrint_Click(sender, e);
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            if (tvContents.Nodes[0].Nodes.Count > 0)
            {
                TreeNode tn = tvContents.Nodes[0].Nodes[0];
                tvContents.SelectedNode = tn;
                tvContents.Focus();
            }
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            webV.Stop();
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            webV.Refresh();
        }
    }
}
