using System;
using System.Text.Json;
using VirusHelperLib;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Policy;
using System.IO;
using System.Text;

namespace WinFormsApp1
{
    public partial class Application : Form
    {
        private VirusTotalService _virusTotalService;
        private VirusTotalScanner _virusTotalScanner;

        public Application()
        {
            InitializeComponent();

            _virusTotalService = new VirusTotalService();
            _virusTotalScanner = new VirusTotalScanner();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            if (ApiKeyManager.GetApiKey() == null || ApiKeyManager.GetApiKey() == "")
            {
                apiKeyPanel.Visible = true;
            }
        }

        private void apiPanelLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.virustotal.com/gui/my-apikey",
                UseShellExecute = true
            });
        }

        private void apiKeyPanelButton_Click(object sender, EventArgs e)
        {
            ApiKeyManager.SetApiKey(apiKeyPanelTextBox.Text);

            apiKeyPanel.Visible = false;
        }

        private async void linkScanButton_Click(object sender, EventArgs e)
        {
            string url = linkAnalyseTextBox.Text;

            if (url == null || url == "")
            {
                MessageBox.Show("Please input a link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var urlReport = await _virusTotalService.GetUrlScanReportAsync(url);

                    var response = _virusTotalScanner.DeserializeJsonResponse(urlReport.GetRawText());
                    DisplayScanResult(response, reportTextBox);

                    linkPanel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void fileAnalyseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = selectFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = selectFileDialog.FileName;

                try
                {
                    var fileReport = await _virusTotalService.GetFileReportAsync(filePath);

                    var response = _virusTotalScanner.DeserializeJsonResponse(fileReport.GetRawText());
                    DisplayScanResult(response, reportTextBox);

                    linkPanel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButtonLink_Click(object sender, EventArgs e)
        {
            linkPanel.Visible = false;
        }

        private void gitHubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Asmosd/VirusTotalHelper",
                UseShellExecute = true
            });
        }

        private void addNewAPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apiKeyPanel.Visible = true;
        }

        public void DisplayScanResult(VirusTotalResponse response, RichTextBox richTextBox)
        {
            if (response.response_code == 0)
            {
                richTextBox.Text = "Not in database";
            }
            else if (response.positives == 0)
            {
                richTextBox.Text = "File/Url clean";
            }
            else
            {
                var message = new StringBuilder();
                message.AppendLine($"Number of positives: {response.positives}");
                message.AppendLine("Scans:");

                foreach (var scan in response.scans)
                {
                    message.AppendLine($"{scan.Key}: {scan.Value.result}");
                }

                richTextBox.Text = message.ToString();
            }
        }

        private void foundAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Asmosd/VirusTotalHelper/issues",
                UseShellExecute = true
            });
        }
    }
}
