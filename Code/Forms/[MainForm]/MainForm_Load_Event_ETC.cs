using System.Drawing;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
/*추가 using*/

namespace Capture
{
    public partial class MainForm
    {
        object[] xyColor_Memory = new object[10];
        private Point xyMouse_absolute;
        private Point xyMouse_relative;
        private int[] xyColor = new int[3];
        Action<object, EventArgs> ttt = (b, d) => 
        { 
            
        };

        #region Main에서 호출되는 대표함수들
        /// <summary>
        /// ★★
        /// MainForm 초기에 호출하는 디자인 대표 함수
        /// </summary>
        private void FormDesignSet()
        {
            CLASS_MAGNET.FormMagnet_ready = false;
            notifyIcon1.Visible = false;
            toolStrip1.ImageScalingSize = new Size(CLASS_DEFAULTOPTION.ToolStripSizeGS, CLASS_DEFAULTOPTION.ToolStripSizeGS);

            this.Size = new Size(CLASS_DEFAULTOPTION.ToolStripSizeGS * 15, CLASS_DEFAULTOPTION.ToolStripSizeGS + 70);
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height + (toolStrip1.Size.Height + menuStrip1.Size.Height) - pictureBox1.Height) / 2);
            panel1.Location = new Point(0, menuStrip1.Size.Height + toolStrip1.Size.Height);
            panel1.Size = new Size(this.Size.Width - panel1.Location.X - 20, this.Size.Height - panel1.Location.Y - 35);

            if (pictureBox1.Image == null)
            {
                SavedForToolStrip.Enabled = false;
                SavedForMenuStrip.Enabled = false;
                CopyForToolStrip.Enabled = false;
                CopyForMenuStrip.Enabled = false;
                CharacterFortoolStrip.Enabled = false;
                PenFortoolStrip.Enabled = false;
                DetailForToolStrip.Enabled = true; //false;
            }
            ControlsLoc();
            CLASS_MAGNET.FormMagnet_ready = true;
        }


        /// <summary>
        /// ★★
        /// MainForm 초기에 호출하는 이벤트 대표 함수
        /// </summary>
        private void EventPack()
        {
            EVENT_This();
            EVENT_ToolMenu_Strip();
            EVENT_PictureBox();
            EVENT_Tray_ContextMenu();
            EVENT_ETC();


        }
        #endregion






        #region EventPack()에 호출당하는 쫄병 함수
        /// <summary>'MainForm(This)'에 관련된 이벤트</summary>
        private void EVENT_This()
        {
            bool ExitCompulsion = false;
            //
            ///this 이빈트///

            this.KeyDown += (b, d) =>
            {
                if (d.Control && d.KeyCode == Keys.S)//&& pictureBox1.Image != null)
                    FuncSave();
                if (d.Control && d.KeyCode == Keys.D)//&& pictureBox1.Image != null)
                    colorSave();
                if (d.Control && d.KeyCode == Keys.A)
                    JobCapture();
                if (d.Control && d.KeyCode == Keys.Q)// && pictureBox1.Image != null)
                    PenForToolStripClick();
                if (d.KeyCode == Keys.F5)
                    SettingForMenuStrip.PerformClick();
                
            };

            

            /* 마우스줌
            this.MouseWheel += (b, d) =>
            {
                if (d.Delta > 0) PictureZoom(true);
                else PictureZoom(false);
            };*/
            this.SizeChanged += (b, d) =>
            {
                CLASS_MAGNET.FormMagnet_ready = false;
                panel1.Location = new Point(0, menuStrip1.Size.Height + toolStrip1.Size.Height);
                panel1.Size = new Size(this.Size.Width - panel1.Location.X - 20, this.Size.Height - panel1.Location.Y - 40);
                pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height - pictureBox1.Height) / 2);

                labelLocation.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Size.Height + 10);
                wLocation.Location = new Point(labelLocation.Location.X + 70, labelLocation.Location.Y);

                labelSize.Location = new Point(labelLocation.Left, labelLocation.Location.Y + 15);
                wSize.Location = new Point(labelLocation.Location.X + 70, wLocation.Location.Y + 15);

                labelGetColor.Location = new Point(labelLocation.Location.X + 250, labelLocation.Location.Y);
                panel1.BackColor = Color.Transparent;
                this.OnLocationChanged(null);
                CLASS_MAGNET.FormMagnet_ready = true;
            };
            this.LocationChanged += (b, d) => { FRM_COLORLIST.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y); };
            this.FormClosing += (b, d) => { if (CLASS_DEFAULTOPTION.Using_TrayGS == 1 && ExitCompulsion == false) { d.Cancel = true; UsingTray(); } };

        }

        /// <summary>메인폼 상단의 '툴스트립'과 '메뉴스트립'에 관련된 이벤트</summary>
        private void EVENT_ToolMenu_Strip()
        {
            //
            //ToolStrip&MenuStrip이벤트
            OpenPathFortoolStrip.Click += (b, d) => { System.Diagnostics.Process.Start(CLASS_DEFAULTOPTION.chkDirectory()); };
            CaptureForMenuStrip.Click += (b, d) => { JobCapture(); };
            CaptureForToolStrip.Click += (b, d) => { if (this.CaptureForToolStrip.DropDownButtonPressed != true) JobCapture(); };
            SavedForMenuStrip.Click += (b, d) => { SavedForToolStrip.PerformClick(); };
            SavedForToolStrip.Click += (b, d) => { FuncSave(); };
            SpendForMenuStrip.Click += (b, d) => { };
            ExitForMenuStrip.Click += (b, d) => { this.Close(); this.Dispose(); };

            CopyForMenuStrip.Click += (b, d) => { CopyForToolStrip.PerformClick(); };
            CopyForToolStrip.Click += (b, d) => { Clipboard.SetImage(pictureBox1.Image); MSG_USE("클립보드로 저장되었습니다."); };
            SettingForMenuStrip.Click += (b, d) => { SettingForToolStrip.PerformClick(); };
            SettingForToolStrip.Click += (b, d) => { FRM_SETTINGFORM = new SettingForm(this); FRM_SETTINGFORM.ShowDialog(); };
            DetailForToolStrip.Click += (b, d) =>
            {
                if (DetailForToolStrip.Checked == false)
                    FRM_COLORLIST.Show();
                else if (DetailForToolStrip.Checked == true)
                    FRM_COLORLIST.Hide();
                DetailForToolStrip.Checked = !DetailForToolStrip.Checked;
            };
            PenFortoolStrip.Click += (b, d) => { PenForToolStripClick(); };
        }

        private void PenForToolStripClick()
        {
            if (pictureBox1.Image == null)
            {
                MSG_USE("캡쳐작업 후 가능합니다");
                return;
            }
            if (PenFortoolStrip.BackColor != Color.Gray)
            {
                JobPen jobPen = new JobPen(this);
                //jobPen.MdiParent = this;
                jobPen.Show();

                /*
                Task temp = new Task((Action)(() => jobPen.ShowDialog()));
                
                temp.Start();

                temp.Wait();
                try
                {
                    this.Activated += (b, d) =>
                        jopPen.Invoke((Action)(() => jopPen.TopMost = true));
                    this.Deactivate += (b, d) =>
                        jopPen.Invoke((Action)(() => jopPen.TopMost = false));
                }
                catch (Exception) { }
                Func<int, String> temp2 = (param) => { return "ㅇㅇ"; };*/
                PenFortoolStrip.BackColor = Color.Gray;
            }
        }

        /// <summary>'PictureBox'에 관련된 이벤트</summary>
        private void EVENT_PictureBox()
        {
            //
            //Board판이벤트
            pictureBox1.DoubleClick += (b, d) =>
            {
                if (!DetailForToolStrip.Checked)
                {
                    DetailForToolStrip.Checked = true;
                    FRM_COLORLIST.Show();
                }
                colorSave();
            };
            pictureBox1.MouseClick += (b, d) =>
            {
                if (d.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    PenFortoolStrip.PerformClick();
                }
            };

            pictureBox1.MouseMove += (b, d) =>
            {
                if (pictureBox1.Image != null && (d.Location.X >= 0 || d.Location.Y >= 0))
                {
                    try
                    {
                        labelGetColor.Text = "절대위치 : " + xyMouse_absolute.ToString() + "　　　" + PRINTSCREEN.GetPixel(d.X, d.Y).ToString()+                        "　　\n상대위치 : " + xyMouse_relative.ToString(); 


                        xyColor[0] = PRINTSCREEN.GetPixel(d.X, d.Y).R;
                        xyColor[1] = PRINTSCREEN.GetPixel(d.X, d.Y).G;
                        xyColor[2] = PRINTSCREEN.GetPixel(d.X, d.Y).B;
                        xyMouse_relative = d.Location;
                        xyMouse_absolute = new Point(d.Location.X + PRINTSCREEN_LOCATION.X, d.Location.Y + PRINTSCREEN_LOCATION.Y);

                        if (CLASS_DEFAULTOPTION.Using_BackColorChangeForHoverGS == 1)
                        {
                            panel1.BackColor = PRINTSCREEN.GetPixel(d.X, d.Y);
                        }
                        for (int i = 0 ; i < panel1.Controls.Count ; i++)
                        {
                            //if (panel1.Controls[i] is Label) panel1.Controls[i].ForeColor = Color.FromArgb(255 - xyColor[0], 255 - xyColor[1], 255 - xyColor[2]);
                            if (panel1.Controls[i] is Label)
                                panel1.Controls[i].ForeColor = Color.FromArgb(reverseColor(xyColor[0]), reverseColor(xyColor[1]), reverseColor(xyColor[2]));
                        }
                    }
                    catch (Exception) { }
                }
            };
            pictureBox1.MouseLeave += (b, d) =>
            {
                panel1.BackColor = Color.White;
                for (int i = 0 ; i < panel1.Controls.Count ; i++)
                {
                    if (panel1.Controls[i] is Label)
                        panel1.Controls[i].ForeColor = Color.Black;
                }
            };

        }

        /// <summary>'트레이'에 관련된 이벤트</summary>
        private void EVENT_Tray_ContextMenu()
        {
            JobCaptureToolStripMenuItem.Click += (b, d) =>
                {
                    JobCapture();
                };
            showCaptureToolToolStripMenuItem.Click += (b, d) =>
                {
                    this.Visible = true;
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                    notifyIcon1.Visible = false;
                };
            exitToolStripMenuItem.Click += (b, d) =>
                {
                    //ExitCompulsion = true; this.Close();
                    this.Dispose(true);
                };
        }

        /// <summary>그외 자잘자잘한 이벤트</summary>
        private void EVENT_ETC()
        {
            /// 캡쳐ToolStrip의 드랍다운아이템을 클릭시 이벤트
            ToolStripMenuItem[] CaptureForToolStripITEM
                = { 사각형ToolStripMenuItem, 자유형캡쳐ToolStripMenuItem, 창캡쳐ToolStripMenuItem, 전체화면캡쳐ToolStripMenuItem };
            CaptureForToolStrip.DropDownItemClicked += (b, d) =>
                {
                    for (int i = 0 ; i < CaptureForToolStripITEM.Length ; i++)
                    {
                        if (d.ClickedItem.ToString() == CaptureForToolStripITEM[i].Text)
                        {
                            CaptureForToolStripITEM[i].Checked = true;
                        }
                        else
                            CaptureForToolStripITEM[i].Checked = false;
                    }
                };

            #region panelScroll인데 안쓸꺼같다
            /*
                panel1.Scroll += (b, d) =>
                {
                    if (panel1.Size.Width < pictureBox1.Size.Width || panel1.Size.Height < pictureBox1.Size.Height)
                    {
                        ScrollOrientation Direction = d.ScrollOrientation;
                        if (Direction == ScrollOrientation.VerticalScroll) { }//수직
                        else if (Direction == ScrollOrientation.HorizontalScroll)//수평
                        {
                            int Cur_HorisontalScrollValue = this.HorizontalScroll.Value;
                            if (m_Pre_HorisontalScrollValue < Cur_HorisontalScrollValue) { }
                            else m_Pre_HorisontalScrollValue = Cur_HorisontalScrollValue;
                        }
                    }
                };*/

            #endregion
        }
        #endregion






        #region 기타 함수

        /// <summary>
        /// 이미지에서 드래그 시 이미지 확대 및 축소 기능을 수행합니다.
        /// </summary>
        void PictureZoom(bool wheels)
        {
            Point picLoc_sub = this.pictureBox1.Location;
            Size picSiz_sub = this.pictureBox1.Size;
            if (wheels)
            {
                this.pictureBox1.Location = new Point(picLoc_sub.X -= 5, picLoc_sub.Y -= 5);
                this.pictureBox1.Size = new Size(picSiz_sub.Width += 10, picSiz_sub.Height += 10);
            }
            else if (!wheels)
            {
                this.pictureBox1.Location = new Point(picLoc_sub.X += 5, picLoc_sub.Y += 5);
                this.pictureBox1.Size = new Size(picSiz_sub.Width += 10, picSiz_sub.Height += 10);
            }
        }
        #endregion
    }
}
