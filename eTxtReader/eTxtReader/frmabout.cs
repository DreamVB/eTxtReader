using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace eTxtReader
{
    public partial class frmabout : Form
    {
        public frmabout()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmabout_Load(object sender, EventArgs e)
        {
            lblBookTitle.Text = cBookInfo.BookTitle;
            lblVersion.Text = "Version: " + cBookInfo.BookVersion;
            lblAuthor.Text = "Author: " + cBookInfo.BookAuthor;
            lblUrl.Text = cBookInfo.Url;

            if (File.Exists(cBookInfo.AboutIcon))
            {
                PicIcon.Image = Image.FromFile(cBookInfo.AboutIcon);
            }
        }

        private void lblUrl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = lblUrl.Text;
                    p.Start();
                    p.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmabout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PicIcon.Image != null)
            {
                PicIcon.Image.Dispose();
            }
        }

        private void lblUrl_MouseMove(object sender, MouseEventArgs e)
        {
            lblUrl.LinkColor = Color.Red;
        }

        private void frmabout_MouseMove(object sender, MouseEventArgs e)
        {
            lblUrl.LinkColor = Color.MediumOrchid;
        }
    }
}
