namespace GithubFolderDownloader
{
    partial class GithubFolderDownloader
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
            this.FolderLink = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.Download_btn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Status = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FolderLink
            // 
            this.FolderLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FolderLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderLink.ForeColor = System.Drawing.Color.White;
            this.FolderLink.Location = new System.Drawing.Point(12, 10);
            this.FolderLink.Multiline = true;
            this.FolderLink.Name = "FolderLink";
            this.FolderLink.Size = new System.Drawing.Size(447, 32);
            this.FolderLink.TabIndex = 0;
            this.FolderLink.Text = "https://github.com/graysuit/GithubFolderDownloader ";
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderPath.ForeColor = System.Drawing.Color.White;
            this.FolderPath.Location = new System.Drawing.Point(12, 48);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(397, 28);
            this.FolderPath.TabIndex = 1;
            this.FolderPath.Text = "GithubFolderDownloader";
            // 
            // Browse_btn
            // 
            this.Browse_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Browse_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_btn.ForeColor = System.Drawing.Color.White;
            this.Browse_btn.Location = new System.Drawing.Point(415, 48);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(44, 28);
            this.Browse_btn.TabIndex = 3;
            this.Browse_btn.Text = "+++";
            this.Browse_btn.UseVisualStyleBackColor = false;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // Download_btn
            // 
            this.Download_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Download_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download_btn.ForeColor = System.Drawing.Color.White;
            this.Download_btn.Location = new System.Drawing.Point(12, 95);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(112, 33);
            this.Download_btn.TabIndex = 5;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = false;
            this.Download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.Enabled = false;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(135, 95);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 33);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(9, 144);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(450, 63);
            this.Status.TabIndex = 10;
            this.Status.Text = "Status : Nothing";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Author:graysuit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(92, 221);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Helper:HtmlAgilityPack";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // GithubFolderDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(470, 243);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.FolderLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GithubFolderDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GithubFolderDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderLink;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.Button Cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

