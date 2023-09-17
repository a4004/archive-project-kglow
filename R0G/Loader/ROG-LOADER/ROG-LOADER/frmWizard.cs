using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace ROG_LOADER
{
    public partial class frmWizard : Form
    {
        private bool IsDone = false;

        public frmWizard()
        {
            InitializeComponent();
        }

        private int TimeLeft = 30;
        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            if(TimeLeft == 0)
            {
                btnAccept.Enabled = true;
                btnAccept.Text = "Accept";
                buttonTimer.Enabled = false;
            }
            else
            {
                btnAccept.Text = $"Accept ({TimeLeft})";
            }

            TimeLeft--;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have declined to the License Agreement. You cannot use Ring0Glow.", "LA Declined", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            IsDone = true;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            pnlInstall.BringToFront();
            new Thread(InstallNow).Start();
        }

        private void frmWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsDone)
            {
                var result = MessageBox.Show("Setup has not completed. Are you sure you want to exit?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void UpdateProgress(string text, int value)
        {
            this.Invoke(new Action(() =>
            {
                lblStatus.Text = text;
                progressBar.Value = value;
            }));
        }

        private void InstallNow()
        {
            UpdateProgress("Preparing...", 5);
            // Extract Files;

            Thread.Sleep(1000);

            UpdateProgress("Creating VAC-Proof Partition...", 20);
            // Make Partition;

            Thread.Sleep(1000);

            UpdateProgress("Copying Files...", 25);
            // Copy Files Over;

            Thread.Sleep(1000);

            UpdateProgress("Morphing Binary...", 30);
            // Morph The Binary;

            Thread.Sleep(1000);

            UpdateProgress("Installing Driver...", 50);
            // Install Driver;

            Thread.Sleep(1000);

            UpdateProgress("Writing Startup Entries...", 60);
            // Add App to startup entry

            Thread.Sleep(1000);

            UpdateProgress("Disabling Driver Signature Enforcement...", 75);
            // Enable test mode

            Thread.Sleep(1000);

            UpdateProgress("Requesting Reboot...", 100);
            IsDone = true;
            // Request Reboot


            
        }
    }
}
