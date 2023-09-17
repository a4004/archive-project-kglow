using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtils;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;


namespace ROG_CLIENT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            new Thread(GlowThread).Start();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        private const int cGrip = 16;
        private const int cCaption = 32;
        private const int RESIZE_CODE = 0x84;

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }


        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                cp.Style |= Constants.WS_SYSMENU;

                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Hide();

            systemTray.BalloonTipTitle = "Client Hidden";
            systemTray.BalloonTipText = "R0G Client has been minimised to the system tray.";
            systemTray.ShowBalloonTip(5000);
        }

        private bool AllowedToQuit = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("In order to fully exit, you need to reboot your computer. Would you like to reboot now?", "Reboot Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch(result)
            {
                case DialogResult.Yes:
                    PerformCleanReboot();
                    break;
                case DialogResult.No:
                    this.Hide();
                    systemTray.BalloonTipTitle = "Reboot Required";
                    systemTray.BalloonTipText = "To reboot, right click on my icon and press Clean Reboot.";
                    systemTray.ShowBalloonTip(5000);
                    break;
                default:
                    break;
            }
        }

        private void PerformCleanReboot()
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedToQuit)
                e.Cancel = true;
        }

        private void systemTray_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormUtils.DragWindow(this.Handle);
        }

        [DllImport("ROG-INTERFACE.dll")]
        private static extern ulong ReadMemory(ulong PID, ulong ADDR, int SZ);

        [DllImport("ROG-INTERFACE.dll")]
        private static extern bool WriteMemory(ulong PID, ulong ADDR, ulong VAL);

        [DllImport("ROG-INTERFACE.dll")]
        private static extern int GetProcessID();

        [DllImport("ROG-INTERFACE.dll")]
        private static extern int GetModuleAddress();


        private void GlowThread()
        {
            GlowStruct myTeam = new GlowStruct()
            {
                r = 0,
                g = 0,
                b = 1,
                a = 1,
                rwo = true,
                rwuo = false
            };
            GlowStruct myEnemy = new GlowStruct()
            {
                r = 1,
                g = 0,
                b = 0,
                a = 1,
                rwo = true,
                rwuo = false
            };

            

            while (true)
            {
                try
                {
                    if (Process.GetProcessesByName("csgo").Length > 0)
                    {
                        int address;
                        int i = 1;

                        Offsets.ClientDll = GetModuleAddress();
                        int pid = GetProcessID();

                        if (Offsets.ClientDll > 0)
                        {

                            do
                            {
                                address = Offsets.ClientDll + Offsets.dwLocalPlayer;
                                int Player = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                address = Player + Offsets.m_iTeamNum;
                                int MyTeam = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                address = Offsets.ClientDll + Offsets.dwEntityList + (i - 1) * 0x10;
                                int EntitiyList = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                address = EntitiyList + Offsets.m_iTeamNum;
                                int HisTeam = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                address = EntitiyList + Offsets.m_bDormant;
                                if (!BitConverter.ToBoolean(BitConverter.GetBytes(ReadMemory((ulong)pid, (ulong)address, 1)), 0))
                                {
                                    address = EntitiyList + Offsets.m_iGlowIndex;

                                    int GlowIndex = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                    if (MyTeam == HisTeam)
                                    {
                                        address = Offsets.ClientDll + Offsets.dwGlowObjectManager;
                                        int GlowObject = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                        int calculation = GlowIndex * 0x38 + 0x4;
                                        int current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.r), 0));

                                        calculation = GlowIndex * 0x38 + 0x8;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.g), 0));

                                        calculation = GlowIndex * 0x38 + 0xC;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.b), 0));

                                        calculation = GlowIndex * 0x38 + 0x10;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.a), 0));

                                        calculation = GlowIndex * 0x38 + 0x24;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.rwo), 0));

                                        calculation = GlowIndex * 0x38 + 0x25;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myTeam.rwuo), 0));
                                    }
                                    else
                                    {
                                        address = Offsets.ClientDll + Offsets.dwGlowObjectManager;
                                        int GlowObject = (int)ReadMemory((ulong)pid, (ulong)address, 4);

                                        int calculation = GlowIndex * 0x38 + 0x4;
                                        int current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.r), 0));

                                        calculation = GlowIndex * 0x38 + 0x8;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.g), 0));

                                        calculation = GlowIndex * 0x38 + 0xC;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.b), 0));

                                        calculation = GlowIndex * 0x38 + 0x10;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.a), 0));

                                        calculation = GlowIndex * 0x38 + 0x24;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.rwo), 0));

                                        calculation = GlowIndex * 0x38 + 0x25;
                                        current = GlowObject + calculation;
                                        WriteMemory((ulong)pid, (ulong)current, BitConverter.ToUInt64(BitConverter.GetBytes(myEnemy.rwuo), 0));
                                    }
                                }
                                i++;
                            }
                            while (i < 65);
                        }
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
                catch { }
            }
        }

        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }

        public class Offsets
        {
            public static int ClientDll;

            public static int dwLocalPlayer = 0xD3DBEC;
            public static int m_iTeamNum = 0xF4;
            public static int dwEntityList = 0x4D523EC;
            public static int m_bDormant = 0xED;
            public static int m_iGlowIndex = 0xA438;
            public static int dwGlowObjectManager = 0x529A248;


        }
    }
}
