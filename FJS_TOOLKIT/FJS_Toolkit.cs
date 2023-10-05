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

namespace FJS_TOOLKIT
{
    public partial class FJS_Toolkit : Form
    {
        public FJS_Toolkit()
        {
            InitializeComponent();
            LoadLog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        bool isFirstLoad = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (PreAerial.Checked)
            {
                if (isFirstLoad)
                {
                    logTextBox.Text = "";
                    isFirstLoad = false;
                }
                string[] folderNames = folderNameTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] subdirectories = { "Project Info", "Processed Application" };

                try
                {
                    // Get the directory where the executable is located
                    string executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                    foreach (string folderName in folderNames)
                    {
                        string folderPath = Path.Combine(executableDirectory, folderName);
                        Directory.CreateDirectory(folderPath);

                        foreach (string subdir in subdirectories)
                        {
                            string subdirectoryPath = Path.Combine(folderPath, subdir);
                            Directory.CreateDirectory(subdirectoryPath);
                        }

                        logTextBox.AppendText($"{ DateTime.Now:yyyy - MM - dd HH: mm: ss} - Created folder named '{folderName}' with Pre-Aerial subdirectories." + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText($"FJS Toolkit - An error occurred: {ex.Message}" + Environment.NewLine);
                }
            }

            if (PostAerial.Checked)
            {
                if (isFirstLoad)
                {
                    logTextBox.Text = "";
                    isFirstLoad = false;
                }
                string[] folderNames = folderNameTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] subdirectories = { "Field Notes", "Inspection Reports", "Pictures", "Project Info" };

                try
                {
                    // Get the directory where the executable is located
                    string executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                    foreach (string folderName in folderNames)
                    {
                        string folderPath = Path.Combine(executableDirectory, folderName);
                        Directory.CreateDirectory(folderPath);

                        foreach (string subdir in subdirectories)
                        {
                            string subdirectoryPath = Path.Combine(folderPath, subdir);
                            Directory.CreateDirectory(subdirectoryPath);
                        }

                        logTextBox.AppendText($"{ DateTime.Now:yyyy - MM - dd HH: mm: ss} - Created folder named '{folderName}' with Post-Aerial subdirectories." + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText($"FJS Toolkit - An error occurred: {ex.Message}" + Environment.NewLine);
                }
            }

            if (MHACC.Checked)
            {
                if (isFirstLoad)
                {
                    logTextBox.Text = "";
                    isFirstLoad = false;
                }
                string[] folderNames = folderNameTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] subdirectories = { "ARAMIS", "BILLING", "CLA", "KMZ", "MH VAULT ACCESS REQ", "PERMIT", "PROJECT INFO", "REPORT", "TCP", "SUBMITTED", "FIELD NOTES" };

                try
                {
                    // Get the directory where the executable is located
                    string executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                    foreach (string folderName in folderNames)
                    {
                        string folderPath = Path.Combine(executableDirectory, folderName);
                        Directory.CreateDirectory(folderPath);

                        foreach (string subdir in subdirectories)
                        {
                            string subdirectoryPath = Path.Combine(folderPath, subdir);
                            Directory.CreateDirectory(subdirectoryPath);
                        }

                        // Create the ATT subdirectory within the current folder
                        string attSubdirectoryPath = Path.Combine(folderPath, "AT&T");
                        Directory.CreateDirectory(attSubdirectoryPath);

                        // Create the NTP subdirectory within the ATT subdirectory
                        string ntpSubdirectoryPath = Path.Combine(attSubdirectoryPath, "NTP");
                        Directory.CreateDirectory(ntpSubdirectoryPath);

                        logTextBox.AppendText($"{ DateTime.Now:yyyy - MM - dd HH: mm: ss} - Created folder named '{folderName}' with MH ACC subdirectories." + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText($"FJS Toolkit - An error occurred: {ex.Message}" + Environment.NewLine);
                }
            }

            if (Reports.Checked)
            {
                if (isFirstLoad)
                {
                    logTextBox.Text = "";
                    isFirstLoad = false;
                }
                string[] folderNames = folderNameTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] subdirectories = { "PROJECT INFO", "REPORTS" };

                try
                {
                    // Get the directory where the executable is located
                    string executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                    foreach (string folderName in folderNames)
                    {
                        string folderPath = Path.Combine(executableDirectory, folderName);
                        Directory.CreateDirectory(folderPath);

                        foreach (string subdir in subdirectories)
                        {
                            string subdirectoryPath = Path.Combine(folderPath, subdir);
                            Directory.CreateDirectory(subdirectoryPath);
                        }

                        logTextBox.AppendText($"{ DateTime.Now:yyyy - MM - dd HH: mm: ss} - Created folder named '{folderName}' with REPORT subdirectories." + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText($"FJS Toolkit - An error occurred: {ex.Message}" + Environment.NewLine);
                }
            }
        }

        bool isFirstClick = true;
        private void folderNameTextBox_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                folderNameTextBox.Text = "";
                isFirstClick = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLog();
        }

        private void SaveLog()
        {
            try
            {
                File.WriteAllText("log.txt", logTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving log: {ex.Message}");
            }
        }

        private void LoadLog()
        {
            try
            {
                if (File.Exists("log.txt"))
                {
                    logTextBox.Text += File.ReadAllText("log.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading log: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FJS_PDF_2_JPG secondForm = new FJS_PDF_2_JPG();
            secondForm.Show();
        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
