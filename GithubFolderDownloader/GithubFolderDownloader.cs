using HtmlAgilityPack;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace GithubFolderDownloader
{
    public partial class GithubFolderDownloader : Form
    {
        public GithubFolderDownloader()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())  if (folder.ShowDialog() == DialogResult.OK) FolderLink.Text = folder.SelectedPath;
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            CanCel = false;
            this.BeginInvoke((MethodInvoker)delegate {
                if (backgroundWorker1.IsBusy != true) backgroundWorker1.RunWorkerAsync();
            });
        }
        void Crawl(string URL)
        {
            if (CanCel) return; 
            HtmlNodeCollection link = new HtmlWeb().Load(URL).DocumentNode.SelectNodes("//a[@href]");
            for (int i = 0; i < link.Count; i++)
            {
                var href = link[i].Attributes["href"].Value;
                if ((href.Contains("/tree/master/") || href.Contains("/tree/main/")) && URL.Length < ("http://github.com" + href).Length) Crawl("http://github.com" + href);
                
                else if (href.Contains("/blob/master/") || href.Contains("/blob/main/"))
                {
                    string toBeSearched = new Uri(FolderLink.Text).Segments.Last();
                    string dir = (toBeSearched + href.Substring(href.IndexOf(toBeSearched) + toBeSearched.Length)).Replace("/blob/master/", "/").Replace("/blob/main/", "/").Replace("%20"," ");
                    var Link = ("http://github.com" + href).Replace("github.com", "raw.githubusercontent.com").Replace("/blob/master/", "/master/").Replace("/blob/main/", "/main/");
                    if (!Directory.Exists(Path.Combine(FolderPath.Text, dir))) Directory.CreateDirectory(Path.Combine(FolderPath.Text, dir.Replace(new Uri(Link).Segments.Last(), "")));
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(new Uri(Link), Path.Combine(FolderPath.Text, dir));
                        Status.Text = dir;
                    }
                }
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("config.txt",FolderPath.Text + "\n" + FolderLink.Text);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            if (File.Exists("config.txt"))
            {
                 string[] config = File.ReadAllText("config.txt").Split('\n'); ;
                 FolderPath.Text = config[0];
                 FolderLink.Text = config[1];
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             BackgroundWorker worker = sender as BackgroundWorker;
             if (worker.CancellationPending == true) e.Cancel = true;
             else
             {
                Cancel.Enabled = true;
                Download_btn.Enabled = false;
                Crawl(FolderLink.Text);
             }
        }
        bool CanCel = false;
        private void Cancel_Click(object sender, EventArgs e)
        {
            CanCel = true;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                Cancel.Enabled = false;
                Download_btn.Enabled = true;
                Status.Text = "Status : " +  (CanCel ? "Canceled" : "Done") + " !";
            });
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://github.com/graysuit/GithubFolderDownloader");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://html-agility-pack.net/");
        }
    }
}
