using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace Capture
{
    public partial class MainForm
    {
        


        /// <summary>
        /// 호출 시 SaveDialog를 호출 시켜 이미지를 저장합니다.
        /// </summary>
        private void FuncSave()
        {

            if (pictureBox1.Image == null)
            {
                MSG_USE("캡쳐작업 후 가능합니다");
                return;
            }


            SaveFileDialog SAVE_DIALOG = new SaveFileDialog();

            string defaultFileName = CLASS_DEFAULTOPTION.SavedOption_NameGS;

            SAVE_DIALOG.DefaultExt = CLASS_DEFAULTOPTION.SavedOption_ExtensionGS;
            SAVE_DIALOG.FileName = defaultFileName;
            SAVE_DIALOG.InitialDirectory = Path.GetDirectoryName(CLASS_DEFAULTOPTION.SavedOption_FullPathGS);
            SAVE_DIALOG.Filter = "JPEG 파일(*.jpg)|*.jpg|비트맵(*bmp)|*bmp|PNG 파일(*.png)|*.png|파일숨기기(*)|*";
            SAVE_DIALOG.FilterIndex = CLASS_DEFAULTOPTION.SavedOption_FilterIndexGS;
            SAVE_DIALOG.ShowHelp = true;
            SAVE_DIALOG.HelpRequest += (b, d) => { MessageBox.Show("ㅋㄷ"); };


            string[] tempfilter = { "", ".jpg", ".bmp", ".png" };
            string fullpath = Path.GetDirectoryName(CLASS_DEFAULTOPTION.SavedOption_FullPathGS) + @"\" + CLASS_DEFAULTOPTION.SavedOption_NameGS + tempfilter[SAVE_DIALOG.FilterIndex];

            FileInfo fileChk = new FileInfo(fullpath);

            for (int cnt = 1; fileChk.Exists; cnt++)
            {
                SAVE_DIALOG.FileName = defaultFileName + cnt.ToString();
                fullpath = Path.GetDirectoryName(CLASS_DEFAULTOPTION.SavedOption_FullPathGS) + @"\" + SAVE_DIALOG.FileName + tempfilter[SAVE_DIALOG.FilterIndex];
                fileChk = new FileInfo(fullpath);
            }

            if (SAVE_DIALOG.ShowDialog() != DialogResult.OK) { return; }

            if (SAVE_DIALOG.FilterIndex == 1) { PRINTSCREEN.Save(SAVE_DIALOG.FileName, ImageFormat.Bmp); }
            else if (SAVE_DIALOG.FilterIndex == 2) { PRINTSCREEN.Save(SAVE_DIALOG.FileName, ImageFormat.Png); }
            else if (SAVE_DIALOG.FilterIndex == 3) { PRINTSCREEN.Save(SAVE_DIALOG.FileName, ImageFormat.Jpeg); }

            MSG_USE("저장되었습니다. [PATH:" + SAVE_DIALOG.FileName + "]");

        }

        public String AutoSavedPath;

        /// <summary>
        /// 호출 시 현재 이미지를 사용자가 정의한 주소에 자동으로 저장합니다.
        /// </summary>
        public void FuncSave_Auto()
        {
            string AutoSaveDirectoryName = "자동저장";
            string tempPath;
            if (CLASS_DEFAULTOPTION.AutoSaveToChildDriectoryGS == 1)
            {
                tempPath = Path.GetDirectoryName(CLASS_DEFAULTOPTION.SavedOption_FullPathGS) + @"\" + AutoSaveDirectoryName + @"\" + CLASS_DEFAULTOPTION.SavedOption_NameGS + "." + CLASS_DEFAULTOPTION.SavedOption_ExtensionGS;
                DirectoryInfo temp = new DirectoryInfo(Path.GetDirectoryName(tempPath));
                if (temp.Exists == false) temp.Create();
            }
            else
                tempPath = CLASS_DEFAULTOPTION.SavedOption_FullPathGS;
            FileInfo fileChk = new FileInfo(tempPath);
            int nameCnt = 1;
            for (nameCnt = 1; fileChk.Exists; nameCnt++)
            {
                tempPath = Path.GetDirectoryName(CLASS_DEFAULTOPTION.SavedOption_FullPathGS) + (CLASS_DEFAULTOPTION.AutoSaveToChildDriectoryGS == 1 ? @"\" + AutoSaveDirectoryName : "") + @"\" + CLASS_DEFAULTOPTION.SavedOption_NameGS + nameCnt + "." + CLASS_DEFAULTOPTION.SavedOption_ExtensionGS;
                fileChk = new FileInfo(tempPath);
            }
            AutoSavedPath = tempPath;
            PRINTSCREEN.Save(tempPath);

            MSG_USE((CLASS_DEFAULTOPTION.using_ClipBoardGS==1?"클립보드 저장 및 " :"")+"자동저장되었습니다　　　　[..." + CLASS_DEFAULTOPTION.SavedOption_DirectoryAdd + @"\" + CLASS_DEFAULTOPTION.SavedOption_NameGS + ((nameCnt - 1).ToString() == "0" ? "" : (nameCnt - 1).ToString()) + "." + CLASS_DEFAULTOPTION.SavedOption_ExtensionGS+"]");
        }






        private void HelpForToolStrip_Click(object sender, EventArgs e)
        {
            CaptureForToolStrip.ToolTipText = null;
        }

    }
}
