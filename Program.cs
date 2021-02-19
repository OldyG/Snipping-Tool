using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security.Principal;
namespace Capture
{
    static class Program
    {
        //이미 실행중이면 보이게 함
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //이미 실행중이면 맨앞으로 오게 함
        [DllImport("user32.dll")]
        public static extern void BringWindowToTop(IntPtr hWnd);
        //이미 실행중이면 포커스 함
        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hWnd);
        //중복실행을 방지함
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private static Mutex mutex;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool ProgramCreated = false;
            mutex = new Mutex(true, "File Sync Manager", out ProgramCreated);
            if (ProgramCreated)
            {
                if (IsAdministrator() == false)
                {
                    try
                    {
                        ProcessStartInfo procInfo = new ProcessStartInfo();
                        procInfo.UseShellExecute = true;
                        procInfo.FileName = Application.ExecutablePath;
                        procInfo.WorkingDirectory = Environment.CurrentDirectory;
                        procInfo.Verb = "runnas";
                        Process.Start(procInfo);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    return;
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                string ProgramName = "캡쳐 도구";
                IntPtr hwnd = FindWindow(null, ProgramName);
                ShowWindow(hwnd, 5);
                SendMessage(hwnd, 10000,0, 0);
                BringWindowToTop(hwnd);
                SetForegroundWindow(hwnd);
                return;
            }
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (null != identity)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return false;
        }
    }
}
