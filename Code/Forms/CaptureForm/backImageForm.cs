using System;
using System.Windows.Forms;

namespace Capture
{
    public partial class backImage : Form
    {
        public backImage(Form frm) { InitializeComponent(); }

        /*
         * MainForm에서 전달 받은 현재 바탕화면을 표현하는 폼입니다.
         */

        private void panel1_BackgroundImageChanged(object sender, EventArgs e)
        {
            this.Size = panel1.BackgroundImage.Size;
        }

    }
}
