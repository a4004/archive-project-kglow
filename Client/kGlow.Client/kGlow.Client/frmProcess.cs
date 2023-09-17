using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace kGlow.Client
{
    public partial class frmProcess : Form
    {
        public frmProcess(Program.JobType jt)
        {
            InitializeComponent();

            switch(jt)
            {
                case Program.JobType.DisableDSE:
                    new Thread(DisableDSE).Start();
                    break;
                case Program.JobType.EnableDSE:
                    new Thread(EnableDSE).Start();
                    break;
                case Program.JobType.StartDriver:
                    new Thread(StartDriver).Start();
                    break;
                case Program.JobType.StartDSEFix:
                    new Thread(StartDSEFix).Start();
                    break;
                case Program.JobType.StopDriver:
                    new Thread(StopDriver).Start();
                    break;
                default:
                    CloseWindow();
                    break;
            }
        }

        private void StartDriver()
        {
            try { Process.Start("sc", "start kGlow_Driver"); CloseWindow(); }
            catch { CloseWindowErr(); }
        }

        private void StopDriver()
        {
            try { Process.Start("sc", "stop kGlow_Driver"); CloseWindow(); }
            catch { CloseWindowErr(); }
        }

        private void StartDSEFix()
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\dsefix.exe");
                Thread.Sleep(3000);
                Process.Start("sc", "start kGlow_Driver");

                CloseWindow();
            }
            catch { CloseWindowErr(); }
        }

        private void DisableDSE()
        {
            try
            {
                Process.Start("bcdedit", "/set testsigning on");
                Process.Start("shutdown", "-r -t 0");

                CloseWindow();
            }
            catch { CloseWindowErr(); }
        }

        private void EnableDSE()
        {
            try
            {
                Process.Start("bcdedit", "/set testsigning off");
                Process.Start("shutdown", "-r -t 0");

                CloseWindow();
            }
            catch { CloseWindowErr(); }
        }

        private void CloseWindow()
        {
            this.Invoke(new Action(() =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }));
        }

        private void CloseWindowErr()
        {
            this.Invoke(new Action(() =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }));
        }
    }
}
