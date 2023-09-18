using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;


namespace BackupChecker.UserControls
{
    public partial class UC_Help : UserControl
    {
        public UC_Help()
        {
            InitializeComponent();

            version.Text = "1.0.5";
        }

        private void check_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            bool x = webClient.DownloadString("https://github.com/jogonowski297/BackupChecker2.0/blob/master/README.md").Contains("1.0.5");

            if (!x)
            {
                MessageBox.Show("w IF");
                if (MessageBox.Show("New update available! Do you want to install it?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(@".\BackupCheckerSetup.msi")) { File.Delete(@".\BackupCheckerSetup.msi"); }
                        client.DownloadFile("https://github.com/jogonowski297/BackupChecker2.0/releases/download/Update/BackupCheckerSetup.zip", @"BackupCheckerSetup.zip");
                        string zipPath = @".\BackupCheckerSetup.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = String.Format("/i BackupCheckerSetup.msi");

                        process.Start();
                    }
                    catch
                    {

                    }

                }
            }
        }
    }
}
