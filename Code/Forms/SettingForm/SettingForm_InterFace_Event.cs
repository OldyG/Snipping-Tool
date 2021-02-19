using System;
using System.Windows.Forms;

namespace Capture
{
    public partial class SettingForm
    {


        object[] Pack_SetInterFace_CheckBox;
        void getChild()
        {
            int cnt = 0;
            for (int i = 0; i < USER_SET_INTERFACE.Controls.Count; i++)
            {
                if (USER_SET_INTERFACE.Controls[i] is CheckBox)
                {
                    Array.Resize<object>(ref Pack_SetInterFace_CheckBox, cnt + 1);
                    Pack_SetInterFace_CheckBox[cnt] = new object();
                    Pack_SetInterFace_CheckBox[cnt++] = USER_SET_INTERFACE.Controls[i];
                }
                if (USER_SET_INTERFACE.Controls[i].HasChildren)
                {
                    for (int j = 0; j < USER_SET_INTERFACE.Controls[i].Controls.Count; j++)
                    {
                        if (USER_SET_INTERFACE.Controls[i].Controls[j] is CheckBox)
                        {
                            Array.Resize<object>(ref Pack_SetInterFace_CheckBox, cnt + 1);
                            Pack_SetInterFace_CheckBox[cnt] = new object();
                            Pack_SetInterFace_CheckBox[cnt++] = USER_SET_INTERFACE.Controls[i].Controls[j];
                        }
                        if (USER_SET_INTERFACE.Controls[i].Controls[j].HasChildren)
                        {
                            for (int a = 0; a < USER_SET_INTERFACE.Controls[i].Controls[j].Controls.Count; a++)
                            {
                                if (USER_SET_INTERFACE.Controls[i].Controls[j].Controls[a] is CheckBox)
                                {
                                    Array.Resize<object>(ref Pack_SetInterFace_CheckBox, cnt + 1);
                                    Pack_SetInterFace_CheckBox[cnt] = new object();
                                    Pack_SetInterFace_CheckBox[cnt++] = USER_SET_INTERFACE.Controls[i].Controls[j].Controls[a];
                                }
                            }
                        }
                    }
                }
            }
        }


        void Interface_Event()
        {
            getChild();
            /*
            for (int i = 0; i < Pack_SetInterFace_CheckBox.Length; i++)
            {
                CheckBox tt = Pack_SetInterFace_CheckBox[i] as CheckBox;
            }
            buttonExit.Click += (b, d) => { this.Close(); };
            USER_SET_INTERFACE.ToolStrip표시.CheckedChanged += (b, d) =>
            {
                if (USER_SET_INTERFACE.ToolStrip표시.Checked) FRM_MAINFORM.toolStrip1.Visible = true;
                else FRM_MAINFORM.toolStrip1.Visible = false;
            };
            */
            this.KeyDown += (b, d) => { if (d.KeyCode == Keys.Escape) this.Close(); };
        }
    }
}
