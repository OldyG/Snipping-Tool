namespace Capture
{
    partial class SetSave
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonName = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.groupBoxSavePath = new System.Windows.Forms.GroupBox();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.radioButtonstaticPath = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chk_AutoSave = new System.Windows.Forms.CheckBox();
            this.chk_UseDirName = new System.Windows.Forms.CheckBox();
            this.chk_UseDirTime = new System.Windows.Forms.CheckBox();
            this.chk_afterClipBoard = new System.Windows.Forms.CheckBox();
            this.chk_AutoSave_ChildDrectory = new System.Windows.Forms.CheckBox();
            this.linkLabel_DateTimeStyle = new System.Windows.Forms.LinkLabel();
            this.groupBoxSavePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "기본이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonName
            // 
            this.buttonName.Location = new System.Drawing.Point(185, 105);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(75, 23);
            this.buttonName.TabIndex = 2;
            this.buttonName.Text = "확인";
            this.buttonName.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(21, 62);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(188, 21);
            this.textBoxPath.TabIndex = 4;
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(223, 60);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(75, 23);
            this.buttonFindPath.TabIndex = 2;
            this.buttonFindPath.Text = "설정";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            // 
            // groupBoxSavePath
            // 
            this.groupBoxSavePath.Controls.Add(this.comboBoxList);
            this.groupBoxSavePath.Controls.Add(this.radioButtonstaticPath);
            this.groupBoxSavePath.Controls.Add(this.textBoxPath);
            this.groupBoxSavePath.Controls.Add(this.radioButtonList);
            this.groupBoxSavePath.Controls.Add(this.buttonFindPath);
            this.groupBoxSavePath.Location = new System.Drawing.Point(21, 145);
            this.groupBoxSavePath.Name = "groupBoxSavePath";
            this.groupBoxSavePath.Size = new System.Drawing.Size(311, 100);
            this.groupBoxSavePath.TabIndex = 5;
            this.groupBoxSavePath.TabStop = false;
            this.groupBoxSavePath.Text = "저장경로";
            // 
            // comboBoxList
            // 
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Items.AddRange(new object[] {
            "바탕화면",
            "내 문서",
            "내 사진"});
            this.comboBoxList.Location = new System.Drawing.Point(126, 19);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(172, 20);
            this.comboBoxList.TabIndex = 6;
            this.comboBoxList.Text = "내 사진";
            // 
            // radioButtonstaticPath
            // 
            this.radioButtonstaticPath.AutoSize = true;
            this.radioButtonstaticPath.Location = new System.Drawing.Point(21, 43);
            this.radioButtonstaticPath.Name = "radioButtonstaticPath";
            this.radioButtonstaticPath.Size = new System.Drawing.Size(71, 16);
            this.radioButtonstaticPath.TabIndex = 1;
            this.radioButtonstaticPath.Text = "직접선택";
            this.radioButtonstaticPath.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Checked = true;
            this.radioButtonList.ForeColor = System.Drawing.Color.Red;
            this.radioButtonList.Location = new System.Drawing.Point(21, 20);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(99, 16);
            this.radioButtonList.TabIndex = 0;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "목록에서 선택";
            this.radioButtonList.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.ForeColor = System.Drawing.Color.Red;
            this.labelFilter.Location = new System.Drawing.Point(19, 256);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(53, 12);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "필터형식";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "JPEG 파일(*.jpeg)",
            "비트맵(*.bmp)",
            "PNG파일(*.png)",
            "숨긴파일(*)"});
            this.comboBox2.Location = new System.Drawing.Point(79, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "PNG파일(*.png)";
            // 
            // chk_AutoSave
            // 
            this.chk_AutoSave.AutoSize = true;
            this.chk_AutoSave.Checked = true;
            this.chk_AutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_AutoSave.Location = new System.Drawing.Point(21, 21);
            this.chk_AutoSave.Name = "chk_AutoSave";
            this.chk_AutoSave.Size = new System.Drawing.Size(266, 16);
            this.chk_AutoSave.TabIndex = 7;
            this.chk_AutoSave.Text = "자동저장 사용(캡쳐시 저장경로에 즉시 저장)";
            this.chk_AutoSave.UseVisualStyleBackColor = true;
            // 
            // chk_UseDirName
            // 
            this.chk_UseDirName.AutoSize = true;
            this.chk_UseDirName.Checked = true;
            this.chk_UseDirName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_UseDirName.Location = new System.Drawing.Point(21, 301);
            this.chk_UseDirName.Name = "chk_UseDirName";
            this.chk_UseDirName.Size = new System.Drawing.Size(100, 16);
            this.chk_UseDirName.TabIndex = 9;
            this.chk_UseDirName.Text = "이름단위 저장";
            this.chk_UseDirName.UseVisualStyleBackColor = true;
            // 
            // chk_UseDirTime
            // 
            this.chk_UseDirTime.AutoSize = true;
            this.chk_UseDirTime.Checked = true;
            this.chk_UseDirTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_UseDirTime.Location = new System.Drawing.Point(21, 279);
            this.chk_UseDirTime.Name = "chk_UseDirTime";
            this.chk_UseDirTime.Size = new System.Drawing.Size(100, 16);
            this.chk_UseDirTime.TabIndex = 9;
            this.chk_UseDirTime.Text = "시간단위 저장";
            this.chk_UseDirTime.UseVisualStyleBackColor = true;
            // 
            // chk_afterClipBoard
            // 
            this.chk_afterClipBoard.AutoSize = true;
            this.chk_afterClipBoard.Checked = true;
            this.chk_afterClipBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_afterClipBoard.Location = new System.Drawing.Point(21, 77);
            this.chk_afterClipBoard.Name = "chk_afterClipBoard";
            this.chk_afterClipBoard.Size = new System.Drawing.Size(168, 16);
            this.chk_afterClipBoard.TabIndex = 10;
            this.chk_afterClipBoard.Text = "캡쳐후 클립보드 저장 사용";
            this.chk_afterClipBoard.UseVisualStyleBackColor = true;
            // 
            // chk_AutoSave_ChildDrectory
            // 
            this.chk_AutoSave_ChildDrectory.AutoSize = true;
            this.chk_AutoSave_ChildDrectory.Location = new System.Drawing.Point(42, 44);
            this.chk_AutoSave_ChildDrectory.Name = "chk_AutoSave_ChildDrectory";
            this.chk_AutoSave_ChildDrectory.Size = new System.Drawing.Size(72, 16);
            this.chk_AutoSave_ChildDrectory.TabIndex = 11;
            this.chk_AutoSave_ChildDrectory.Text = "따로저장";
            this.chk_AutoSave_ChildDrectory.UseVisualStyleBackColor = true;
            // 
            // linkLabel_DateTimeStyle
            // 
            this.linkLabel_DateTimeStyle.AutoSize = true;
            this.linkLabel_DateTimeStyle.Location = new System.Drawing.Point(119, 280);
            this.linkLabel_DateTimeStyle.Name = "linkLabel_DateTimeStyle";
            this.linkLabel_DateTimeStyle.Size = new System.Drawing.Size(65, 12);
            this.linkLabel_DateTimeStyle.TabIndex = 12;
            this.linkLabel_DateTimeStyle.TabStop = true;
            this.linkLabel_DateTimeStyle.Text = "[고급설정]";
            // 
            // SetSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel_DateTimeStyle);
            this.Controls.Add(this.chk_AutoSave_ChildDrectory);
            this.Controls.Add(this.chk_afterClipBoard);
            this.Controls.Add(this.chk_UseDirTime);
            this.Controls.Add(this.chk_UseDirName);
            this.Controls.Add(this.chk_AutoSave);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBoxSavePath);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "SetSave";
            this.Size = new System.Drawing.Size(415, 368);
            this.Load += new System.EventHandler(this.AutoSavedSetting_Load);
            this.groupBoxSavePath.ResumeLayout(false);
            this.groupBoxSavePath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.GroupBox groupBoxSavePath;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.RadioButton radioButtonstaticPath;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chk_AutoSave;
        private System.Windows.Forms.CheckBox chk_UseDirName;
        private System.Windows.Forms.CheckBox chk_UseDirTime;
        private System.Windows.Forms.CheckBox chk_afterClipBoard;
        private System.Windows.Forms.CheckBox chk_AutoSave_ChildDrectory;
        private System.Windows.Forms.LinkLabel linkLabel_DateTimeStyle;
    }
}
