using System;
using System.Drawing;
using System.Windows.Forms;
/*추가 using*/

namespace Capture
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 전역 선언
        /*Class*/
        private DefaultOption CLASS_DEFAULTOPTION;  // Capture프로젝트의 모든 옵션을 저장하는 클래스
        private FormMagnet CLASS_MAGNET;
        /*Form*/
        private backImage FRM_BACKIMAGE;            // Forms\CaptureForm\backImageForm.cs
        private whiteForm FRM_WHITEFORM;            // Forms\CaptureForm\whiteForm.cs
        private ColorList FRM_COLORLIST;            // Forms\ETC\ColorList.cs
        //private Character FRM_CHARACTER;            // Forms\ETC\Character.cs
        private SettingForm FRM_SETTINGFORM;        // Forms\SettingForm\SettingFrom.cs
        /*Variable*/
        private static String STATIC_THIS_NAME = "캡쳐도구";        // 메인폼의 기본이름/
        public Bitmap PRINTSCREEN { get; set; }                     // 캡쳐된이미지
        public Point PRINTSCREEN_LOCATION { get; set; }             // 캡쳐된이미지위치
        private object[,] Pack_LabelControls = new object[3, 2];    // 캡쳐이미지 정보값 공유
        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            
            #region ★초기셋팅코드★
            {
                

                //인스턴스
                FRM_COLORLIST = new ColorList(this);            // (폼) 칼라수집폼/
                CLASS_DEFAULTOPTION = new DefaultOption(this);  // (클래스)옵션불러오기
                CLASS_MAGNET = new FormMagnet(this, 30);        // 코너로 끌을시 자석효과(최대화시 오류..)
                //초기설정
                HotKey_Load();                                  // HotKey셋팅 (전역단축키설정)
                FormDesignSet();                                // 초기 디자인설정
                EventPack();                                    // 이벤트선언
                Character();
                if (CLASS_DEFAULTOPTION.Using_JobCaptureAfterProgramStartGS == 1)
                    JobCapture();

                if (Program.IsAdministrator())
                    this.Text += "(Adminstrator)";

            }
            #endregion


            #region TestCode
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                FormOpacity ff = new FormOpacity(this, 30);
                ff.formToSharp();
                ControlMove cm = new ControlMove(this, new Point(60, 100), new Point(100, 100), 0, 1, 20);
                cm.MoveStart();
            }
            #endregion
        }


        /// <summary> 옵션폼에서 "초기화"버튼 클릭시 옵션창을 재실행하는 함수</summary>
        public void resetSettingFrm()
        {
            FRM_SETTINGFORM.Dispose();
            CLASS_DEFAULTOPTION.Option_DefaultReset();
            FRM_SETTINGFORM = new SettingForm(this);
            FRM_SETTINGFORM.ShowDialog();
        }
    }
}
