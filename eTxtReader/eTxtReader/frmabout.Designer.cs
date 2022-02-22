namespace eTxtReader
{
    partial class frmabout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmabout));
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.LinkLabel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblBookTitle.Location = new System.Drawing.Point(46, 33);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(222, 38);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "<book-title>";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(51, 84);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(113, 25);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "<book-ver>";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(52, 130);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(143, 22);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "<book-Author>";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.LinkColor = System.Drawing.Color.MediumOrchid;
            this.lblUrl.Location = new System.Drawing.Point(52, 186);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(69, 20);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.TabStop = true;
            this.lblUrl.Text = "<url>";
            this.lblUrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblUrl_MouseClick);
            this.lblUrl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblUrl_MouseMove);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(432, 270);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(104, 47);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "OK";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // PicIcon
            // 
            this.PicIcon.Image = ((System.Drawing.Image)(resources.GetObject("PicIcon.Image")));
            this.PicIcon.Location = new System.Drawing.Point(465, 33);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(62, 57);
            this.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIcon.TabIndex = 5;
            this.PicIcon.TabStop = false;
            // 
            // frmabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 329);
            this.Controls.Add(this.PicIcon);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmabout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmabout_FormClosing);
            this.Load += new System.EventHandler(this.frmabout_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmabout_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel lblUrl;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.PictureBox PicIcon;
    }
}