using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _43938442_ExamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:44322/";

            try
            {
                // Start IIS Express if not running
                StartIISExpress();

                // Delay to ensure IIS Express starts properly
                Thread.Sleep(2000);

                // Prepare the start information
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures it uses the default browser
                };

                // Start the process
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Failed to open URL. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartIISExpress()
        {
            // Define the path to the IIS Express executable
            string iisExpressPath = @"C:\Program Files\IIS Express\iisexpress.exe";

            // Define the path to your project
            string projectPath = @"C:\Users\laura\OneDrive\Desktop\NWU\212\Exam\43938442_Exam_WebApp";

            // Define the port to use
            string port = "44322";

            // Check if IIS Express is already running
            Process[] processes = Process.GetProcessesByName("iisexpress");
            if (processes.Length == 0)
            {
                // Start IIS Express
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = iisExpressPath,
                    Arguments = $"/path:\"{projectPath}\" /port:{port}",
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show new form (frmAdminLogin)
            frmAdminLogin new_form = new frmAdminLogin();
            new_form.Show();
        }
    }
}
