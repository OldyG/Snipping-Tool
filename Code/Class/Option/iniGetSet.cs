using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Capture
{
    public class iniGetSet
    {
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);


        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        // INI 값 읽기
        public String GetIniValue(String Section, String Key, String iniPath)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, iniPath);

            return temp.ToString();
        }

        // INI 값 설정
        public void SetIniValue(String Section, String Key, String Value, String iniPath)
        {
            WritePrivateProfileString(Section, Key, Value, iniPath);
        }
    }
}
