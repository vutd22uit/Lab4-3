using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true; // Vô hiệu hóa thông báo lỗi script
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            webBrowser.Navigate(url);
        }

        private void btnDownloadHtml_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "downloaded.html");
            DownloadHtml(url, filePath);
        }

        private void btnDownloadResources_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "downloaded_resources");
            DownloadResources(url, folderPath);
        }

        private void DownloadHtml(string url, string filePath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath);
                    MessageBox.Show($"HTML downloaded to {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void DownloadResources(string url, string folderPath)
        {
            try
            {
                Directory.CreateDirectory(folderPath);

                // Sử dụng Html Agility Pack để tải và phân tích HTML
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                // Tìm tất cả các thẻ <img> trong HTML
                var imgNodes = document.DocumentNode.SelectNodes("//img[@src]");

                if (imgNodes == null)
                {
                    MessageBox.Show("No images found.");
                    return;
                }

                foreach (var imgNode in imgNodes)
                {
                    string imgUrl = imgNode.GetAttributeValue("src", "");

                    if (!Uri.IsWellFormedUriString(imgUrl, UriKind.Absolute))
                    {
                        Uri baseUri = new Uri(url);
                        Uri fullUri = new Uri(baseUri, imgUrl);
                        imgUrl = fullUri.ToString();
                    }

                    string fileName = Path.GetFileName(imgUrl);
                    string filePath = Path.Combine(folderPath, fileName);

                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(imgUrl, filePath);
                    }
                }

                MessageBox.Show("Resources downloaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
