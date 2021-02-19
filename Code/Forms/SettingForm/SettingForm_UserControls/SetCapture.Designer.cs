namespace Capture
{
    partial class SetCapture
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
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.label_Mode = new System.Windows.Forms.Label();
            this.label_LineStroke = new System.Windows.Forms.Label();
            this.trackBar_LineStroke = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label_LineColor = new System.Windows.Forms.Label();
            this.panel_LineColor = new System.Windows.Forms.Panel();
            this.group_DragOption = new System.Windows.Forms.GroupBox();
            this.checkBoxMouseHalfSpeed = new System.Windows.Forms.CheckBox();
            this.label_Sleep = new System.Windows.Forms.Label();
            this.numeric_Sleep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.label_WhiteFormBackColor = new System.Windows.Forms.Label();
            this.panel_WhiteFormBackColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LineStroke)).BeginInit();
            this.group_DragOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sleep)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "사각형 캡쳐",
            "자유형 캡쳐",
            "창 캡쳐",
            "전체화면 캡쳐"});
            this.comboBox_Mode.Location = new System.Drawing.Point(133, 78);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(198, 20);
            this.comboBox_Mode.TabIndex = 0;
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.ForeColor = System.Drawing.Color.Red;
            this.label_Mode.Location = new System.Drawing.Point(30, 81);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(53, 12);
            this.label_Mode.TabIndex = 1;
            this.label_Mode.Text = "캡쳐모드";
            // 
            // label_LineStroke
            // 
            this.label_LineStroke.AutoSize = true;
            this.label_LineStroke.Location = new System.Drawing.Point(21, 37);
            this.label_LineStroke.Name = "label_LineStroke";
            this.label_LineStroke.Size = new System.Drawing.Size(45, 12);
            this.label_LineStroke.TabIndex = 2;
            this.label_LineStroke.Text = "선 굵기";
            // 
            // trackBar_LineStroke
            // 
            this.trackBar_LineStroke.Location = new System.Drawing.Point(109, 20);
            this.trackBar_LineStroke.Maximum = 30;
            this.trackBar_LineStroke.Minimum = 1;
            this.trackBar_LineStroke.Name = "trackBar_LineStroke";
            this.trackBar_LineStroke.Size = new System.Drawing.Size(198, 45);
            this.trackBar_LineStroke.TabIndex = 3;
            this.trackBar_LineStroke.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_LineStroke.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            // 
            // label_LineColor
            // 
            this.label_LineColor.AutoSize = true;
            this.label_LineColor.Location = new System.Drawing.Point(21, 71);
            this.label_LineColor.Name = "label_LineColor";
            this.label_LineColor.Size = new System.Drawing.Size(45, 12);
            this.label_LineColor.TabIndex = 5;
            this.label_LineColor.Text = "선 색상";
            // 
            // panel_LineColor
            // 
            this.panel_LineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LineColor.Location = new System.Drawing.Point(109, 67);
            this.panel_LineColor.Name = "panel_LineColor";
            this.panel_LineColor.Size = new System.Drawing.Size(198, 16);
            this.panel_LineColor.TabIndex = 6;
            // 
            // group_DragOption
            // 
            this.group_DragOption.Controls.Add(this.label_LineStroke);
            this.group_DragOption.Controls.Add(this.checkBoxMouseHalfSpeed);
            this.group_DragOption.Controls.Add(this.panel_LineColor);
            this.group_DragOption.Controls.Add(this.trackBar_LineStroke);
            this.group_DragOption.Controls.Add(this.label_LineColor);
            this.group_DragOption.Controls.Add(this.label3);
            this.group_DragOption.Location = new System.Drawing.Point(30, 116);
            this.group_DragOption.Name = "group_DragOption";
            this.group_DragOption.Size = new System.Drawing.Size(340, 122);
            this.group_DragOption.TabIndex = 7;
            this.group_DragOption.TabStop = false;
            this.group_DragOption.Text = "드래그 옵션";
            // 
            // checkBoxMouseHalfSpeed
            // 
            this.checkBoxMouseHalfSpeed.AutoSize = true;
            this.checkBoxMouseHalfSpeed.Checked = true;
            this.checkBoxMouseHalfSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMouseHalfSpeed.Location = new System.Drawing.Point(20, 96);
            this.checkBoxMouseHalfSpeed.Name = "checkBoxMouseHalfSpeed";
            this.checkBoxMouseHalfSpeed.Size = new System.Drawing.Size(164, 16);
            this.checkBoxMouseHalfSpeed.TabIndex = 12;
            this.checkBoxMouseHalfSpeed.Text = "드래그시 마우스 정밀하게";
            this.checkBoxMouseHalfSpeed.UseVisualStyleBackColor = true;
            // 
            // label_Sleep
            // 
            this.label_Sleep.AutoSize = true;
            this.label_Sleep.Location = new System.Drawing.Point(30, 43);
            this.label_Sleep.Name = "label_Sleep";
            this.label_Sleep.Size = new System.Drawing.Size(77, 12);
            this.label_Sleep.TabIndex = 8;
            this.label_Sleep.Text = "캡쳐전환시간";
            // 
            // numeric_Sleep
            // 
            this.numeric_Sleep.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_Sleep.Location = new System.Drawing.Point(133, 41);
            this.numeric_Sleep.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numeric_Sleep.Name = "numeric_Sleep";
            this.numeric_Sleep.Size = new System.Drawing.Size(96, 21);
            this.numeric_Sleep.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "(1000=1초)";
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(26, 276);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(188, 16);
            this.chk_active.TabIndex = 12;
            this.chk_active.Text = "비활성화캡쳐시 창을 띄웁니다";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // label_WhiteFormBackColor
            // 
            this.label_WhiteFormBackColor.AutoSize = true;
            this.label_WhiteFormBackColor.Location = new System.Drawing.Point(30, 248);
            this.label_WhiteFormBackColor.Name = "label_WhiteFormBackColor";
            this.label_WhiteFormBackColor.Size = new System.Drawing.Size(81, 12);
            this.label_WhiteFormBackColor.TabIndex = 5;
            this.label_WhiteFormBackColor.Text = "캡쳐 배경색상";
            // 
            // panel_WhiteFormBackColor
            // 
            this.panel_WhiteFormBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_WhiteFormBackColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_WhiteFormBackColor.Location = new System.Drawing.Point(127, 244);
            this.panel_WhiteFormBackColor.Name = "panel_WhiteFormBackColor";
            this.panel_WhiteFormBackColor.Size = new System.Drawing.Size(198, 16);
            this.panel_WhiteFormBackColor.TabIndex = 6;
            // 
            // SetCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_WhiteFormBackColor);
            this.Controls.Add(this.chk_active);
            this.Controls.Add(this.label_WhiteFormBackColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_Sleep);
            this.Controls.Add(this.label_Sleep);
            this.Controls.Add(this.group_DragOption);
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.comboBox_Mode);
            this.Name = "SetCapture";
            this.Size = new System.Drawing.Size(415, 508);
            this.Load += new System.EventHandler(this.SetCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LineStroke)).EndInit();
            this.group_DragOption.ResumeLayout(false);
            this.group_DragOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Label label_LineStroke;
        private System.Windows.Forms.TrackBar trackBar_LineStroke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_LineColor;
        private System.Windows.Forms.Panel panel_LineColor;
        private System.Windows.Forms.GroupBox group_DragOption;
        private System.Windows.Forms.Label label_Sleep;
        private System.Windows.Forms.NumericUpDown numeric_Sleep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.Label label_WhiteFormBackColor;
        private System.Windows.Forms.Panel panel_WhiteFormBackColor;
        private System.Windows.Forms.CheckBox checkBoxMouseHalfSpeed;
    }
}
