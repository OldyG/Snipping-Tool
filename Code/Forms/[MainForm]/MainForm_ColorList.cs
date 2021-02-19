using System.Drawing;
using System.Windows.Forms;

namespace Capture
{
    public partial class MainForm
    {

        /// <summary>
        /// FORM- ColorList의 리스트뷰에 입력 동작하는 코드입니다.
        /// </summary>
        private void colorSave()
        {
            if (pictureBox1.Image == null)
            {
                MSG_USE("캡쳐작업 후 가능합니다");
                return;
            }
            for (int i = 0; i < FRM_COLORLIST.listView1.Items.Count; i++)
                if (xyMouse_absolute.ToString() == FRM_COLORLIST.listView1.Items[i].Text) return;

            string tempColor = xyColor[0].ToString() + xyColor[1].ToString();
            ListViewItem temp = new ListViewItem(xyMouse_absolute.ToString());
            temp.BackColor = Color.FromArgb(xyColor[0], xyColor[1], xyColor[2]);
            temp.ForeColor = Color.FromArgb(reverseColor(xyColor[0]), reverseColor(xyColor[1]), reverseColor(xyColor[2]));
            temp.SubItems.Add(xyMouse_relative.ToString());
            temp.SubItems.Add("{" + xyColor[0].ToString() + "," + xyColor[1].ToString() + "," + xyColor[2].ToString() + "}");
            FRM_COLORLIST.listView1.Items.Add(temp);
        }



    }
}
