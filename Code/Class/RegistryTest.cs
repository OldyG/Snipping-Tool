using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Capture
{
    class RegistryTest
    {
        RegistryKey reg1;
        String sectionName;

        public RegistryTest()
        {
            reg1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            sectionName = "Capture";
        }

        /*
         Exception
         * -System.UnauthorizedAccessException
         */
        public int chkExist()   //0 존재하지 않음, 1 존재하지만 주소가 손상됨, 2 정상적으로잇슴
        {
            object temp = reg1.GetValue(sectionName);
            if (temp == null) return 0;
            else if (reg1.GetValue(sectionName, "").ToString() != "\""+System.Reflection.Assembly.GetExecutingAssembly().Location+"\"")
                return 1;
            else
                return 2;
        }

        public bool regInsert()
        {
            bool flag = false;
            try
            {
                reg1.SetValue(sectionName, "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"",RegistryValueKind.String);
                flag = true;
            }
            catch (UnauthorizedAccessException e)
            {
                String msg = "[ExeptionMsg : " + e.Message+"]";
                msg += "\n\n혹시 보안 프로그램을 켜놓으셨나요?";
                msg += "\n시작 프로그램으로 등록하시려면 잠시 꺼놓으시길 바랍니다!";
                msg += "\n보안 프로그램을 정상 종료하셨다면 \'확인\'를, \n작업을 그만 두시려면 \'취소\'를 선택해주세염";

                if (MessageBox.Show(msg, "캡쳐도구 알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    regInsert();
                }
                else
                { 
                    MessageBox.Show("시작프로그램등록을 취소합니다","캡쳐도구 알림");
                    flag = false;
                }
                
            }
            //MessageBox.Show(flag.ToString());
            return flag;
        }
        public void regRemove()
        {
            if(chkExist()!=0)
            reg1.DeleteValue(sectionName);
            
        }
    }
}
