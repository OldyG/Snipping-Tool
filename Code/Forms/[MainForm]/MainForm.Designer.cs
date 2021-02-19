namespace Capture
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        public int toolStripImageSize;
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wLocation = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.wSize = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelGetColor = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CaptureForToolStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자유형캡쳐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창캡쳐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.전체화면캡쳐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SavedForToolStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.직접저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyForToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PenFortoolStrip = new System.Windows.Forms.ToolStripButton();
            this.CharacterFortoolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpForToolStrip = new System.Windows.Forms.ToolStripButton();
            this.DetailForToolStrip = new System.Windows.Forms.ToolStripButton();
            this.OpenPathFortoolStrip = new System.Windows.Forms.ToolStripButton();
            this.SettingForToolStrip = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripNAME = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptureForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SavedForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SpendForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEDIT = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTOOL = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHELP = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoForMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.폰트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.컬러설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuOfTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JobCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCaptureToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuOfTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(21, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.wLocation);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.wSize);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.labelGetColor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 423);
            this.panel1.TabIndex = 1;
            // 
            // wLocation
            // 
            this.wLocation.AutoSize = true;
            this.wLocation.Location = new System.Drawing.Point(93, 27);
            this.wLocation.Name = "wLocation";
            this.wLocation.Size = new System.Drawing.Size(33, 12);
            this.wLocation.TabIndex = 3;
            this.wLocation.Text = "{0,0}";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(23, 27);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(53, 12);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "사진위치";
            // 
            // wSize
            // 
            this.wSize.AutoSize = true;
            this.wSize.Location = new System.Drawing.Point(218, 27);
            this.wSize.Name = "wSize";
            this.wSize.Size = new System.Drawing.Size(33, 12);
            this.wSize.TabIndex = 2;
            this.wSize.Text = "{0,0}";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(182, 27);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(29, 12);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "크기";
            // 
            // labelGetColor
            // 
            this.labelGetColor.AutoSize = true;
            this.labelGetColor.Location = new System.Drawing.Point(23, 281);
            this.labelGetColor.Name = "labelGetColor";
            this.labelGetColor.Size = new System.Drawing.Size(121, 12);
            this.labelGetColor.TabIndex = 1;
            this.labelGetColor.Text = "절대위치 및 상대위치";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureForToolStrip,
            this.toolStripSeparator4,
            this.SavedForToolStrip,
            this.CopyForToolStrip,
            this.toolStripSeparator,
            this.PenFortoolStrip,
            this.CharacterFortoolStrip,
            this.toolStripSeparator6,
            this.HelpForToolStrip,
            this.DetailForToolStrip,
            this.OpenPathFortoolStrip,
            this.SettingForToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(576, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CaptureForToolStrip
            // 
            this.CaptureForToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사각형ToolStripMenuItem,
            this.자유형캡쳐ToolStripMenuItem,
            this.창캡쳐ToolStripMenuItem,
            this.toolStripSeparator5,
            this.전체화면캡쳐ToolStripMenuItem});
            this.CaptureForToolStrip.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CaptureForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CaptureForToolStrip.Image")));
            this.CaptureForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CaptureForToolStrip.Name = "CaptureForToolStrip";
            this.CaptureForToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.CaptureForToolStrip.Size = new System.Drawing.Size(86, 24);
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.사각형ToolStripMenuItem.Text = "사각형 캡쳐";
            // 
            // 자유형캡쳐ToolStripMenuItem
            // 
            this.자유형캡쳐ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.자유형캡쳐ToolStripMenuItem.Name = "자유형캡쳐ToolStripMenuItem";
            this.자유형캡쳐ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.자유형캡쳐ToolStripMenuItem.Text = "자유형 캡쳐";
            // 
            // 창캡쳐ToolStripMenuItem
            // 
            this.창캡쳐ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.창캡쳐ToolStripMenuItem.Name = "창캡쳐ToolStripMenuItem";
            this.창캡쳐ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.창캡쳐ToolStripMenuItem.Text = "창 캡쳐";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // 전체화면캡쳐ToolStripMenuItem
            // 
            this.전체화면캡쳐ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.전체화면캡쳐ToolStripMenuItem.Name = "전체화면캡쳐ToolStripMenuItem";
            this.전체화면캡쳐ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.전체화면캡쳐ToolStripMenuItem.Text = "전체화면 캡쳐";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // SavedForToolStrip
            // 
            this.SavedForToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavedForToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직접저장ToolStripMenuItem,
            this.자동저장ToolStripMenuItem});
            this.SavedForToolStrip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SavedForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SavedForToolStrip.Image")));
            this.SavedForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavedForToolStrip.Name = "SavedForToolStrip";
            this.SavedForToolStrip.Size = new System.Drawing.Size(36, 24);
            this.SavedForToolStrip.Text = "저장";
            this.SavedForToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // 직접저장ToolStripMenuItem
            // 
            this.직접저장ToolStripMenuItem.Name = "직접저장ToolStripMenuItem";
            this.직접저장ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.직접저장ToolStripMenuItem.Text = "직접저장";
            // 
            // 자동저장ToolStripMenuItem
            // 
            this.자동저장ToolStripMenuItem.Name = "자동저장ToolStripMenuItem";
            this.자동저장ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.자동저장ToolStripMenuItem.Text = "자동저장";
            // 
            // CopyForToolStrip
            // 
            this.CopyForToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyForToolStrip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CopyForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CopyForToolStrip.Image")));
            this.CopyForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyForToolStrip.Name = "CopyForToolStrip";
            this.CopyForToolStrip.Size = new System.Drawing.Size(24, 24);
            this.CopyForToolStrip.Text = "복사";
            this.CopyForToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // PenFortoolStrip
            // 
            this.PenFortoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenFortoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("PenFortoolStrip.Image")));
            this.PenFortoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenFortoolStrip.Name = "PenFortoolStrip";
            this.PenFortoolStrip.Size = new System.Drawing.Size(24, 24);
            this.PenFortoolStrip.Text = "PenFortoolStripButton";
            // 
            // CharacterFortoolStrip
            // 
            this.CharacterFortoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CharacterFortoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CharacterFortoolStrip.Image")));
            this.CharacterFortoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CharacterFortoolStrip.Name = "CharacterFortoolStrip";
            this.CharacterFortoolStrip.Size = new System.Drawing.Size(24, 24);
            this.CharacterFortoolStrip.Text = "CharacterFortoolStrip";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // HelpForToolStrip
            // 
            this.HelpForToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpForToolStrip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HelpForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("HelpForToolStrip.Image")));
            this.HelpForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpForToolStrip.Name = "HelpForToolStrip";
            this.HelpForToolStrip.Size = new System.Drawing.Size(24, 24);
            this.HelpForToolStrip.Text = "도움말";
            this.HelpForToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // DetailForToolStrip
            // 
            this.DetailForToolStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DetailForToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DetailForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DetailForToolStrip.Image")));
            this.DetailForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailForToolStrip.Name = "DetailForToolStrip";
            this.DetailForToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DetailForToolStrip.Size = new System.Drawing.Size(24, 24);
            this.DetailForToolStrip.Text = "이미지 자세히";
            // 
            // OpenPathFortoolStrip
            // 
            this.OpenPathFortoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenPathFortoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenPathFortoolStrip.Image")));
            this.OpenPathFortoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenPathFortoolStrip.Name = "OpenPathFortoolStrip";
            this.OpenPathFortoolStrip.Size = new System.Drawing.Size(24, 24);
            this.OpenPathFortoolStrip.Text = "toolStripButton1";
            // 
            // SettingForToolStrip
            // 
            this.SettingForToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingForToolStrip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingForToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SettingForToolStrip.Image")));
            this.SettingForToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingForToolStrip.Name = "SettingForToolStrip";
            this.SettingForToolStrip.Size = new System.Drawing.Size(24, 24);
            this.SettingForToolStrip.Text = "옵션설정";
            this.SettingForToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripNAME,
            this.MenuStripEDIT,
            this.MenuStripTOOL,
            this.MenuStripHELP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripNAME
            // 
            this.MenuStripNAME.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureForMenuStrip,
            this.toolStripSeparator1,
            this.SavedForMenuStrip,
            this.SpendForMenuStrip,
            this.toolStripSeparator2,
            this.ExitForMenuStrip});
            this.MenuStripNAME.Name = "MenuStripNAME";
            this.MenuStripNAME.Size = new System.Drawing.Size(43, 20);
            this.MenuStripNAME.Text = "파일";
            // 
            // CaptureForMenuStrip
            // 
            this.CaptureForMenuStrip.Name = "CaptureForMenuStrip";
            this.CaptureForMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.CaptureForMenuStrip.Text = "새 캡쳐";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // SavedForMenuStrip
            // 
            this.SavedForMenuStrip.Name = "SavedForMenuStrip";
            this.SavedForMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.SavedForMenuStrip.Text = "다른이름으로저장";
            // 
            // SpendForMenuStrip
            // 
            this.SpendForMenuStrip.Name = "SpendForMenuStrip";
            this.SpendForMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.SpendForMenuStrip.Text = "보내기";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // ExitForMenuStrip
            // 
            this.ExitForMenuStrip.Name = "ExitForMenuStrip";
            this.ExitForMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.ExitForMenuStrip.Text = "종료";
            // 
            // MenuStripEDIT
            // 
            this.MenuStripEDIT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyForMenuStrip});
            this.MenuStripEDIT.Name = "MenuStripEDIT";
            this.MenuStripEDIT.Size = new System.Drawing.Size(43, 20);
            this.MenuStripEDIT.Text = "편집";
            // 
            // CopyForMenuStrip
            // 
            this.CopyForMenuStrip.Name = "CopyForMenuStrip";
            this.CopyForMenuStrip.Size = new System.Drawing.Size(98, 22);
            this.CopyForMenuStrip.Text = "복사";
            // 
            // MenuStripTOOL
            // 
            this.MenuStripTOOL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingForMenuStrip});
            this.MenuStripTOOL.Name = "MenuStripTOOL";
            this.MenuStripTOOL.Size = new System.Drawing.Size(43, 20);
            this.MenuStripTOOL.Text = "도구";
            // 
            // SettingForMenuStrip
            // 
            this.SettingForMenuStrip.Name = "SettingForMenuStrip";
            this.SettingForMenuStrip.Size = new System.Drawing.Size(98, 22);
            this.SettingForMenuStrip.Text = "옵션";
            // 
            // MenuStripHELP
            // 
            this.MenuStripHELP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpForMenuStrip,
            this.InfoForMenuStrip});
            this.MenuStripHELP.Name = "MenuStripHELP";
            this.MenuStripHELP.Size = new System.Drawing.Size(55, 20);
            this.MenuStripHELP.Text = "도움말";
            // 
            // HelpForMenuStrip
            // 
            this.HelpForMenuStrip.Name = "HelpForMenuStrip";
            this.HelpForMenuStrip.Size = new System.Drawing.Size(110, 22);
            this.HelpForMenuStrip.Text = "도움말";
            // 
            // InfoForMenuStrip
            // 
            this.InfoForMenuStrip.Name = "InfoForMenuStrip";
            this.InfoForMenuStrip.Size = new System.Drawing.Size(110, 22);
            this.InfoForMenuStrip.Text = "정보";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트설정ToolStripMenuItem,
            this.컬러설정ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // 폰트설정ToolStripMenuItem
            // 
            this.폰트설정ToolStripMenuItem.Name = "폰트설정ToolStripMenuItem";
            this.폰트설정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.폰트설정ToolStripMenuItem.Text = "폰트설정";
            // 
            // 컬러설정ToolStripMenuItem
            // 
            this.컬러설정ToolStripMenuItem.Name = "컬러설정ToolStripMenuItem";
            this.컬러설정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.컬러설정ToolStripMenuItem.Text = "컬러설정";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "[알림]";
            this.notifyIcon1.BalloonTipTitle = "\"캡쳐도구\"가 트레이로 이동하였습니다.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "캡쳐 도구";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuOfTray
            // 
            this.contextMenuOfTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JobCaptureToolStripMenuItem,
            this.showCaptureToolToolStripMenuItem,
            this.nothingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuOfTray.Name = "contextMenuOfTray";
            this.contextMenuOfTray.Size = new System.Drawing.Size(174, 92);
            // 
            // JobCaptureToolStripMenuItem
            // 
            this.JobCaptureToolStripMenuItem.Name = "JobCaptureToolStripMenuItem";
            this.JobCaptureToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.JobCaptureToolStripMenuItem.Text = "JobCapture";
            // 
            // showCaptureToolToolStripMenuItem
            // 
            this.showCaptureToolToolStripMenuItem.Name = "showCaptureToolToolStripMenuItem";
            this.showCaptureToolToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showCaptureToolToolStripMenuItem.Text = "Show CaptureTool";
            // 
            // nothingToolStripMenuItem
            // 
            this.nothingToolStripMenuItem.Name = "nothingToolStripMenuItem";
            this.nothingToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nothingToolStripMenuItem.Text = "Nothing";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 475);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "캡쳐 도구";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuOfTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripNAME;
        private System.Windows.Forms.ToolStripMenuItem CaptureForMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SavedForMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SpendForMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitForMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripEDIT;
        private System.Windows.Forms.ToolStripMenuItem CopyForMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTOOL;
        private System.Windows.Forms.ToolStripMenuItem SettingForMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHELP;
        private System.Windows.Forms.ToolStripMenuItem HelpForMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem InfoForMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자유형캡쳐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창캡쳐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 전체화면캡쳐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직접저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동저장ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolStripButton CopyForToolStrip;
        public System.Windows.Forms.ToolStripButton HelpForToolStrip;
        public System.Windows.Forms.ToolStripSplitButton CaptureForToolStrip;
        public System.Windows.Forms.ToolStripButton DetailForToolStrip;
        public System.Windows.Forms.ToolStripSplitButton SavedForToolStrip;
        public System.Windows.Forms.ToolStripButton OpenPathFortoolStrip;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label wLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label wSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelGetColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton CharacterFortoolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 폰트설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 컬러설정ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuOfTray;
        private System.Windows.Forms.ToolStripMenuItem showCaptureToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JobCaptureToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStripButton PenFortoolStrip;
        public System.Windows.Forms.ToolStripButton SettingForToolStrip;
    }
}

