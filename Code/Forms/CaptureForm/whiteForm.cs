using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Capture
{
    public partial class whiteForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, out int lpvParam, int fuWinIni);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);
        private const int SPI_GETMOUSESPEED = 112;
        private const int SPI_SETMOUSESPEED = 113;

        public whiteForm(Form frm)
        {
            InitializeComponent();
            if (frm is MainForm)
                FMR_MAINFORM = frm as MainForm;
            else if (frm is SettingForm)
                FRM_SETTINGFORM = frm as SettingForm;
            CLASS_DEFAULTOPTION = new DefaultOption(this);
            RECTANGLE_STROKE = CLASS_DEFAULTOPTION.PenstrokeGS;
            panel2.BackColor = CLASS_DEFAULTOPTION.StrokeColorGS;
        }

        /****전역선언****/
        // 클래스
        private DefaultOption CLASS_DEFAULTOPTION;
        private FormOpacity CLASS_FORMOPACITY;
        // 폼
        private MainForm FMR_MAINFORM;
        private SettingForm FRM_SETTINGFORM;
        // 전역변수
        private Bitmap TEMP_BITMAP { get; set; }    // 임시 이미지 기억
        private Point DRAG_START;                   // panel1's left upper corner DRAG_STARTation
        private int RECTANGLE_STROKE = 1;           // 드래그 선의 굵게
        private int USER_MOUSE_SPEED;               // 유저의 마우스값을 임시 저장


        private void white_Load(object sender, EventArgs e)
        {
            CLASS_FORMOPACITY = new FormOpacity(this, 40, 10);
            FormEventSet();
            FormDesignSet();
        }

        /// <summary>
        /// whiteForm의 초기 디자인을 설정합니다.
        /// </summary>
        private void FormDesignSet()
        {
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, out USER_MOUSE_SPEED, 0);
            /*Set FormDesign*/
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Location = new Point(0, 0);
            this.TopMost = true;
            label_Location.Visible = label_Size.Visible = panel1.Visible = panel2.Visible = false;
            label_MSG.Location = new Point((Screen.PrimaryScreen.Bounds.Width-label_MSG.Size.Width)/2,Screen.PrimaryScreen.Bounds.Height/3);
            //CLASS_FORMOPACITY.formToSharp(0.5);
            CLASS_FORMOPACITY.formToDimly(false, 0.5);


            if (CLASS_DEFAULTOPTION.EffectOpacityGS == 0)
                this.Opacity = 0.5;
            this.BackColor = CLASS_DEFAULTOPTION.WhiteFormColorGS;
            label_MSG.ForeColor = label_Size.ForeColor = label_Location.ForeColor = Color.FromArgb(FMR_MAINFORM.reverseColor(this.BackColor.R), FMR_MAINFORM.reverseColor(this.BackColor.G), FMR_MAINFORM.reverseColor(this.BackColor.B));
            /*transpancy for Panel1*/
            this.TransparencyKey = SystemColors.ControlDark;
            panel1.BackColor = SystemColors.ControlDark;
        }

        /// <summary>
        /// WhiteForm 의 이벤트를 선언합니다.
        /// </summary>
        private void FormEventSet()
        {
            bool MOUSE_KEY_STATE = false;          // 마우스입력하였을때 True 아닐때 False

            Point DRAG_END;                      // panel1's right lower corner DRAG_STARTation

            this.KeyDown += (b, d) =>
            {
                this.Close();
                if (d.KeyCode == Keys.Escape)
                {
                    MessageBox.Show("d");
                    this.Close();
                }
            };
            this.KeyUp += (b, d) =>
            {
                this.Close();
            };
            /*Mouse ClickDrag Event*/
            this.MouseDown += (b, d) =>
                {
                    if (CLASS_DEFAULTOPTION.MouseHalfSpeedGS == 1)
                        SystemParametersInfo(SPI_SETMOUSESPEED, 0, USER_MOUSE_SPEED / 2, 0);

                    MOUSE_KEY_STATE = true;
                    DRAG_START = d.Location;
                    label_Location.Visible = label_Size.Visible = panel1.Visible = panel2.Visible = true;
                    label_Size.Location = d.Location;
                    panel1.Location = DRAG_START;
                };
            this.MouseUp += (b, d) =>
                {
                    FMR_MAINFORM.AutoSavedPath = null;
                    MOUSE_KEY_STATE = false;
                    TEMP_BITMAP = new Bitmap(panel1.Width, panel1.Height);
                    Graphics graphics = Graphics.FromImage(TEMP_BITMAP as Image);
                    graphics.CopyFromScreen(panel1.Location, new Point(0, 0), TEMP_BITMAP.Size);

                    MainForm fdr = (MainForm)Owner;
                    fdr.PRINTSCREEN = TEMP_BITMAP;
                    fdr.PRINTSCREEN_LOCATION = panel1.Location;
                    SystemParametersInfo(SPI_SETMOUSESPEED, 0, USER_MOUSE_SPEED, 0);
                    if (CLASS_DEFAULTOPTION.EffectOpacityGS == 1)
                        CLASS_FORMOPACITY.formToDimly(true, 0, 0.5);
                    else
                        this.Close();
                    Thread tmp = new Thread(waitExit);
                    tmp.Start(300);

                };
            this.MouseMove += (b, d) =>
                {
                    if (MOUSE_KEY_STATE)
                    {

                        DRAG_END = d.Location;
                        panel2.Size = new Size(Math.Abs(DRAG_END.X - DRAG_START.X) + (RECTANGLE_STROKE * 2), Math.Abs(DRAG_END.Y - DRAG_START.Y) + (RECTANGLE_STROKE * 2));
                        panel1.Size = new Size(Math.Abs(DRAG_END.X - DRAG_START.X), Math.Abs(DRAG_END.Y - DRAG_START.Y));

                        panel1.Location = new Point(DRAG_END.X > DRAG_START.X ? DRAG_START.X : DRAG_END.X, DRAG_END.Y > DRAG_START.Y ? DRAG_START.Y : DRAG_END.Y);
                        panel2.Location = new Point(panel1.Location.X - RECTANGLE_STROKE, panel1.Location.Y - RECTANGLE_STROKE);
                        panel1.BringToFront();
                        label_Location.Text = panel1.Location.ToString();//
                        label_Size.Text = panel1.Size.ToString();

                        #region 그래픽으로 만든다면
                        /*
                        using (g = this.panel1.CreateGraphics())
                        {
                            Brush brush = new SolidBrush(this.BackColor);

                            g.Clear(this.panel1.BackColor);
                            g.DrawRectangle(new Pen(Color.Purple, 1), 0, 0, panel1.Size.Width, panel1.Size.Height);
                            g.Dispose();
                        }*/
                        #endregion

                    }
                };
            panel2.SizeChanged += (b, d) =>
            {
                label_Location.Location = new Point(panel2.Left, panel2.Top - label_Location.Size.Height);
                label_Size.Location = new Point(panel2.Right - label_Size.Size.Width, panel2.Bottom);
            };
        }
        private void waitExit(object milliseconds)
        {
            Int32 currentTick = Environment.TickCount;
            while (Environment.TickCount <= currentTick + (Int32)milliseconds) { }
            this.Close();
        }


    }
}
