using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace DownloadVideoYoutubeTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string uri = txtLink.Text;
            int index = cobResolution.SelectedIndex;

            if (!String.IsNullOrEmpty(uri) && index != 0)
            {
                try
                {
                    /*btn_download.Hide();
                    txtLink.Enabled = false;
                    cobResolution.Enabled = false;

                    var youtube = YouTube.Default;
                    var videos = youtube.GetAllVideos(uri);
                    var video = videos.FirstOrDefault(x => x.Resolution == Convert.ToInt32(cobResolution.Text));
                    var client = new HttpClient();
                    long? totalByte = 0;
                    using (Stream output = File.OpenWrite($"D:\\video{DateTime.Now.ToString("ddMMyyyyhhmmss")}.mp4"))
                    {
                        using (var request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
                        {
                            totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                        }
                        using (var input = await client.GetStreamAsync(video.Uri))
                        {
                            byte[] buffer = new byte[16 * 1024];
                            int read;
                            int totalRead = 0;
                            lblPercent.Text = "Download Started";
                            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, read);
                                totalRead += read;
                                lblPercent.Text = $"\rDownloading {totalRead}/{totalByte} ...";
                            }
                            lblPercent.Text = "Download Complete";
                        }
                    }

                    btn_download.Show();
                    txtLink.Enabled = true;
                    lblPercent.Text = "";
                    cobResolution.Enabled = true;*/

                    Download(uri);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_download.Show();
                    lblPercent.Text = "";
                    txtLink.Enabled = true;
                    cobResolution.Enabled = true;
                }
            }
        }

        private void Download(string uri)
        {
            using (var service = Client.For(YouTube.Default))
            {
                btn_download.Hide();
                txtLink.Enabled = false;
                cobResolution.Enabled = false;

                string path = $"D:\\video{DateTime.Now.ToString("ddMMyyyyhhmmss")}.mp4";
                lblPercent.Text = "Awesome! Downloading";
                var videos = service.GetAllVideos(uri);
                var video = videos.FirstOrDefault(v => v.Resolution == Convert.ToInt32(cobResolution.Text));
                lblPercent.Text = "Saving";
                File.WriteAllBytes(path, video.GetBytes());

                btn_download.Show();
                txtLink.Enabled = true;
                lblPercent.Text = "";
                cobResolution.Enabled = true;

                MessageBox.Show("Successfully Downloaded !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void empty_btn_Click(object sender, EventArgs e)
        {
            txtLink.Text = "";
            cobResolution.SelectedIndex = 0;
        }
    }
}
