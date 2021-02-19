namespace Capture
{
    partial class ColorList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.상대위치 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.절대위치 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chk절대위치 = new System.Windows.Forms.CheckBox();
            this.chk상대위치 = new System.Windows.Forms.CheckBox();
            this.chkRGB = new System.Windows.Forms.CheckBox();
            this.textBox_구분기호 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상대위치,
            this.절대위치,
            this.RGB});
            this.listView1.HoverSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 214);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 상대위치
            // 
            this.상대위치.DisplayIndex = 1;
            this.상대위치.Text = "상대위치";
            this.상대위치.Width = 88;
            // 
            // 절대위치
            // 
            this.절대위치.DisplayIndex = 0;
            this.절대위치.Text = "절대위치";
            // 
            // RGB
            // 
            this.RGB.Text = "RGB";
            this.RGB.Width = 175;
            // 
            // chk절대위치
            // 
            this.chk절대위치.AutoSize = true;
            this.chk절대위치.Checked = true;
            this.chk절대위치.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk절대위치.Location = new System.Drawing.Point(6, 20);
            this.chk절대위치.Name = "chk절대위치";
            this.chk절대위치.Size = new System.Drawing.Size(72, 16);
            this.chk절대위치.TabIndex = 1;
            this.chk절대위치.Text = "절대위치";
            this.chk절대위치.UseVisualStyleBackColor = true;
            // 
            // chk상대위치
            // 
            this.chk상대위치.AutoSize = true;
            this.chk상대위치.Checked = true;
            this.chk상대위치.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk상대위치.Location = new System.Drawing.Point(84, 20);
            this.chk상대위치.Name = "chk상대위치";
            this.chk상대위치.Size = new System.Drawing.Size(72, 16);
            this.chk상대위치.TabIndex = 1;
            this.chk상대위치.Text = "상대위치";
            this.chk상대위치.UseVisualStyleBackColor = true;
            // 
            // chkRGB
            // 
            this.chkRGB.AutoSize = true;
            this.chkRGB.Checked = true;
            this.chkRGB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRGB.Location = new System.Drawing.Point(162, 20);
            this.chkRGB.Name = "chkRGB";
            this.chkRGB.Size = new System.Drawing.Size(49, 16);
            this.chkRGB.TabIndex = 1;
            this.chkRGB.Text = "RGB";
            this.chkRGB.UseVisualStyleBackColor = true;
            // 
            // textBox_구분기호
            // 
            this.textBox_구분기호.Location = new System.Drawing.Point(290, 15);
            this.textBox_구분기호.Name = "textBox_구분기호";
            this.textBox_구분기호.Size = new System.Drawing.Size(22, 21);
            this.textBox_구분기호.TabIndex = 2;
            this.textBox_구분기호.Text = ",";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chk절대위치);
            this.groupBox1.Controls.Add(this.textBox_구분기호);
            this.groupBox1.Controls.Add(this.chk상대위치);
            this.groupBox1.Controls.Add(this.chkRGB);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클립보드 저장옵션";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "구분";
            // 
            // ColorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "ColorList";
            this.ShowInTaskbar = false;
            this.Text = "ColorList";
            this.Load += new System.EventHandler(this.ColorList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader 상대위치;
        private System.Windows.Forms.ColumnHeader RGB;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 절대위치;
        private System.Windows.Forms.CheckBox chk절대위치;
        private System.Windows.Forms.CheckBox chk상대위치;
        private System.Windows.Forms.CheckBox chkRGB;
        private System.Windows.Forms.TextBox textBox_구분기호;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

    }
}