using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloaderATK_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;
        private void btn_start_Click(object sender, EventArgs e)
        {
            httpDownloader = new HttpDownloader(txt_url.Text, $"{Application.StartupPath}\\{Path.GetFileName(txt_url.Text)}");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lblpersent.Text = $"{e.Progress.ToString("0.00")} %";
            lbspeed.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lbdownloaded.Text = string.Format("{0} MB/s", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            lblsatus.Text = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblsatus.Text = "Finish !";
                lblpersent.Text = "100 %";
            });
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if(httpDownloader != null)
            httpDownloader.Pause();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }
    }
}
