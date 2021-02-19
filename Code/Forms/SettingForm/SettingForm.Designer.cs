namespace Capture
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button_InterFace = new System.Windows.Forms.Button();
            this.button_Capture = new System.Windows.Forms.Button();
            this.button_AutoSave = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(96, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 422);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(418, 411);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "닫기";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // button_InterFace
            // 
            this.button_InterFace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_InterFace.Location = new System.Drawing.Point(13, 16);
            this.button_InterFace.Name = "button_InterFace";
            this.button_InterFace.Size = new System.Drawing.Size(75, 23);
            this.button_InterFace.TabIndex = 1;
            this.button_InterFace.Text = "인터페이스";
            this.button_InterFace.UseVisualStyleBackColor = true;
            // 
            // button_Capture
            // 
            this.button_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Capture.Location = new System.Drawing.Point(13, 45);
            this.button_Capture.Name = "button_Capture";
            this.button_Capture.Size = new System.Drawing.Size(75, 23);
            this.button_Capture.TabIndex = 1;
            this.button_Capture.Text = "캡쳐";
            this.button_Capture.UseVisualStyleBackColor = true;
            // 
            // button_AutoSave
            // 
            this.button_AutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AutoSave.Location = new System.Drawing.Point(13, 74);
            this.button_AutoSave.Name = "button_AutoSave";
            this.button_AutoSave.Size = new System.Drawing.Size(75, 23);
            this.button_AutoSave.TabIndex = 1;
            this.button_AutoSave.Text = "저장방법";
            this.button_AutoSave.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(12, 411);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "초기화";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(491, 446);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_AutoSave);
            this.Controls.Add(this.button_Capture);
            this.Controls.Add(this.button_InterFace);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_InterFace;
        private System.Windows.Forms.Button button_Capture;
        private System.Windows.Forms.Button button_AutoSave;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button buttonExit;
    }
}