using System;
using System.Windows.Forms;
using System.Drawing;
using RichTextBoxImeControl;
/*
 *  STORY
 *      - 텍스트박스와 라벨로 구성
 *      - 작업버튼 클릭 시  이미지 중앙에 텍스트박스 생성
 *      - 텍스트박스 입력 및 위치,글꼴, 색상 설정 후 더블 클릭시 라벨로 변경
 *          - CTRL + 마우스 드래그 :: 위치 수정
 *          - 오른쪽 마우스 :: 글꼴 및 색상 변경
 *          - CTRL + Delete :: 삭제
 *          - 마우스 더블클릭 :: 작업완료 (라벨로 변환)
 *      - 변경된 라벨에서 역시 움직일수는 있으나 삭제할수는 없다
 *          - 마우스 더블클릭 :: 수정모드 (텍스트박스로 변환)
 *          
 *  [함수목록]
 *          Character()                     ::  MainForm_Load에서 호출용 함수입니다.텍스트 박스의 초기생성을 결정합니다.
 *          reSizeTextBox(ref RichTextBox)  ::  글자크기에 맞게 텍스트박스의 크기가 자동으로 수정되는 함수입니다.
 *          makeRichTextBox(Point, Font, Color, String) ::  RichTextBox 생성 함수
 */
namespace Capture
{
    public partial class MainForm
    {
        Size CHARACTER_TEMP_SIZE;                           // 초기 TextBox의 크기를 지정
        private Point CHARACTER_MOUSE_POINT = new Point();  // 컨트롤 위치변경시 필요한 변수로, MouseDown이벤트 발생시 마우스 위치값을 저장
        private bool CHARACTER_CHK_MOVING_READY = false;    // 컨트롤 위치변경시 필요한 변수로, Ctrl 키가 입력이 됬는지 기억, false : 미입력 true : 준비완료
        private bool CHARACTER_CHK_LOST_FOCUS = true;       // 컨트롤의 Focus상태를 기억합니다. true 발생시 자동으로 라벨로 변형됩니다.
        FontDialog CHARACTER_FONTDIALOG;                    // 폰트 다이로그
                          // richtextbox

        /// <summary>MainForm_Load에서 호출용 함수입니다.<para>텍스트 박스의 초기생성을 결정합니다.</para></summary>
        private void Character()
        {
            CHARACTER_TEMP_SIZE = new Size(200, 30);
            Font ff = new Font("돋움", 12);
            CharacterFortoolStrip.Click += (b, d) =>
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Controls.Add(
                        makeRichTextBox(new System.Drawing.Point(
                            (pictureBox1.Size.Width - CHARACTER_TEMP_SIZE.Width) / 2, 
                            (pictureBox1.Size.Height - CHARACTER_TEMP_SIZE.Height) / 2),
                        ff, Color.Black, "")
                        );

                for (int i = 0 ; i < pictureBox1.Controls.Count ; i++)
                    if (pictureBox1.Controls[i] is RichTextBoxIme) pictureBox1.Controls[i].Focus();

            };
        }


        /// <summary>
        /// 글자크기에 맞게 텍스트박스의 크기가 자동으로 수정되는 함수입니다.
        /// </summary>
        /// <param name="temp">ref형식으로 RichTextBox를 넣어주세요</param>
        void reSizeTextBox(ref RichTextBoxIme temp)
        {
            RichTextBox tt = new RichTextBox();
            tt.Text = temp.Text;
            tt.Font = temp.Font;
            Graphics textGraphics = Graphics.FromHwnd(tt.Handle);
            SizeF stringSize = textGraphics.MeasureString(tt.Text, tt.Font);
            temp.Size = new Size((int)stringSize.Width + 40, (int)stringSize.Height + 10);
        }
        
        /// <summary>
        /// RichTextBox 생성 함수
        /// </summary>
        /// <param name="location">RichTextBox의 초기위치</param>
        /// <param name="ff">RichTextBox의 초기폰트</param>
        /// <param name="ffcolor">RichTextBox의 초기색상</param>
        /// <param name="text">RichTextBox의 내용</param>
        private RichTextBoxIme makeRichTextBox(Point location, Font ff, Color ffcolor, String text)
        {

            RichTextBoxIme CHARACTER_RICHTEXTBOX = new RichTextBoxIme();
            //CHARACTER_RICHTEXTBOX.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            CHARACTER_RICHTEXTBOX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            CHARACTER_RICHTEXTBOX.Text = text;
            CHARACTER_RICHTEXTBOX.Font = ff;
            CHARACTER_RICHTEXTBOX.Location = location;
            CHARACTER_RICHTEXTBOX.ForeColor = ffcolor;
            reSizeTextBox(ref CHARACTER_RICHTEXTBOX);

            //폰트설정
            CHARACTER_RICHTEXTBOX.MouseUp += (b, d) =>
                {
                    contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
                    CHARACTER_CHK_MOVING_READY = false;
                    if (d.Button == MouseButtons.Right)
                    {
                        CHARACTER_CHK_LOST_FOCUS = false;
                        contextMenuStrip1.Show(CHARACTER_RICHTEXTBOX, d.Y, d.Y);
                    }
                };
            폰트설정ToolStripMenuItem.Click += (i, j) =>
                {
                    CHARACTER_FONTDIALOG = new FontDialog();
                    CHARACTER_FONTDIALOG.Font = CHARACTER_RICHTEXTBOX.Font;
                    if (CHARACTER_FONTDIALOG.ShowDialog() == DialogResult.OK)
                    {
                        CHARACTER_RICHTEXTBOX.Font = CHARACTER_FONTDIALOG.Font;
                        CHARACTER_CHK_LOST_FOCUS = true;
                        CHARACTER_RICHTEXTBOX.Focus();
                        CHARACTER_FONTDIALOG.Dispose();
                    }
                };
            컬러설정ToolStripMenuItem.Click += (i, j) =>
                {
                    ColorDialog colorDia = new ColorDialog();
                    colorDia.Color = CHARACTER_RICHTEXTBOX.ForeColor;
                    if (colorDia.ShowDialog() == DialogResult.OK)
                    {
                        CHARACTER_RICHTEXTBOX.ForeColor = colorDia.Color;
                        CHARACTER_CHK_LOST_FOCUS = true;
                        CHARACTER_RICHTEXTBOX.Focus();
                        colorDia.Dispose();
                    }
                };

            //글자에 맞는 박스크기 수정
            CHARACTER_RICHTEXTBOX.FontChanged += (b, d) => { reSizeTextBox(ref CHARACTER_RICHTEXTBOX); };
            if (CHARACTER_RICHTEXTBOX.Text == "")
            {
                CHARACTER_RICHTEXTBOX.Size = CHARACTER_TEMP_SIZE;
                CHARACTER_RICHTEXTBOX.BackColor = reverseColor(Color.Yellow);
//                CHARACTER_RICHTEXTBOX.BackColor = Color.Black;
            }
            CHARACTER_RICHTEXTBOX.TextChanged += (b, d) =>
                {

                    if (CHARACTER_RICHTEXTBOX.Text == "")
                    {
                        CHARACTER_RICHTEXTBOX.BackColor = reverseColor(Color.Yellow);
                        CHARACTER_RICHTEXTBOX.Size = new Size(200,30);
                    }
                    else
                        CHARACTER_RICHTEXTBOX.BackColor = Color.White;
                    reSizeTextBox(ref CHARACTER_RICHTEXTBOX);
                };

            //컨트롤 이동 이벤트
            CHARACTER_RICHTEXTBOX.KeyDown += (b, d) => { if (d.Control) CHARACTER_CHK_MOVING_READY = true; if (d.Control && d.KeyCode == Keys.Delete) { CHARACTER_RICHTEXTBOX.Dispose(); CHARACTER_CHK_MOVING_READY = false; } };
            CHARACTER_RICHTEXTBOX.KeyUp += (b, d) => { CHARACTER_CHK_MOVING_READY = false; if (d.KeyCode == Keys.RButton) this.Text += "1"; };
            CHARACTER_RICHTEXTBOX.MouseDown += (b, d) => { if (CHARACTER_CHK_MOVING_READY) this.CHARACTER_MOUSE_POINT = d.Location; };
            CHARACTER_RICHTEXTBOX.MouseMove += (b, d) => { if (d.Button == MouseButtons.Left && CHARACTER_CHK_MOVING_READY) CHARACTER_RICHTEXTBOX.Location = new Point(CHARACTER_RICHTEXTBOX.Location.X + d.X - CHARACTER_MOUSE_POINT.X, CHARACTER_RICHTEXTBOX.Location.Y + d.Y - CHARACTER_MOUSE_POINT.Y); };
            CHARACTER_RICHTEXTBOX.LostFocus += (b, d) => { if (CHARACTER_CHK_LOST_FOCUS) { if (CHARACTER_RICHTEXTBOX.Text != "")  contextMenuStrip1.Dispose(); CHARACTER_RICHTEXTBOX.Dispose(); } };
            CHARACTER_RICHTEXTBOX.DoubleClick += (b, d) => { if (CHARACTER_RICHTEXTBOX.Text != "")pictureBox1.Controls.Add(Makelabel(CHARACTER_RICHTEXTBOX.Location, CHARACTER_RICHTEXTBOX.Font, CHARACTER_RICHTEXTBOX.ForeColor, CHARACTER_RICHTEXTBOX.Text)); contextMenuStrip1.Dispose(); CHARACTER_RICHTEXTBOX.Dispose(); };
            return CHARACTER_RICHTEXTBOX;
        }



        /// <summary>
        /// Label 생성 함수
        /// </summary>
        /// <param name="location">Label의 초기위치</param>
        /// <param name="ff">Label의 초기폰트</param>
        /// <param name="ffColor">Label의 초기색상</param>
        /// <param name="text">Label의 내용</param>
        private Label Makelabel(Point location, Font ff, Color ffColor, String text)
        {
            Label lb = new Label();
            lb.Location = location;
            lb.Font = ff;
            lb.ForeColor = ffColor;
            lb.Text = text;
            lb.AutoSize = true;
            lb.BackColor = Color.Transparent;
            lb.Cursor = System.Windows.Forms.Cursors.Hand;
            lb.MouseDown += (b, d) => { this.CHARACTER_MOUSE_POINT = d.Location; };
            lb.MouseMove += (b, d) => { if (d.Button == MouseButtons.Left) lb.Location = new Point(lb.Location.X + d.X - CHARACTER_MOUSE_POINT.X, lb.Location.Y + d.Y - CHARACTER_MOUSE_POINT.Y); };
            lb.DoubleClick += (b, d) => { pictureBox1.Controls.Add(makeRichTextBox(lb.Location, lb.Font, lb.ForeColor, lb.Text)); lb.Dispose(); };

            return lb;
        }

    }
}
