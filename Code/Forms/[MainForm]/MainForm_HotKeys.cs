using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Capture
{
    public partial class MainForm
    {
        //핫키생성
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        //핫키제거
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        //이미실행중이면 보이게 하고
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        /// <summary> 윈도우에 지정할 HotKey 목록</summary>
        private void HotKey_Load()
        {
            RegisterHotKey((int)this.Handle, 0, 0x0006, (int)Keys.A);
            // 0x1은 알트, 0x2는 콘트롤, 0x3은 쉬프트
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey((int)this.Handle, 0); //이 폼에 ID가 0인 핫키 해제
        }
        protected override void WndProc(ref Message m) //윈도우프로시저 콜백함수
        {
            base.WndProc(ref m);
            if (m.Msg == (int)0x312) //핫키가 눌러지면 312 정수 메세지를 받게됨
            {
                if (m.WParam == (IntPtr)0x0) // 그 키의 ID가 0이면
                {
                    JobCapture();
                    if(CLASS_DEFAULTOPTION.HotkeyAfterActiveGS==1)ShowWindow(this.Handle, 9);
                }
            }

        }


        /*
        //중복실행 방지
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string hWnd1, string hWnd2);
        //이미실행중이면 화면 맨앞으로오게 하고
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void BringWindowToTop(IntPtr hWnd);
        //이미실행중이면 포커스(Activate)를 준다.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hWnd);*/

    }
}
