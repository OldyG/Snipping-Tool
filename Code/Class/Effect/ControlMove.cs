using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Capture
{
    class ControlMove
    {
        DefaultOption CLASS_DEFAULTOPTION;		
        Control obj;				    // 사용자로부터 받을 컨트롤 개체입니다.
        Point startingPoint;			// 움직이기 시작하는 첫지점입니다.
        Point endingPoint;			    // 멈추는 지점입니다.
        int intervar;				    // Timer에서 interval 수치입니다.
        int division;				    // 1tick당 움직를 등분한 수치입니다(startingPoint와 endingPoint의 차이에서 division을 나누는 형식입니다.)
        int gap_X;				        // startingPoint.X 와 endingPoint.X의 차이입니다.
        int gap_Y;				        // startingPoint.Y 와 endingPoint.Y의 차이입니다.
        /// <summary>
        /// 해당 컨트롤을 startingPoint 좌표에서 endingPoint까지 서서히 이동합니다.
        /// <see cref="ConsolApp1.program"/>
        /// </summary>
        /// <param name="aboutControl">해당 컨트롤</param>
        /// <param name="startingPoint">출발점</param>
        /// <param name="endingPoint">도착점</param>
        /// <param name="option">0~4까지의 옵션이 있습니다.
        /// <para> 0 : 기본</para>
        /// <para> 1 : 점점빠르게</para>
        /// <para> 2 : 점점느리게</para>
        /// <para> 3 : 빨라졌다 느려짐</para>
        /// <para> 4 : 느려졌다 빨라짐</para>
        /// <para> 그외 : exeption</para>
        /// </param>
        /// <param name="intervar">timer의 interval수치</param>
        /// <param name="division">수치가 높을수록 정교하지만 느려짐 <para>[주의] startingPoint의 endingPoint의 차이보다 큰 수치일경우 차이값으로 수정됨</para></param>
        public ControlMove(Control aboutControl, Point startingPoint, Point endingPoint, int option = 0, int intervar = 1, int division = 999)
        {
            CLASS_DEFAULTOPTION = new DefaultOption(this);
            this.obj = aboutControl as Control;
            this.startingPoint = startingPoint;
            this.endingPoint = endingPoint;
            this.intervar = intervar;
            this.gap_X = endingPoint.X - startingPoint.X;
            this.gap_Y = endingPoint.Y - startingPoint.Y;

            if ((Math.Abs(gap_X) > Math.Abs(gap_Y) ? Math.Abs(gap_X) : Math.Abs(gap_Y)) < division)
                this.division = (Math.Abs(gap_X) > Math.Abs(gap_Y) ? Math.Abs(gap_X) : Math.Abs(gap_Y));
            else this.division = division;

        }

        public void MoveStart(int Sleep = 0)
        {
            if (CLASS_DEFAULTOPTION.EffectControlMoveGS == 1)
            {
                System.Threading.Thread temp = new System.Threading.Thread(MoveStart_sub);
                temp.Start(Sleep);
            }
        }
        private void MoveStart_sub(object Sleep)
        {
            
            obj.Location = this.startingPoint;

            int cnt = 0;
            Int32 cureentTic = Environment.TickCount;
            while (Environment.TickCount < cureentTic + (Int32)Sleep) { if (cnt == 0) { obj.Visible = false; cnt++; } }
            obj.Visible = true;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = this.intervar;

            int chk_X = chk(gap_X);
            int chk_Y = chk(gap_Y);
            timer.Elapsed += (b, d) =>
                {
                    movecontrol(new Point(obj.Location.X + (gap_X / division), obj.Location.Y + (gap_Y / division)));

                    if (chk_X == 1) { if (obj.Location.X >= endingPoint.X) timerStop(ref timer); }
                    else if (chk_X == 2) { if (obj.Location.X <= endingPoint.X) timerStop(ref timer); }
                    if (chk_Y == 1) { if (obj.Location.Y >= endingPoint.Y)  timerStop(ref timer); }
                    else if (chk_Y == 2) { if (obj.Location.Y <= endingPoint.Y) timerStop(ref timer); }
                };
            if (!(chk_X == 0 && chk_Y == 0)) timer.Start();
        }
        public int chk(int tt) //1:양수 //2:음수  0:0
        {

            if (tt < 0) return 2;
            if (tt > 0) return 1;
            return 0;
        }
        void timerStop(ref System.Timers.Timer timer)
        {
            timer.Stop();
            if (obj.InvokeRequired)
            {
                obj.Invoke(new MethodInvoker(delegate()
                {
                    obj.Location = endingPoint;
                }));
            }
            else
                obj.Location = endingPoint;
        }
        /*
        private void timerStop(ref System.Timers.Timer timer)
        {
            timer.Stop();
            obj.Location = endingPoint;
        }*/

        private void movecontrol(Point p)
        {
            if (obj.InvokeRequired)
                obj.Invoke(new MethodInvoker(delegate() { obj.Location = p; }));
            else
                obj.Location = p;
        }


    }
}
