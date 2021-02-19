using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;



namespace Capture
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="ControlType">Control 또는 폼이름을 적으세요</typeparam>
    class ControlsCollector<ControlType>
    {
        ControlType mainControls;
        Control mainControls_sub;
        

        public ControlsCollector(ControlType frm)
        {
            if (frm is Control)
            {
                 mainControls = frm;
                 mainControls_sub = frm as Control;
            }
            else return;
        }

        private void find()
        {
            if (mainControls_sub.HasChildren)
            {
                for (int i = 0; i < mainControls_sub.Controls.Count; i++)
                { 
                
                }
            }
        }


    }
}
