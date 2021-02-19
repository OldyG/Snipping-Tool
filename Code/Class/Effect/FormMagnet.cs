using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Capture
{
    class FormMagnet
    {
        int winWidth;
        int winHeight;
        int locX;
        int locY;
        int sizX;
        int sizY;
        int locsizX;
        int locsizY;
        int gap=30;
        public Boolean FormMagnet_ready = true;


        public FormMagnet(Form frm, int gap = 30)
        {
            this.gap = gap;
            winWidth = Screen.PrimaryScreen.WorkingArea.Width;
            winHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int temp = 0;
            frm.Move += (b, d) => 
            {
                if (FormMagnet_ready == true)
                {
                    //if(temp!=0)
                    {
                        //값 가져오기
                        locX = frm.Location.X;
                        locY = frm.Location.Y;
                        sizX = frm.Size.Width;
                        sizY = frm.Size.Height;
                        locsizX = locX + sizX;
                        locsizY = locY + sizY;

                        if (locX < gap || locY < gap)
                            frm.Location = new Point(locX < gap ? 0 : locX, locY < gap ? 0 : locY);
                        if (locsizX > winWidth - gap || locsizY > winHeight - gap)
                            frm.Location = new Point(locsizX > winWidth - gap ? winWidth - sizX : locsizX - sizX, locsizY > winHeight - gap ? winHeight - sizY : locsizY - sizY);
                    }
                }
            };
        }
    }
}
