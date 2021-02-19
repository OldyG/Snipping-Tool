using System;
using System.Drawing;
using System.Windows.Forms;


/*    [함수목록]
 *      reverseColor(int)           :: 색상반전을 보다 눈에띄게 수정해주는 함수입니다.
 *      MSG_Use(String)             :: 3000ms동안 현재 폼의 Text로 메세지를 보여줍니다.
 *      MsgForThisText(object)      :: MSG_Use(String)으로 사용할것
 *      ControlsLoc()               :: 폼의 초기생성,위치,크기 변경시 공동으로 사용되는 코드로 레이아웃들의 위치를 설정해주는 코드입니다.
 */


namespace Capture
{
    public partial class MainForm
    {

        /// <summary>
        /// 색상반전을 보다 눈에 띄게 수정해주는 함수입니다.
        /// </summary>
        /// <param name="xyColor">R,G,B 값들을 입력해줍니다. 16진수가 아닌 RGB개수만큼 함수를 호출해야합니다. </param>
        public int reverseColor(int xyColor)
        {
            if (Math.Abs((255 - xyColor) - xyColor) < 85)
                return xyColor > 255 - xyColor ? 255 - xyColor - 85 : 255 - xyColor + 85;
            else
                return 255 - xyColor;
        }
        public Color reverseColor(Color color)
        {
            Color temp = new Color();
            temp = Color.FromArgb(reverseColor(color.R),reverseColor(color.G),reverseColor(color.B));
            return temp;
        }


        int sleepValue = 3000;
        /// <summary>
        /// 3000ms동안 현재 폼의 Text로 메세지를 보여줍니다.
        /// </summary>
        /// <param name="text">보여줄 문자를 입력하세요</param>
        void MSG_USE(String text,int sleepValue = 3000)
        {
            this.sleepValue = sleepValue;
            System.Threading.Thread MESSAGE_THREADING = new System.Threading.Thread(MsgForThisText);
            MESSAGE_THREADING.Start(text);
        }

        /// <summary>
        /// MSG_Use(String)으로 사용할것
        /// <para><Thread타입 MESSAGE_THREADING의 호출용으로, 전달된 인자를 3000ms 동안 보여줍니다.</para>
        /// </summary>
        /// <param name="Msg"></param>
        private void MsgForThisText(object Msg)
        {
            if (Msg is string)
            {
                this.Text = Msg as String;
                System.Threading.Thread.Sleep(this.sleepValue);
                this.Text = STATIC_THIS_NAME;
            }
            else
                throw new Exception("String타입이 아닙니다.");
        }


        /// <summary>
        /// 폼의 초기생성,위치,크기 변경시 공동으로 사용되는 코드로 레이아웃들의 위치를 설정해주는 코드입니다.
        /// </summary>
        void ControlsLoc()
        {
            CLASS_MAGNET.FormMagnet_ready = false;
            panel1.Location = new Point(0, menuStrip1.Size.Height + toolStrip1.Size.Height);
            panel1.Size = new Size(this.Size.Width - panel1.Location.X - 20, this.Size.Height - panel1.Location.Y - 40);
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Width) / 2, (panel1.Height - pictureBox1.Height) / 2);

            labelLocation.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Size.Height + 10);
            //labelLocation.Location = new Point(this.Right/3, pictureBox1.Location.Y + pictureBox1.Size.Height + 10);
            wLocation.Location = new Point(labelLocation.Left + 70, labelLocation.Top);
            labelSize.Location = new Point(pictureBox1.Left, labelLocation.Top + 15);
            wSize.Location = new Point(labelLocation.Left + 70, wLocation.Top + 15);
            labelGetColor.Location = new Point(labelLocation.Left + 250, labelLocation.Top);
            panel1.BackColor = Color.Transparent;
            Point temp = new Point(PRINTSCREEN_LOCATION.X - 55, PRINTSCREEN_LOCATION.Y - (65 + toolStrip1.Size.Height));

            //*Prevention for SizeOverflow*

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

            if (temp != new Point(0, 0))
                this.Location = temp;
            else
                this.Location = temp;
            CLASS_MAGNET.FormMagnet_ready = true;
        }


    }
}
