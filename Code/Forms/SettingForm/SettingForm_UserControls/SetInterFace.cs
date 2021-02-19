using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capture
{
    public partial class SetInterFace : UserControl
    {

        public SetInterFace(Form frm)
        {
            InitializeComponent();
            if (frm is MainForm)
                FRM_MAINFORM = frm as MainForm;
            else if (frm is Form)
                this.frm = frm as Form;
            CLASS_DEFAULTOPTION = new DefaultOption(this);
        }
        MainForm FRM_MAINFORM;
        Form frm;
        DefaultOption CLASS_DEFAULTOPTION;


        private void SetInterFace2_Load(object sender, EventArgs e)
        {
            ToolTipSet();           // 툴팁셋팅
            valueSet_AtFirst();     // 수치 초기화 먼저할것들
            Event_ChangValueSet();  // 수치변경시 이벤트
            valueSet();             // 수치 초기화
        }


        private void ToolTipSet()
        {
        }

        private bool chk_temp()
        {
            if (CLASS_DEFAULTOPTION.Using_WinRegGS == 1 && CLASS_DEFAULTOPTION.Using_JobCaptureAfterProgramStartGS == 1)
            {
                return true;
            }
            return false;
        }
        private void Event_ChangValueSet()
        {

            Control[] toolStripOfMainForm = FRM_MAINFORM.Controls.Find("toolStrip1", false);
            Control[] menuStripOfMainForm = FRM_MAINFORM.Controls.Find("menuStrip1", false);

            this.chk_BoxExitTray.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.Using_TrayGS = chk_BoxExitTray.Checked ? 1 : 0;

            this.chk_Opactity.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.EffectOpacityGS = (chk_Opactity.Checked ? 1 : 0);
            this.chk_ControlMove.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.EffectControlMoveGS = chk_ControlMove.Checked ? 1 : 0;
            this.이미지에마우스오버시배경색바꾸기.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.Using_BackColorChangeForHoverGS = (이미지에마우스오버시배경색바꾸기.Checked ? 1 : 0);
            this.chk_JobCaptureAfterProgramStart.CheckedChanged += (b, d) =>
                {
                    if (chk_JobCaptureAfterProgramStart.Checked && CLASS_DEFAULTOPTION.Using_WinRegGS == 1)
                    {
                        if (MessageBox.Show("[" + chk_WinStartAction.Text + "]와 혼용하는것을 권장하지 않습니다. 그래도 사용하시겠습니까?\n컴퓨터 키자마자 하얘져요ㅠ", "캡쳐도구 알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        { }
                        else
                            chk_JobCaptureAfterProgramStart.Checked = false;

                    }

                    CLASS_DEFAULTOPTION.Using_JobCaptureAfterProgramStartGS = chk_JobCaptureAfterProgramStart.Checked ? 1 : 0;
                };


            int tem2p=0;
            this.chk_WinStartAction.CheckedChanged += (b, d) =>
                {
                    this.ParentForm.Text = tem2p++.ToString();
                    RegistryTest reg = new RegistryTest();
                    bool flag = true;
                    if (chk_WinStartAction.Checked)
                    {
                        if (CLASS_DEFAULTOPTION.Using_JobCaptureAfterProgramStartGS == 1)
                        {
                            if (MessageBox.Show("[" + chk_JobCaptureAfterProgramStart.Text + "]와 혼용하는것을 권장하지 않습니다. 그래도 사용하시겠습니까?\n컴퓨터 키자마자 하얘져요ㅠ", "캡쳐도구 알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                flag = true;
                            }
                            else
                            {
                                chk_WinStartAction.Checked = false;
                            }
                        }

                        if (flag)
                        {
                            chk_WinStartAction.CheckState = reg.regInsert() ? CheckState.Checked : CheckState.Unchecked;
                            
                            
                        }
                    }
                    else
                    {
                        reg.regRemove();
                    }

                    CLASS_DEFAULTOPTION.Using_WinRegGS = chk_WinStartAction.Checked ? 1 : 0;

                };
            this.trackBar_ToolStripSize.ValueChanged += (b, d) =>
                {
                    CLASS_DEFAULTOPTION.ToolStripSizeGS = trackBar_ToolStripSize.Value;
                    if (FRM_MAINFORM.pictureBox1.Image == null)
                        FRM_MAINFORM.Size = new Size(CLASS_DEFAULTOPTION.ToolStripSizeGS * 15, CLASS_DEFAULTOPTION.ToolStripSizeGS + 70);

                    Label_ToolStripSize_Value.Text = trackBar_ToolStripSize.Value.ToString();
                    (toolStripOfMainForm[0] as ToolStrip).ImageScalingSize = new Size(trackBar_ToolStripSize.Value, trackBar_ToolStripSize.Value);
                    FRM_MAINFORM.Size = new Size(FRM_MAINFORM.Size.Width + 1, FRM_MAINFORM.Size.Height);
                    FRM_MAINFORM.Size = new Size(FRM_MAINFORM.Size.Width - 1, FRM_MAINFORM.Size.Height);
                };
            this.panel_ToolStrip_Color.Click += (b, d) =>
                {
                    ColorDialog temp = new ColorDialog();
                    temp.Color = CLASS_DEFAULTOPTION.ToolStrip_BackColorGS;
                    temp.FullOpen = true;
                    if (temp.ShowDialog() == DialogResult.OK)
                        (menuStripOfMainForm[0] as MenuStrip).BackColor = panel_ToolStrip_Color.BackColor = CLASS_DEFAULTOPTION.ToolStrip_BackColorGS = temp.Color;
                };

        }

        private void valueSet()
        {
            this.chk_BoxExitTray.Checked = CLASS_DEFAULTOPTION.Using_TrayGS == 1 ? true : false;
            this.chk_Opactity.Checked = CLASS_DEFAULTOPTION.EffectOpacityGS == 1 ? true : false;
            this.chk_ControlMove.Checked = CLASS_DEFAULTOPTION.EffectControlMoveGS == 1 ? true : false;
            this.trackBar_ToolStripSize.Value = CLASS_DEFAULTOPTION.ToolStripSizeGS;
            this.Label_ToolStripSize_Value.Text = trackBar_ToolStripSize.Value.ToString();
            this.panel_ToolStrip_Color.BackColor = CLASS_DEFAULTOPTION.ToolStrip_BackColorGS;
            this.이미지에마우스오버시배경색바꾸기.Checked = CLASS_DEFAULTOPTION.Using_BackColorChangeForHoverGS == 1 ? true : false;

        }
        private void valueSet_AtFirst()
        {
            {//윈도우 시작시 프로그램 실행
                RegistryTest reg = new RegistryTest();
                this.chk_WinStartAction.Checked = reg.chkExist() == 2 ? true : false;
                CLASS_DEFAULTOPTION.Using_WinRegGS = this.chk_WinStartAction.Checked ? 1 : 0;
            }
            this.chk_JobCaptureAfterProgramStart.Checked = CLASS_DEFAULTOPTION.Using_JobCaptureAfterProgramStartGS == 1 ? true : false;
        }

    }

}
