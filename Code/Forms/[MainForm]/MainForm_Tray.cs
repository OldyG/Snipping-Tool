using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Capture
{
    public partial class MainForm 
    {
        void UsingTray()
        {
            //this.WindowState = FormWindowState.Minimized;
            
            notifyIcon1.Visible = true;
            this.Hide();
            

            notifyIcon1.MouseClick += (b, d) =>
                {
                    if (d.Button == MouseButtons.Left)
                    {
                        this.Visible = true;
                        this.ShowInTaskbar = true;
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();
                        notifyIcon1.Visible = false;
                    }
                    else if (d.Button == MouseButtons.Right)
                    {
                        //notifyIcon1.ContextMenu.Show(null,new Point(0,0));
                        notifyIcon1.ContextMenuStrip = contextMenuOfTray;
                    }
                };
            
        }
    }
}
