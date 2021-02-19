using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capture
{
    public partial class DateTimeStyle : Form
    {
        
        public DateTimeStyle(LinkLabel LL) { InitializeComponent(); this.LLPoint = LL.PointToScreen(new Point(0, 0)); }

        Timer TT;
        Point LLPoint;
        DefaultOption CLASS_DEFAULTOPTION;

        bool isOK = false;

        private void DateTimeStyle_Load(object sender, EventArgs e)
        {
            CLASS_DEFAULTOPTION = new DefaultOption();
            //String TimeStyle = "yyyy년MM월dd일";
            textBox_announce.Text = CLASS_DEFAULTOPTION.SavedOption_DateTimeStyleGS;
            this.Location = new Point(LLPoint.X + 30, LLPoint.Y - 30);


            TT = new Timer();
            TT.Interval = 1000;
            TT.Tick += (b, d) =>
                {
                    this.Text = DateTime.Now.ToString();
                    textBox_temp.Text = "";
                    try
                    {
                        textBox_temp.Text = DateTime.Now.ToString(textBox_announce.Text);
                        isOK = true;
                    }
                    catch (FormatException bb)
                    {
                        textBox_temp.Text = "\n" + bb.Message;
                        isOK = false;
                    }
                };
            TT.Start();

            textBox_announce.TextChanged += (b, d) =>
                {
                    char[] impossibleChar = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' ,'z'};
                    string warnningMsg = "파일이름에서 제외되는 문자를 사용할 수 없습니다\n\t\\ / : * ? \" < > | z";
                    textBox_announce.Text = textBox_announce.Text.Trim();
                    if (textBox_announce.Text == "")
                        textBox_announce.Text = "yyyy년MM월dd일";
                    
                    try
                    {
                        for (int i = 0 ; i < textBox_announce.TextLength ; i++)
                        {
                            for (int j = 0 ; j < impossibleChar.Length ; j++)
                            {
                                if (textBox_announce.Text[i] == impossibleChar[j])
                                {
                                    int cursorLoc = textBox_announce.SelectionStart;
                                    textBox_announce.Text = textBox_announce.Text.Remove(i, 1);
                                    textBox_announce.Select(cursorLoc - 1, 0);
                                    i--;
                                    ToolTip tt = new ToolTip();
                                    tt.ToolTipTitle = "경고";
                                    tt.ToolTipIcon = ToolTipIcon.Warning;
                                    //tt.IsBalloon = true;
                                    tt.ShowAlways = true;
                                    tt.UseAnimation = true;
                                    tt.IsBalloon = true;
                                    tt.UseFading = true;
                                    //tt.SetToolTip(textBox13, "안되");
                                    tt.Show(warnningMsg, textBox_announce, textBox_announce.Width, textBox_announce.Top - 100, 3000);
                                }
                            }
                        }
                    }
                    catch(Exception){}

                };
            button_chk.Click += (b, d) => 
            {
                if (isOK)
                {
                    CLASS_DEFAULTOPTION.SavedOption_DateTimeStyleGS = textBox_announce.Text.Trim();
                }
                else
                {
                    CLASS_DEFAULTOPTION.SavedOption_DateTimeStyleGS = "yyyy년MM월dd일";
                }
                this.Close(); 
            };
            button_Default.Click += (b, d) => { textBox_announce.Text = "yyyy년MM월dd일"; };

        }


    }
}
