using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace kGlow.Setup
{
    public partial class frmWz : Form
    {
        public frmWz()
        {
            InitializeComponent();
        }

        public class InstallParams
        {
            public static string InstallDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\kGlow\\";
        }

        private void btnSetDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();

            switch(result)
            {
                case DialogResult.OK:
                    InstallParams.InstallDir = fbd.SelectedPath + "\\";
                    break;
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            timeout.Start();
            lblStep1.ForeColor = Color.Black;
            lblStep2.ForeColor = Color.Blue;

            pnlPrep.BringToFront();
        }

        int times = 2;
        private void timeout_Tick(object sender, EventArgs e)
        {
            times -= 1;

            if(times == 1)
            {
                Directory.CreateDirectory(InstallParams.InstallDir);

                lblStep2.ForeColor = Color.Black;
                lblStep3.ForeColor = Color.Blue;
            }
            else
            {
                timeout.Stop();

  

                var assembly = Assembly.GetExecutingAssembly();
                string res1 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("kGlow.Client.exe"));
                string res2 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("kGlow.Interface.dll"));
                string res3 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("kGlow.Driver.sys"));
                string res4 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("dsefix.exe"));

                using (Stream input = assembly.GetManifestResourceStream(res1))
                using (Stream output = File.Create(InstallParams.InstallDir + "kGlow.Client.exe"))
                    CopyStream(input, output);
                using (Stream input = assembly.GetManifestResourceStream(res2))
                using (Stream output = File.Create(InstallParams.InstallDir + "kGlow.Interface.dll"))
                    CopyStream(input, output);
                using (Stream input = assembly.GetManifestResourceStream(res3))
                using (Stream output = File.Create(InstallParams.InstallDir + "kGlow.Driver.sys"))
                    CopyStream(input, output);
                using (Stream input = assembly.GetManifestResourceStream(res4))
                using (Stream output = File.Create(InstallParams.InstallDir + "dsefix.exe"))
                    CopyStream(input, output);

                Process.Start("sc", $"create kGlow_Driver type=kernel binpath=\"{InstallParams.InstallDir + "kGlow.Driver.sys"}\"");
                pnlDone.BringToFront(); 

                lblStep3.ForeColor = Color.Black;
                lblStep4.ForeColor = Color.Blue;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (chkLaunch.Checked)
                try { Process.Start(InstallParams.InstallDir + "kGlow.Client.exe"); } catch { }

            Environment.Exit(0);
        }

        private void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8192];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }
}
