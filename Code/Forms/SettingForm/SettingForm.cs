using System;
using System.Windows.Forms;
using System.Drawing;
namespace Capture
{
    public partial class SettingForm : Form
    {
        public SettingForm(Form frm)
        {
            InitializeComponent();
            FRM_MAINFORM = frm as MainForm;
            USER_SET_SAVE = new SetSave(this);
            USER_SET_INTERFACE = new SetInterFace(FRM_MAINFORM);
            USER_SET_CAPTURE = new SetCapture(this);
            CLASS_DEFAULTOPTION = new DefaultOption(this);
        }

        /****전역선언****/
        //클래스
        private DefaultOption CLASS_DEFAULTOPTION;
        //폼
        private MainForm FRM_MAINFORM;
        //유저인터페이스
        private SetSave USER_SET_SAVE;
        private SetInterFace USER_SET_INTERFACE;
        private SetCapture USER_SET_CAPTURE;
        ControlMove CM;

        private void Setting_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ToolTipSet();           // 툴팁셋팅
            Event_ChangValueSet();  // 수치변경시 이벤트
            valueSet();             // 수치 초기화
            Interface_Event();

            buttonExit.KeyDown += (b, d) => { if (d.KeyCode == Keys.Escape) this.Close(); };
            buttonExit.Click += (b, d) => { this.Close(); };

            Point tt = this.Location;
            Point tt_ = new Point(tt.X - 20, tt.Y);

            FormOpacity FO = new FormOpacity(this);
            FO.formToSharp();
            CM = new ControlMove(this, new Point(this.Location.X - 10, this.Location.Y), this.Location, 0, 1, 10);
            CM.MoveStart();

            int option = 2;
            if (option == 1)
            {
                Object[] PackMenuButton = { button_InterFace, button_Capture, button_AutoSave };
                for (int i = 0 ; i < PackMenuButton.Length ; i++)
                {
                    Random rand = new Random(unchecked((int)DateTime.Now.Ticks));

                    CM = new ControlMove(
                        (PackMenuButton[i] as Button),
                        new Point((PackMenuButton[i] as Button).Location.X - rand.Next(50, 120), (PackMenuButton[i] as Button).Location.Y),
                        (PackMenuButton[i] as Button).Location, 0, rand.Next(1, 3), rand.Next(10, 30)
                        );
                    CM.MoveStart(rand.Next(0, 1000));
                }
            }
            else if (option == 2)
            {
                Object[] PackMenuButton = { button_InterFace, button_Capture, button_AutoSave };
                for (int i = 0 ; i < PackMenuButton.Length ; i++)
                {
                    Random rand = new Random(unchecked((int)DateTime.Now.Ticks));

                    CM = new ControlMove(
                        (PackMenuButton[i] as Button),
                        new Point((PackMenuButton[i] as Button).Location.X - 100, (PackMenuButton[i] as Button).Location.Y),
                        (PackMenuButton[i] as Button).Location, 0, 1, 10
                        );
                    CM.MoveStart(rand.Next(0, 200));
                }
            }
            else if (option == 3)
            {
                CM = new ControlMove(button_InterFace, new Point(button_InterFace.Location.X - 100, button_InterFace.Location.Y), button_InterFace.Location, 0, 1, 5);
                CM.MoveStart();
                CM = new ControlMove(button_Capture, new Point(button_Capture.Location.X - 100, button_Capture.Location.Y), button_Capture.Location, 0, 1, 5);
                CM.MoveStart(150);
                CM = new ControlMove(button_AutoSave, new Point(button_AutoSave.Location.X - 100, button_AutoSave.Location.Y), button_AutoSave.Location, 0, 1, 5);
                CM.MoveStart(200);
                //CM = new ControlMove(panel1, new Point(panel1.Location.X, panel1.Location.Y - 100), panel1.Location, 0, 1, 30);
                //CM.MoveStart();
            }
        }

        private void ToolTipSet()
        {

        }

        private void Event_ChangValueSet()
        {
            Button[] PACK_MENUBUTTON = { button_InterFace, button_Capture, button_AutoSave };
            Control[] PACK_MENUCONTROL = { USER_SET_INTERFACE, USER_SET_CAPTURE, USER_SET_SAVE };

            for (int i = 0 ; i < PACK_MENUCONTROL.Length ; i++)
                panel1.Controls.Add(PACK_MENUCONTROL[i]);   // 하위 컨트롤 추가


            PACK_MENUBUTTON[0].Enabled = false;
            PACK_MENUCONTROL[0].BringToFront();

            PACK_MENUBUTTON[0].Click += (b, d) =>
                {
                    for (int i = 0 ; i < PACK_MENUBUTTON.Length ; i++)
                        PACK_MENUBUTTON[i].Enabled = PACK_MENUBUTTON[0] == PACK_MENUBUTTON[i] ? false : true;
                    menuChange(PACK_MENUCONTROL[0]);
                };
            PACK_MENUBUTTON[1].Click += (b, d) =>
                {
                    for (int i = 0 ; i < PACK_MENUBUTTON.Length ; i++)
                        PACK_MENUBUTTON[i].Enabled = PACK_MENUBUTTON[1] == PACK_MENUBUTTON[i] ? false : true;
                    menuChange(PACK_MENUCONTROL[1]);
                };
            PACK_MENUBUTTON[2].Click += (b, d) =>
                {
                    for (int i = 0 ; i < PACK_MENUBUTTON.Length ; i++)
                        PACK_MENUBUTTON[i].Enabled = PACK_MENUBUTTON[2] == PACK_MENUBUTTON[i] ? false : true;
                    menuChange(PACK_MENUCONTROL[2]);
                };

        }
        public void menuChange(Control temp)
        {
            temp.BringToFront();
            temp.Focus();
            /*
            CM = new ControlMove(temp, new Point(temp.Location.X + 300, 0), new Point(temp.Location.X, 0), 0, 1, 15);
            CM.MoveStart();
            */

        }

        private void valueSet()
        {
            int x = FRM_MAINFORM.Left + (FRM_MAINFORM.Size.Width - this.Size.Width) / 2;
            int y = FRM_MAINFORM.Top + (FRM_MAINFORM.Size.Height - this.Size.Height) / 2;
            this.Location = new Point(x < 0 ? 0 : x, y < 0 ? 0 : y);

            if (this.Location.X <= 0)
                this.Location = new Point(0, FRM_MAINFORM.Top + (FRM_MAINFORM.Size.Height - this.Size.Height) / 2);
            if (this.Location.Y <= 0)
                this.Location = new Point(FRM_MAINFORM.Left + (FRM_MAINFORM.Size.Width - this.Size.Width) / 2, 0);

            if (this.Location.X <= 0 && this.Location.Y <= 0)
                this.Location = new Point(0, 0);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner = FRM_MAINFORM;
            FRM_MAINFORM.resetSettingFrm();
        }
    }
}
