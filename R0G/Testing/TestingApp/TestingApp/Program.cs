using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TestingApp
{
    class Program
    {
        [DllImport("C:\\Users\\Alex\\Documents\\VS Projects\\Hybrid\\R0G\\Testing\\ROG-INTERFACE.dll")]
        private static extern ulong ReadMemory(ulong PID, ulong ADDR, int SZ);

        [DllImport("C:\\Users\\Alex\\Documents\\VS Projects\\Hybrid\\R0G\\Testing\\ROG-INTERFACE.dll")]
        private static extern bool WriteMemory(ulong PID, ulong ADDR, ulong VAL);

        [DllImport("C:\\Users\\Alex\\Documents\\VS Projects\\Hybrid\\R0G\\Testing\\ROG-INTERFACE.dll")]
        private static extern int GetProcessID();

        [DllImport("C:\\Users\\Alex\\Documents\\VS Projects\\Hybrid\\R0G\\Testing\\ROG-INTERFACE.dll")]
        private static extern int GetModuleAddress();

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        const int PROCESS_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;
        static unsafe void Main(string[] args)
        {
            Console.WriteLine(ReadMemory(14000, 0x00EFF7FC, 4)); 

            WriteMemory(14000, 0x00EFF7FC, Convert.ToUInt32(666));

            Console.Read();
        }
    }
}
