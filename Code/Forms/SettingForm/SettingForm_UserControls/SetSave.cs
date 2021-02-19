using System;
using System.Windows.Forms;
using System.Drawing;


namespace Capture
{

    public partial class SetSave : UserControl
    {


        public SetSave(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
            CLASS_DEFAULTOPTION = new DefaultOption(this);
        }

        Form frm;
        DefaultOption CLASS_DEFAULTOPTION;
        FolderBrowserDialog DIALOG_PATH;

        private void AutoSavedSetting_Load(object sender, EventArgs e)
        {
            ToolTipSet();//툴팁셋팅
            Event_ChangValueSet();//수치변경시 이벤트
            try
            {
                valueSet();//수치 초기화            
            }
            catch (Exception) { }

            for (int i = 0 ; i < this.Controls.Count ; i++)
                this.Controls[i].KeyDown += (b, d) => { if (d.KeyCode == Keys.Escape)this.ParentForm.Close(); };

        }
        private void ToolTipSet()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ToolTipTitle = "설명서";

            tooltip.SetToolTip(chk_AutoSave, "체크 시 설정된 경로에 자동으로 저장합니다.");
            tooltip.SetToolTip(labelName, "저장시 기본 이름을 설정합니다.");
            tooltip.SetToolTip(groupBoxSavePath, "저장위치를 설정합니다.\n존재하지 않는 경로 설정시\"내 사진\"으로 자동설정됩니다");
            tooltip.SetToolTip(radioButtonList, "슈퍼경로에 저장합니다");
            tooltip.SetToolTip(radioButtonstaticPath, "사용자가 설정한 경로를 설정합니다");
            tooltip.SetToolTip(labelFilter, "이미지 포맷을 설정합니다");
        }
        private void valueSet()
        {
            chk_AutoSave.Checked = CLASS_DEFAULTOPTION.AutoSaveGS == 1 ? true : false;
            chk_AutoSave_ChildDrectory.Checked = CLASS_DEFAULTOPTION.AutoSaveToChildDriectoryGS == 1 ? true : false;
            chk_AutoSave_ChildDrectory.Enabled = chk_AutoSave.Checked ? true : false;
            chk_afterClipBoard.Checked = CLASS_DEFAULTOPTION.using_ClipBoardGS == 1 ? true : false;

            textBoxName.Text = CLASS_DEFAULTOPTION.SavedOption_NameGS;
            textBoxPath.Text = CLASS_DEFAULTOPTION.SavedOption_DirectoryGS;



            radioButtonstaticPath.Checked = CLASS_DEFAULTOPTION.AutoSaveGS == 1 ? true : false;


            if (radioButtonList.Checked == true)
            {
                comboBoxList.Enabled = true;
                textBoxPath.Enabled = false;
                buttonFindPath.Enabled = false;
                CLASS_DEFAULTOPTION.SavedOption_PathModeGS = 0;
            }
            else
            {
                comboBoxList.Enabled = false;
                textBoxPath.Enabled = true;
                buttonFindPath.Enabled = true;
                CLASS_DEFAULTOPTION.SavedOption_PathModeGS = 1;
            }
            chk_UseDirName.Checked = CLASS_DEFAULTOPTION.UseDirNameGS == 1 ? true : false;
            chk_UseDirTime.Checked = CLASS_DEFAULTOPTION.UseDirTimeGS == 1 ? true : false;

        }
        private void Event_ChangValueSet()
        {

            linkLabel_DateTimeStyle.Click += (b, d) =>
                {
                    DateTimeStyle tt = new DateTimeStyle(linkLabel_DateTimeStyle);
                    tt.Location = new Point(linkLabel_DateTimeStyle.PointToScreen(new Point(0, 0)).X + linkLabel_DateTimeStyle.Width, linkLabel_DateTimeStyle.PointToScreen(new Point(0, 0)).Y);
                    tt.ShowDialog();
                    tt.Location = new Point(linkLabel_DateTimeStyle.PointToScreen(new Point(0, 0)).X + linkLabel_DateTimeStyle.Width, linkLabel_DateTimeStyle.PointToScreen(new Point(0, 0)).Y);
                };

            chk_AutoSave.CheckedChanged += (b, d) =>
                {
                    chk_AutoSave_ChildDrectory.Enabled = chk_AutoSave.Checked ? true : false;
                    CLASS_DEFAULTOPTION.AutoSaveGS = chk_AutoSave.Checked ? 1 : 0;
                };
            chk_AutoSave_ChildDrectory.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.AutoSaveToChildDriectoryGS = chk_AutoSave_ChildDrectory.Checked ? 1 : 0;
            chk_afterClipBoard.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.using_ClipBoardGS = chk_afterClipBoard.Checked ? 1 : 0;

            textBoxName.TextChanged += (b, d) =>
                {
                    char[] impossibleChar = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
                    string warnningMsg = "파일 이름에는 다음 문자를 사용할 수 없습니다\n\t\\ / : * ? \" < > |";

                    textBoxName.Text = textBoxName.Text.Trim();
                    for (int i = 0 ; i < textBoxName.TextLength ; i++)
                    {
                        for (int j = 0 ; j < impossibleChar.Length ; j++)
                        {
                            if (textBoxName.Text[i] == impossibleChar[j])
                            {
                                int cursorLoc = textBoxName.SelectionStart;
                                textBoxName.Text = textBoxName.Text.Remove(i, 1);
                                textBoxName.Select(cursorLoc - 1, 0);
                                i--;
                                ToolTip tt = new ToolTip();
                                tt.ToolTipTitle = "경고";
                                tt.ToolTipIcon = ToolTipIcon.Warning;
                                //tt.IsBalloon = true;
                                tt.ShowAlways = true;
                                tt.UseAnimation = true;
                                tt.IsBalloon = true;
                                tt.UseFading = true;
                                //tt.SetToolTip(textBoxName, "안되");
                                tt.Show(warnningMsg, textBoxName, textBoxName.Width, textBoxName.Top - 200, 3000);
                            }
                        }
                    }
                };
            textBoxName.LostFocus += (b, d) =>
                {
                    if (textBoxName.Text == "")
                        textBoxName.Text = "Capture";
                    else
                        CLASS_DEFAULTOPTION.SavedOption_NameGS = textBoxName.Text;
                };
            buttonName.Click += (b, d) =>
                {
                    if (textBoxName.Text == "")
                        textBoxName.Text = "Capture";
                    else
                        CLASS_DEFAULTOPTION.SavedOption_NameGS = textBoxName.Text;
                };
            radioButtonList.CheckedChanged += (b, d) =>
                {
                    if (radioButtonList.Checked == true)
                    {
                        comboBoxList.Enabled = true;
                        textBoxPath.Enabled = false;
                        buttonFindPath.Enabled = false;
                        CLASS_DEFAULTOPTION.SavedOption_PathModeGS = 0;
                    }
                    if (radioButtonList.Checked == false)
                    {
                        comboBoxList.Enabled = false;
                        textBoxPath.Enabled = true;
                        buttonFindPath.Enabled = true;
                        CLASS_DEFAULTOPTION.SavedOption_PathModeGS = 1;
                    }
                };
            buttonFindPath.Click += (b, d) =>
                {
                    DIALOG_PATH = new FolderBrowserDialog();
                    if (DIALOG_PATH.ShowDialog() == DialogResult.OK)
                        textBoxPath.Text = DIALOG_PATH.SelectedPath;
                    CLASS_DEFAULTOPTION.SavedOption_DirectoryGS = DIALOG_PATH.SelectedPath;
                };
            chk_UseDirName.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.UseDirNameGS = chk_UseDirName.Checked ? 1 : 0; 
            chk_UseDirTime.CheckedChanged += (b, d) => CLASS_DEFAULTOPTION.UseDirTimeGS = chk_UseDirTime.Checked ? 1 : 0; 
        }
    }
}
