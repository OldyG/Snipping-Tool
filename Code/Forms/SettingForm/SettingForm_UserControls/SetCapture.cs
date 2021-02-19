using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capture
{
    public partial class SetCapture : UserControl
    {
        public SetCapture(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
            CLASS_DEFAULTOPTION = new DefaultOption(this);
        }
        Form frm;
        DefaultOption CLASS_DEFAULTOPTION;

        private void SetCapture_Load(object sender, EventArgs e)
        {

            ToolTipSet();//툴팁셋팅
            Event_ChangValueSet();//수치변경시 이벤트
            valueSet();//수치 초기화

            for (int i = 0; i < this.Controls.Count; i++)
                this.Controls[i].KeyDown += (b, d) => { if (d.KeyCode == Keys.Escape)this.ParentForm.Close(); };
        }

        private void ToolTipSet()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ToolTipTitle = "설명서";

            tooltip.SetToolTip(label_Sleep, "캡쳐작업 시 메인폼이 찍힐경우 다음 수치를 조절하세요\n(1000=1초)");
            tooltip.SetToolTip(label_Mode, "캡쳐모드를 설정합니다");
            tooltip.SetToolTip(group_DragOption, "드래그 옵션을 설정합니다");
            tooltip.SetToolTip(label_LineColor, "드래그시 선의 색상을 선택합니다");
            tooltip.SetToolTip(label_LineStroke, "드래그시 선의 굵기를 조절합니다");
        }
        private void valueSet()
        {
            this.checkBoxMouseHalfSpeed.Checked = CLASS_DEFAULTOPTION.MouseHalfSpeedGS == 1 ? true : false;
            this.chk_active.Checked = CLASS_DEFAULTOPTION.HotkeyAfterActiveGS == 1 ? true : false;
            this.numeric_Sleep.Value = CLASS_DEFAULTOPTION.SleepValueGS;
            this.comboBox_Mode.SelectedIndex = CLASS_DEFAULTOPTION.CaptureModeGS;
            this.trackBar_LineStroke.Value = CLASS_DEFAULTOPTION.PenstrokeGS;
            this.label3.Text = CLASS_DEFAULTOPTION.PenstrokeGS.ToString();
            this.panel_LineColor.BackColor = CLASS_DEFAULTOPTION.StrokeColorGS;
            this.panel_WhiteFormBackColor.BackColor = CLASS_DEFAULTOPTION.WhiteFormColorGS;
        }
        private void Event_ChangValueSet()
        {
            this.checkBoxMouseHalfSpeed.CheckedChanged += (b, d) => { CLASS_DEFAULTOPTION.MouseHalfSpeedGS = checkBoxMouseHalfSpeed.Checked ? 1 : 0; };
            this.chk_active.CheckedChanged += (b, d) => { CLASS_DEFAULTOPTION.HotkeyAfterActiveGS = chk_active.Checked ? 1 : 0; };
            this.numeric_Sleep.ValueChanged += (b, d) => { CLASS_DEFAULTOPTION.SleepValueGS = int.Parse(numeric_Sleep.Value.ToString()); };
            this.comboBox_Mode.SelectedIndexChanged += (b, d) => { CLASS_DEFAULTOPTION.CaptureModeGS = comboBox_Mode.SelectedIndex; };
            this.trackBar_LineStroke.ValueChanged += (b, d) => { CLASS_DEFAULTOPTION.PenstrokeGS = trackBar_LineStroke.Value; label3.Text = trackBar_LineStroke.Value.ToString(); };
            this.panel_LineColor.Click += (b, d) =>
            {
                ColorDialog temp = new ColorDialog();
                temp.Color = CLASS_DEFAULTOPTION.StrokeColorGS;
                temp.FullOpen = true;
                if (temp.ShowDialog() == DialogResult.OK) panel_LineColor.BackColor = CLASS_DEFAULTOPTION.StrokeColorGS = temp.Color;
            };
            this.panel_WhiteFormBackColor.Click += (b, d) =>
            {
                ColorDialog temp = new ColorDialog();
                temp.Color = CLASS_DEFAULTOPTION.WhiteFormColorGS;
                temp.FullOpen = true;
                if (temp.ShowDialog() == DialogResult.OK) panel_WhiteFormBackColor.BackColor = CLASS_DEFAULTOPTION.WhiteFormColorGS = temp.Color;
            };

        }
    }
}
