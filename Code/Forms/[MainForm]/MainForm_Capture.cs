using System.Drawing;
using System.Windows.Forms;
/*추가 using*/

/*  [함수목록]
 *      JobCature()         :: BackImage 폼과 White폼을 호출하여 실질적인 캡쳐작업영역으로 들어가는 함수
 */
namespace Capture
{
    public partial class MainForm
    {
        /// <summary>
        /// BackImage 폼과 White폼을 호출하여 실질적인 캡쳐작업영역으로 들어가는 함수
        /// </summary>


        public bool WHITEFROM_ACTIVED = false; //중복캡쳐를 막기위함 true : 켜져있는상태, false : 종료된상태
        private void JobCapture()
        {
            if (WHITEFROM_ACTIVED == false)
            {
                WHITEFROM_ACTIVED = true;

                this.Hide();
                #region FRM_COLORLIST_reset
                {
                    FRM_COLORLIST.Hide();
                    FRM_COLORLIST.listView1.Clear();
                    FRM_COLORLIST.listView1.Columns.Add("절대위치");
                    FRM_COLORLIST.listView1.Columns.Add("상대위치");
                    FRM_COLORLIST.listView1.Columns.Add("RGB");
                    FRM_COLORLIST.listView1.Columns[0].Width = 100;
                    FRM_COLORLIST.listView1.Columns[1].Width = 100;
                    FRM_COLORLIST.listView1.Columns[2].Width = 150;
                }
                #endregion

                /*컴퓨터사양에 따라 this.Hide가 표시될수 있어 delay값을 사용자가 삽입한다.*/
                System.Threading.Thread.Sleep(CLASS_DEFAULTOPTION.SleepValueGS);

                /*Instance for tempCapture*/
                PRINTSCREEN = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(PRINTSCREEN as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, PRINTSCREEN.Size);

                /*Instance Form*/
                FRM_BACKIMAGE = new backImage(this);
                FRM_WHITEFORM = new whiteForm(this);
                FRM_BACKIMAGE.Owner = this;
                FRM_WHITEFORM.Owner = this;

                /*Application for Win's Screen*/
                //Clipboard.SetImage(PRINTSCREEN);
                FRM_BACKIMAGE.panel1.BackgroundImage = PRINTSCREEN;

                /*Show All form*/
                FRM_BACKIMAGE.Show();
                FRM_WHITEFORM.Show();
                this.Show();
                this.TopMost = true;
                #region FRM_WHITEFORM이 닫힐 때 이벤트
                {
                    FRM_WHITEFORM.FormClosing += (b, d) =>
                        {
                            CLASS_MAGNET.FormMagnet_ready = false;
                            FormOpacity FO = new FormOpacity(FRM_WHITEFORM, 40, 10);
                            FO.formToDimly(false, 0);
                            //ColorList의 Show,Hide결정
                            if (DetailForToolStrip.Checked == true)
                                FRM_COLORLIST.Show();

                            SavedForToolStrip.Enabled = true;
                            SavedForMenuStrip.Enabled = true;

                            /*Bring to image*/
                            pictureBox1.Image = PRINTSCREEN; // Withe로부터 받은 캡쳐이미지
                            if (CLASS_DEFAULTOPTION.using_ClipBoardGS == 1)
                                Clipboard.SetImage(PRINTSCREEN);


                            /*Form&image's size control*/
                            pictureBox1.Size = PRINTSCREEN.Size;
                            this.Size = new Size(pictureBox1.Width + 100 + 10, pictureBox1.Height + 100 + toolStrip1.Size.Height + menuStrip1.Size.Height + 150);   //MainForm 사이즈 재조절
                            //if (this.Size.Width <= 500)   this.Size = new Size(500, this.Size.Height); //[오류] 창 최소화작업시 창이 쪼마내짐
                            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height - pictureBox1.Height) / 2);

                            Point temp = new Point(PRINTSCREEN_LOCATION.X - 55, PRINTSCREEN_LOCATION.Y - (65 + toolStrip1.Size.Height));

                            /*Prevention for SizeOverflow*/

                            if (this.WindowState != FormWindowState.Minimized)
                            {
                                if (temp.X <= 0 && this.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                                    this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, this.Size.Height);
                                if (temp.Y <= 0 && this.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
                                    this.Size = new Size(this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height);

                                temp.X = temp.X < 0 ? 0 : temp.X;
                                temp.Y = temp.Y < 0 ? 0 : temp.Y;

                                temp.X = temp.X + this.Size.Width > Screen.PrimaryScreen.Bounds.Width ? temp.X = Screen.PrimaryScreen.Bounds.Width - this.Size.Width : temp.X;
                                temp.Y = temp.Y + this.Size.Height > Screen.PrimaryScreen.WorkingArea.Height ? Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height : temp.Y;
                            }
                            this.Location = temp;

                            if (pictureBox1.Image == null)
                            {
                                WHITEFROM_ACTIVED = true;
                                SavedForToolStrip.Enabled = false;
                                SavedForMenuStrip.Enabled = false;
                                CopyForToolStrip.Enabled = false;
                                CopyForMenuStrip.Enabled = false;
                                CharacterFortoolStrip.Enabled = false;
                                PenFortoolStrip.Enabled = false;
                                DetailForToolStrip.Enabled = false;
                            }
                            else
                            {
                                WHITEFROM_ACTIVED = false;
                                SavedForToolStrip.Enabled = true;
                                SavedForMenuStrip.Enabled = true;
                                CopyForToolStrip.Enabled = true;
                                CopyForMenuStrip.Enabled = true;
                                CharacterFortoolStrip.Enabled = true;
                                PenFortoolStrip.Enabled = true;
                                DetailForToolStrip.Enabled = true;
                            }
                            FRM_BACKIMAGE.Close();
                            wSize.Text = PRINTSCREEN.Size.ToString();
                            wLocation.Text = PRINTSCREEN_LOCATION.ToString();
                            if (CLASS_DEFAULTOPTION.AutoSaveGS == 1)
                                FuncSave_Auto();
                            this.Focus();
                            this.TopMost = false;
                            CLASS_MAGNET.FormMagnet_ready = true;

                        };
                }
                #endregion

                this.Activate();
                this.Focus();
                this.Show();

            }
        }
    }
}
