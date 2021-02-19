namespace Capture
{
    partial class whiteForm
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
            this.label_Location = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_MSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(15, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 62);
            this.panel1.TabIndex = 1;
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Location.Location = new System.Drawing.Point(13, 37);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(100, 12);
            this.label_Location.TabIndex = 2;
            this.label_Location.Text = "label_Location";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(97, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 62);
            this.panel2.TabIndex = 3;
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Size.Location = new System.Drawing.Point(13, 49);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(73, 12);
            this.label_Size.TabIndex = 2;
            this.label_Size.Text = "label_Size";
            // 
            // label_MSG
            // 
            this.label_MSG.AutoSize = true;
            this.label_MSG.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MSG.Location = new System.Drawing.Point(13, 1);
            this.label_MSG.Name = "label_MSG";
            this.label_MSG.Size = new System.Drawing.Size(435, 32);
            this.label_MSG.TabIndex = 2;
            this.label_MSG.Text = "작업할 영역을 드래그하세요";
            // 
            // whiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.label_MSG);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "whiteForm";
            this.Text = "white";
            this.Load += new System.EventHandler(this.white_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_MSG;

    }
}