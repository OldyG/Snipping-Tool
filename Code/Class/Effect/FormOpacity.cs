using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Capture
{
    class FormOpacity
    {
        Form frm;
        int interval;
        int division;
        System.Timers.Timer timer;
        DefaultOption CLASS_DEFAULTOPTION;

        /// <summary>
        /// 폼이 서서히 선명해지거나 투명해지는 클래스
        /// </summary>
        /// <param name="frm">적용할 폼입니다. this 적음 됨</param>
        /// <param name="interval">timer의 interval 수치</param>
        /// <param name="division">수치가 증가할수록 정교하지만 느려짐</param>
        public FormOpacity(Form frm, int interval = 1, int division = 10)
        {
            CLASS_DEFAULTOPTION = new DefaultOption(this);
            this.frm = frm as Form;
            this.interval = interval;
            this.division = division;
        }

        /*
        public void formToSharp(double end = 1, double start = 0)
        {
            if (CLASS_DEFAULTOPTION.EffectOpacityGS == 1)
            {
                timer = new System.Timers.Timer();
                timer.Interval = interval;
                frm.Opacity = start;
                timer.Elapsed += (b, d) =>
                    {
                        frm.Opacity += 1 / (float)division;
                        if (frm.Opacity >= end)
                        {
                            frm.Opacity = end;
                            timer.Stop();
                        }
                    };
                timer.Start();
            }
        }*/
        /*
        public void formToDimly(bool formClose, double end = 0, double start = 1)
        {
            if (CLASS_DEFAULTOPTION.EffectOpacityGS == 1)
            {
                timer = new System.Timers.Timer();
                timer.Interval = interval;
                frm.Opacity = start;
                timer.Elapsed += (b, d) =>
                    {
                        frm.Opacity -= 1 / (float)division;
                        if (frm.Opacity <= end)
                        {
                            frm.Opacity = end;
                            timer.Stop();
                            if (formClose)
                            {
                                frm.Close();
                                frm.Dispose();
                            }
                        }
                    };
                timer.Start();
            }
        }*/
        public void formToSharp(double end = 1, double start = 0)
        {
            int cnt = 0;
            if (CLASS_DEFAULTOPTION.EffectOpacityGS == 1)
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = interval;
                frm.Opacity = start;
                timer.Elapsed += (b, d) =>
                {
                    movecontrol(1, division);
                    cnt++;
                    if (frm.Opacity >= end || cnt >= division)
                    {
                        movecontrolEND(end);
                        timer.Stop();
                        timer.Dispose();
                    }
                };
                timer.Start();
            }
        }
        public void formToDimly(bool formClose, double end = 0, double start = 1)
        {
            int cnt = 0;
            if (CLASS_DEFAULTOPTION.EffectOpacityGS == 1)
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = interval;
                frm.Opacity = start;
                timer.Elapsed += (b, d) =>
                {
                    movecontrol(-1, division);
                    cnt++;
                    if (frm.Opacity <= end || cnt >= division)
                    {
                        movecontrolEND(end);
                        timer.Stop();
                        timer.Dispose();
                        if (formClose)
                        {
                            frm.Close();

                            frm.Dispose();
                        }
                    }
                };
                timer.Start();

            }
        }
        private void movecontrol(int varu, int division)
        {
            if (frm.InvokeRequired)
                frm.Invoke(new MethodInvoker(delegate() { frm.Opacity += varu / (float)division; }));
            else
                frm.Opacity += varu / (float)division;
        }
        private void movecontrolEND(double varu)
        {
            if (frm.InvokeRequired)
                frm.Invoke(new MethodInvoker(delegate() { frm.Opacity = varu; }));
            else
                frm.Opacity = varu;
        }

    }
}


