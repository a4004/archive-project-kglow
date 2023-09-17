using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace ROG_INTERFACE_TEST
{
    class Program
    {
        [DllImport(@"C:\Users\Alex\Documents\VS Projects\Hybrid\R0G\Interface\ROG-INTERFACE\x64\Debug\ROG-INTERFACE.dll")]
        private static extern void DoGlow();

        

        static void Main(string[] args)
        {
            Process[] p = Process.GetProcessesByName("csgo");

            if (p.Length > 0)
            {
                foreach (ProcessModule m in p[0].Modules)
                {
                    if (m.ModuleName == "client.dll")
                    {
                        Console.WriteLine(m.BaseAddress);
               
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }

            Console.ReadLine();
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
