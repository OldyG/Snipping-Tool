using System;
using System.Drawing;
using System.IO;
namespace Capture
{
    /// <summary>
    /// 캡쳐도구 프로젝트의 모든 옵션을 저장하는 클래스
    /// </summary>
    class DefaultOption
    {

        //컨트롤 및 클래스
        private readonly MainForm FRM_MAINFORM;
        private readonly whiteForm FRM_WHITEFORM;
        private readonly SettingForm FRM_SETTINGFORM;
        private readonly SetCapture USER_SETCAPTURE;
        private readonly SetInterFace USER_SETINTERFACE;
        private readonly SetSave USER_SETSAVE;
        private readonly FormOpacity CLASS_FORMOPACITY;
        private readonly ControlMove CLASS_CONTROLMOVE;

        //일반전역변수
        private iniGetSet Setting_ini;
        private string inipath;

        #region/**INTERFACE**/
        private int Using_Tray;                   //트레이를 사용할 것인지
        public int Using_TrayGS
        {
            get { Using_Tray = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EXIT_TRAY", inipath)); return Using_Tray; }
            set { Using_Tray = value; Setting_ini.SetIniValue("INTERFACE", "EXIT_TRAY", Using_Tray.ToString(), inipath); }
        }

        private int ToolStripSize;              //메인폼의 ToolStrip1의 사이즈값저장
        public int ToolStripSizeGS
        {
            get { ToolStripSize = int.Parse(Setting_ini.GetIniValue("INTERFACE", "TOOLSTRIP_SIZE", inipath)); return ToolStripSize; }
            set { ToolStripSize = value; Setting_ini.SetIniValue("INTERFACE", "TOOLSTRIP_SIZE", ToolStripSize.ToString(), inipath); }
        }
        private int[] ToolStrip_BackColor_temp; //메인폼의 ToolStrip1의 배경색 저장
        private Color ToolStrip_BackColor;
        public Color ToolStrip_BackColorGS
        {
            get { ToolStrip_BackColor = colorget(ref ToolStrip_BackColor_temp, ref ToolStrip_BackColor, "INTERFACE", "TOOLSTRIP_BACKCOLOR"); return ToolStrip_BackColor; }
            set { ToolStrip_BackColor = value; colorset(ref ToolStrip_BackColor_temp, ref ToolStrip_BackColor, "INTERFACE", "TOOLSTRIP_BACKCOLOR"); }
        }
        private int Using_Detail;               //사진의 디테일정보를 표시할지 결정
        public int Using_DetailGS
        {
            get { Using_Detail = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_DETAIL", inipath)); return Using_Detail; }
            set { Using_Detail = value; Setting_ini.SetIniValue("INTERFACE", "USING_DETAIL", Using_Detail.ToString(), inipath); }
        }
        private int Using_BackColorChangeForHover;      //이미지에 마우스 오버시 배경색이 변하는지 결정
        public int Using_BackColorChangeForHoverGS
        {
            get { Using_BackColorChangeForHover = int.Parse(Setting_ini.GetIniValue("INTERFACE", "BACKCOLORCHANGEFOR_HOVER", inipath)); return Using_BackColorChangeForHover; }
            set { Using_BackColorChangeForHover = value; Setting_ini.SetIniValue("INTERFACE", "BACKCOLORCHANGEFOR_HOVER", Using_BackColorChangeForHover.ToString(), inipath); }
        }
        private int EffectOpacity;              // 밝기 이펙트를 사용할지 결정
        public int EffectOpacityGS
        {
            get { EffectOpacity = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EFFECT_OPACITY", inipath)); return EffectOpacity; }
            set { EffectOpacity = value; Setting_ini.SetIniValue("INTERFACE", "EFFECT_OPACITY", EffectOpacity.ToString(), inipath); }
        }
        private int EffectControlMove;          // 컨트롤무브 이펙트를 사용할지 결정
        public int EffectControlMoveGS
        {
            get { EffectControlMove = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EFFECT_CONTROL_MOVE", inipath)); return EffectControlMove; }
            set { EffectControlMove = value; Setting_ini.SetIniValue("INTERFACE", "EFFECT_CONTROL_MOVE", EffectControlMove.ToString(), inipath); }
        }
        private int Using_WinReg;
        public int Using_WinRegGS
        {
            get { Using_WinReg = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_WINREG", inipath)); return Using_WinReg; }
            set { Using_WinReg = value; Setting_ini.SetIniValue("INTERFACE", "USING_WINREG", Using_WinReg.ToString(), inipath); }
        }
        private int Using_JobCaptureAfterProgramStart;
        public int Using_JobCaptureAfterProgramStartGS
        {
            get { Using_JobCaptureAfterProgramStart = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_JOBCAPTUREAFTERPROGRAMSTART", inipath)); return Using_JobCaptureAfterProgramStart; }
            set { Using_JobCaptureAfterProgramStart = value; Setting_ini.SetIniValue("INTERFACE", "USING_JOBCAPTUREAFTERPROGRAMSTART", Using_JobCaptureAfterProgramStart.ToString(), inipath); }
        }



        #endregion
        #region/**CAPTURE**/
        private int MouseHalfSpeed;
        public int MouseHalfSpeedGS
        {
            get { MouseHalfSpeed = int.Parse(Setting_ini.GetIniValue("CAPTURE", "MOUSE_HALF_SPEED", inipath)); return MouseHalfSpeed; }
            set { MouseHalfSpeed = value; Setting_ini.SetIniValue("CAPTURE", "MOUSE_HALF_SPEED", MouseHalfSpeed.ToString(), inipath); }
        }

        private int HotkeyAfterActive;      //창이 최소화 되어있을때 핫키작업후 창을 띄울지 결정
        public int HotkeyAfterActiveGS
        {
            get { HotkeyAfterActive = int.Parse(Setting_ini.GetIniValue("CAPTURE", "HOTKEY_AFTER_ACTIVE", inipath)); return HotkeyAfterActive; }
            set { HotkeyAfterActive = value; Setting_ini.SetIniValue("CAPTURE", "HOTKEY_AFTER_ACTIVE", HotkeyAfterActive.ToString(), inipath); }
        }
        private int SleepValue;             //캡쳐화면으로 전환되는 시간 설정
        public int SleepValueGS
        {
            get { SleepValue = int.Parse(Setting_ini.GetIniValue("CAPTURE", "SLEEPVALUE", inipath)); return SleepValue; }
            set { SleepValue = value; Setting_ini.SetIniValue("CAPTURE", "SLEEPVALUE", SleepValue.ToString(), inipath); }
        }
        private int CaptureMode; //0~3      //캡쳐 모드 결정
        public int CaptureModeGS
        {
            get { CaptureMode = int.Parse(Setting_ini.GetIniValue("CAPTURE", "CAPTURE_MODE", inipath)); return CaptureMode; }
            set { CaptureMode = value; Setting_ini.SetIniValue("CAPTURE", "CAPTURE_MODE", CaptureMode.ToString(), inipath); }
        }
        private int Penstroke;              //캡쳐시 사각형의 두께
        public int PenstrokeGS
        {
            get { Penstroke = int.Parse(Setting_ini.GetIniValue("CAPTURE", "PENSTROKE", inipath)); return Penstroke; }
            set { Penstroke = value; Setting_ini.SetIniValue("CAPTURE", "PENSTROKE", Penstroke.ToString(), inipath); }
        }
        private int[] StrokeColor_temp;     //캡쳐시 사각형의 색상
        private Color StrokeColor;
        public Color StrokeColorGS
        {
            get { StrokeColor = colorget(ref StrokeColor_temp, ref StrokeColor, "CAPTURE", "STROKECOLOR"); return StrokeColor; }
            set { StrokeColor = value; colorset(ref StrokeColor_temp, ref StrokeColor, "CAPTURE", "STROKECOLOR"); }
        }
        private int[] WhiteFormColor_temp;  //캡쳐시 배경 색상
        private Color WhiteFormColor;
        public Color WhiteFormColorGS
        {
            get { WhiteFormColor = colorget(ref WhiteFormColor_temp, ref WhiteFormColor, "CAPTURE", "WHITEFORM_BACKCOLOR"); return WhiteFormColor; }
            set { WhiteFormColor = value; colorset(ref WhiteFormColor_temp, ref WhiteFormColor, "CAPTURE", "WHITEFORM_BACKCOLOR"); }
        }

        #endregion
        #region/**SAVE**/
        private int using_ClipBoard;            //클립보드를 사용할지 결정
        public int using_ClipBoardGS
        {
            get { using_ClipBoard = int.Parse(Setting_ini.GetIniValue("SAVE", "USING_CLIPBOARD", inipath)); return using_ClipBoard; }
            set { using_ClipBoard = value; Setting_ini.SetIniValue("SAVE", "USING_CLIPBOARD", using_ClipBoard.ToString(), inipath); }
        }
        private int UseDirName;
        public int UseDirNameGS
        {
            get { UseDirName = int.Parse(Setting_ini.GetIniValue("SAVE", "USEDIRNAME", inipath)); return UseDirName; }
            set { UseDirName = value; DirAddJob(); Setting_ini.SetIniValue("SAVE", "USEDIRNAME", UseDirName.ToString(), inipath); }
        }
        private int UseDirTime;
        public int UseDirTimeGS
        {
            get { UseDirTime = int.Parse(Setting_ini.GetIniValue("SAVE", "USEDIRTIME", inipath)); return UseDirTime; }
            set { UseDirTime = value; DirAddJob(); Setting_ini.SetIniValue("SAVE", "USEDIRTIME", UseDirTime.ToString(), inipath); }
        }
        private int AutoSave;
        public int AutoSaveGS
        {
            get { AutoSave = int.Parse(Setting_ini.GetIniValue("SAVE", "AUTOSAVED", inipath)); return AutoSave; }
            set { AutoSave = value; Setting_ini.SetIniValue("SAVE", "AUTOSAVED", AutoSave.ToString(), inipath); }
        }
        private int AutoSaveToChildDriectory;
        public int AutoSaveToChildDriectoryGS
        {
            get { AutoSaveToChildDriectory = int.Parse(Setting_ini.GetIniValue("SAVE", "AUTOSAVED_TO_CHILD_DIRECTORY", inipath)); return AutoSaveToChildDriectory; }
            set { AutoSaveToChildDriectory = value; Setting_ini.SetIniValue("SAVE", "AUTOSAVED_TO_CHILD_DIRECTORY", AutoSaveToChildDriectory.ToString(), inipath); }
        }

        private string SavedOption_Name;        // Capture
        public String SavedOption_NameGS
        {
            get { SavedOption_Name = Setting_ini.GetIniValue("SAVE", "NAME", inipath); return SavedOption_Name; }
            set { SavedOption_Name = value; Setting_ini.SetIniValue("SAVE", "NAME", SavedOption_Name, inipath); DirAddJob(); SavedOption_FullPathGSPatch(); }
        }
        private int SavedOption_PathMode;       // 0:스패셜, 1:직접경로
        public int SavedOption_PathModeGS
        {
            get { SavedOption_PathMode = int.Parse(Setting_ini.GetIniValue("SAVE", "PATH_MODE", inipath)); return SavedOption_PathMode; }
            set { SavedOption_PathMode = value; Setting_ini.SetIniValue("SAVE", "PATH_MODE", SavedOption_PathMode.ToString(), inipath); }
        }
        private string SavedOption_Extension;   // png
        public string SavedOption_ExtensionGS
        {
            get { SavedOption_Extension = Setting_ini.GetIniValue("SAVE", "EXTENSIO", inipath); return SavedOption_Extension; }
            set { SavedOption_Extension = value; Setting_ini.SetIniValue("SAVE", "EXTENSIO", SavedOption_Extension, inipath); SavedOption_FullPathGSPatch(); }
        }
        private string SavedOption_Directory;   // 내 사진 or C:\Users\goldy\Pictures
        public string SavedOption_DirectoryGS   
        {
            get { SavedOption_Directory = Setting_ini.GetIniValue("SAVE", "DIRECTORY", inipath); return SavedOption_Directory; }
            set { SavedOption_Directory = value; Setting_ini.SetIniValue("SAVE", "DIRECTORY", SavedOption_Directory, inipath); SavedOption_FullPathGSPatch(); }
        }
        private String SavedOption_DateTimeStyle;   // yyyy년MM월dd일
        public String SavedOption_DateTimeStyleGS
        {
            get { SavedOption_DateTimeStyle = Setting_ini.GetIniValue("SAVE", "DATETIMESTYLEGS", inipath); return SavedOption_DateTimeStyle; }
            set { SavedOption_DateTimeStyle = value; Setting_ini.SetIniValue("SAVE", "DATETIMESTYLEGS", SavedOption_DateTimeStyle.ToString(), inipath); }
        }
        public string SavedOption_DirectoryAdd;    //SavedOption_DirectoryAdd = (UseDirTime == 1 ? @"\" + DateTime.Now.ToString(SavedOption_DateTimeStyleGS) : "") + (UseDirName == 1 ? @"\" + SavedOption_NameGS : "");
        private int SavedOption_FilterIndex;        // 3
        public int SavedOption_FilterIndexGS
        {
            get { SavedOption_FilterIndex = int.Parse(Setting_ini.GetIniValue("SAVE", "FILTER_INDEX", inipath)); return SavedOption_FilterIndex; }
            set { SavedOption_FilterIndex = value; Setting_ini.SetIniValue("SAVE", "FILTER_INDEX", SavedOption_FilterIndex.ToString(), inipath); }
        }
        private string SavedOption_FullPath;        // 내문서 + DirectoryADD + 파일명
        public string SavedOption_FullPathGS
        {
            get { SavedOption_FullPath = Setting_ini.GetIniValue("SAVE", "FULLPATH", inipath); return SavedOption_FullPath; }
            set { SavedOption_FullPath = value; Setting_ini.SetIniValue("SAVE", "FULLPATH", SavedOption_FullPath, inipath); }
        }
        #endregion


        public DefaultOption()
        {
            try
            {
                Constructor_beginningSet();
            }
            catch (FormatException temp)
            {
                Option_DefaultReset();
                System.Windows.Forms.MessageBox.Show("ini파일 변경으로 인해 모든 옵션을 초기화하였습니다.\n" + temp.Message);
            }
        }
        /// <summary>
        /// 생성할때 객체를 인스턴스해줌
        /// </summary>
        /// <param name="frm">--목록--
        /// <para>MainForm</para> <para>whiteForm</para> <para>SettingForm</para> <para>SetCapture</para> <para>SetInterFace</para> <para>SetSave</para> <para>FormOpacity</para> <para>ControlMove</para>
        /// </param>
        public DefaultOption(object frm)
            : this()
        {
            if (frm is MainForm) this.FRM_MAINFORM = frm as MainForm;
            if (frm is whiteForm) this.FRM_WHITEFORM = frm as whiteForm;
            if (frm is SettingForm) this.FRM_SETTINGFORM = frm as SettingForm;
            if (frm is SetCapture) this.USER_SETCAPTURE = frm as SetCapture;
            if (frm is SetInterFace) this.USER_SETINTERFACE = frm as SetInterFace;
            if (frm is SetSave) this.USER_SETSAVE = frm as SetSave;
            if (frm is FormOpacity) this.CLASS_FORMOPACITY = frm as FormOpacity;
            if (frm is ControlMove) this.CLASS_CONTROLMOVE = frm as ControlMove;
        }
        private void SavedOption_FullPathGSPatch()
        {
            SavedOption_FullPathGS = SavedOption_DirectoryGS + SavedOption_DirectoryAdd + @"\" + SavedOption_NameGS + "." + SavedOption_ExtensionGS;
        }
        private void Constructor_beginningSet()
        {
            ToolStrip_BackColor_temp = new int[3];
            StrokeColor_temp = new int[3];
            WhiteFormColor_temp = new int[3];
            Setting_ini = new iniGetSet();
            if (IniFileChk() == 2)  //존재할때 ini에서 값을 가져옴
            {
                GetIni();
                chkDirectory();
                DirAddJob();
                SavedOption_FullPathGSPatch();
            }
            else                    //파일 또는 폴더에 이상이있거나 존재하지않을때 -> 초기설정셋팅
            {
                IniFileMake();
                Option_DefaultReset();
                chkDirectory();
            }
        }
        public string tempreturn()
        {
            return SavedOption_FullPath;
        }
        public void DirAddJob()
        {
            SavedOption_DirectoryAdd = (UseDirTime == 1 ? @"\" + DateTime.Now.ToString(SavedOption_DateTimeStyleGS) : "") + (UseDirName == 1 ? @"\" + SavedOption_NameGS : "");
        }

        

        // Color를 RGB형식으로 변형
        private Color colorget(ref int[] Color_Temp, ref Color getColor, string section, string name)
        {
            Color temp = new Color();
            Color_Temp[0] = int.Parse(Setting_ini.GetIniValue(section, name + "_R", inipath));
            Color_Temp[1] = int.Parse(Setting_ini.GetIniValue(section, name + "_G", inipath));
            Color_Temp[2] = int.Parse(Setting_ini.GetIniValue(section, name + "_B", inipath));
            temp = Color.FromArgb(Color_Temp[0], Color_Temp[1], Color_Temp[2]);
            return temp;
        }
        private void colorset(ref int[] Color_Temp, ref Color setColor, string section, string name)
        {
            Color_Temp = new int[3] { setColor.R, setColor.G, setColor.B };
            Setting_ini.SetIniValue(section, name + "_R", Color_Temp[0].ToString(), inipath);
            Setting_ini.SetIniValue(section, name + "_G", Color_Temp[1].ToString(), inipath);
            Setting_ini.SetIniValue(section, name + "_B", Color_Temp[2].ToString(), inipath);
        }
        public void Option_DefaultReset()
        {
            /**INTERFACE**/
            Using_TrayGS = 1;
            Using_WinRegGS = 0;
            ToolStripSizeGS = 25;
            ToolStrip_BackColorGS = Color.Red;
            using_ClipBoardGS = 1;
            Using_DetailGS = 1;
            Using_BackColorChangeForHoverGS = 1;
            EffectOpacityGS = 1;
            EffectControlMoveGS = 1;
            Using_JobCaptureAfterProgramStartGS = 1;

            /**CAPTURE**/
            MouseHalfSpeedGS = 1;
            HotkeyAfterActiveGS = 1;
            SleepValueGS = 300;
            CaptureModeGS = 0;
            PenstrokeGS = 5;
            StrokeColorGS = Color.Blue;
            WhiteFormColorGS = Color.White;


            /**SAVE**/
            UseDirNameGS = 1;
            UseDirTimeGS = 1;
            AutoSaveGS = 0;
            AutoSaveToChildDriectoryGS = 0;
            SavedOption_NameGS = "Capture";
            SavedOption_PathModeGS = 0;
            SavedOption_ExtensionGS = "png";
            SavedOption_DirectoryGS = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            SavedOption_DirectoryAdd = "";
            SavedOption_FilterIndexGS = 3;
            SavedOption_DateTimeStyleGS = "yyyy년MM월dd일";
            SavedOption_FullPathGS = SavedOption_DirectoryGS + SavedOption_DirectoryAdd + @"\" + SavedOption_NameGS + "." + SavedOption_ExtensionGS;
        }

        /// <summary>
        /// 사용자 지정디렉토리가 없을경우, 내문서로 변경
        ///                     있을경우, 하위 디렉토리 생성
        /// </summary>
        /// <returns></returns>
        public string chkDirectory()
        {
            System.IO.DirectoryInfo dInfo = new System.IO.DirectoryInfo(SavedOption_DirectoryGS);
            if (!dInfo.Exists) SavedOption_DirectoryGS = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (UseDirName == 1 || UseDirTime == 1)
            {
                System.IO.DirectoryInfo dinfoAdd = new System.IO.DirectoryInfo(Path.GetDirectoryName(SavedOption_FullPathGS));
                if (!dinfoAdd.Exists)
                    dinfoAdd.Create();
            }
            return Path.GetDirectoryName(SavedOption_FullPathGS);
        }
        private void FileDelete_Create()
        {
            System.IO.FileInfo chkiniPath = new System.IO.FileInfo(@"C:\Capture\Setting.ini");
            chkiniPath.Delete();
            Constructor_beginningSet();
        }
        private int IniFileChk()   //return :: 0)디렉토리도없음 1)디렉토리만존재  2)정상적으로 있음
        {
            System.IO.FileInfo chkiniPath = new System.IO.FileInfo(@"C:\Capture\Setting.ini");
            inipath = chkiniPath.FullName;
            System.IO.DirectoryInfo iniDirPath = new System.IO.DirectoryInfo(@"C:\Capture\");
            if (iniDirPath.Exists)
                if (chkiniPath.Exists) return 2;
                else return 1;
            else return 0;
        }
        private void IniFileMake()   //return :: ini주소값
        {
            System.IO.FileInfo chkiniPath = new System.IO.FileInfo(@"C:\Capture\Setting.ini");
            if (!chkiniPath.Exists)
            {
                System.IO.DirectoryInfo iniDirPath = new System.IO.DirectoryInfo(@"C:\Capture\");
                iniDirPath.Create();
                chkiniPath.Create().Close();
                chkiniPath.Create().Dispose();
            }
        }
        private void GetIni()
        {
            //**INTERFACE
            Using_Tray = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EXIT_TRAY", inipath));
            Using_WinReg = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_WINREG", inipath));
            ToolStripSize = int.Parse(Setting_ini.GetIniValue("INTERFACE", "TOOLSTRIP_SIZE", inipath));
            ToolStrip_BackColor = colorget(ref ToolStrip_BackColor_temp, ref ToolStrip_BackColor, "INTERFACE", "TOOLSTRIP_BACKCOLOR");
            Using_Detail = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_DETAIL", inipath));
            Using_BackColorChangeForHover = int.Parse(Setting_ini.GetIniValue("INTERFACE", "BACKCOLORCHANGEFOR_HOVER", inipath));
            EffectOpacity = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EFFECT_OPACITY", inipath));
            EffectControlMove = int.Parse(Setting_ini.GetIniValue("INTERFACE", "EFFECT_CONTROL_MOVE", inipath));
            Using_JobCaptureAfterProgramStart = int.Parse(Setting_ini.GetIniValue("INTERFACE", "USING_JOBCAPTUREAFTERPROGRAMSTART", inipath));

            //**CAPTURE
            MouseHalfSpeed = int.Parse(Setting_ini.GetIniValue("CAPTURE", "MOUSE_HALF_SPEED", inipath));
            HotkeyAfterActive = int.Parse(Setting_ini.GetIniValue("CAPTURE", "HOTKEY_AFTER_ACTIVE", inipath));
            SleepValue = int.Parse(Setting_ini.GetIniValue("CAPTURE", "SLEEPVALUE", inipath));
            CaptureMode = int.Parse(Setting_ini.GetIniValue("CAPTURE", "CAPTURE_MODE", inipath));
            Penstroke = int.Parse(Setting_ini.GetIniValue("CAPTURE", "PENSTROKE", inipath));
            StrokeColor = colorget(ref StrokeColor_temp, ref StrokeColor, "CAPTURE", "STROKECOLOR");
            WhiteFormColor = colorget(ref WhiteFormColor_temp, ref WhiteFormColor, "CAPTURE", "WHITEFORM_BACKCOLOR");

            //**SAVE
            using_ClipBoard = int.Parse(Setting_ini.GetIniValue("SAVE", "USING_CLIPBOARD", inipath));
            UseDirName = int.Parse(Setting_ini.GetIniValue("SAVE", "USEDIRNAME", inipath));
            UseDirTime = int.Parse(Setting_ini.GetIniValue("SAVE", "USEDIRTIME", inipath));
            AutoSave = int.Parse(Setting_ini.GetIniValue("SAVE", "AUTOSAVED", inipath));
            AutoSaveToChildDriectory = int.Parse(Setting_ini.GetIniValue("SAVE", "AUTOSAVED_TO_CHILD_DIRECTORY", inipath));
            SavedOption_Name = Setting_ini.GetIniValue("SAVE", "NAME", inipath);
            SavedOption_PathMode = int.Parse(Setting_ini.GetIniValue("SAVE", "PATH_MODE", inipath));
            SavedOption_Extension = Setting_ini.GetIniValue("SAVE", "EXTENSIO", inipath);
            SavedOption_Directory = Setting_ini.GetIniValue("SAVE", "DIRECTORY", inipath);
            SavedOption_FullPath = Setting_ini.GetIniValue("SAVE", "FULLPATH", inipath);
            SavedOption_DateTimeStyle = Setting_ini.GetIniValue("SAVE", "DATETIMESTYLEGS", inipath);
            SavedOption_FilterIndex = int.Parse(Setting_ini.GetIniValue("SAVE", "FILTER_INDEX", inipath));
        }

        public override String ToString()
        {
            return "ok";
        }
    }
}
