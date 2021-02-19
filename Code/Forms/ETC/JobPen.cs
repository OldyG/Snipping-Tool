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
    public partial class JobPen : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetFocus();
        MainForm FRM_MAINFORM;
        DefaultOption CLASS_DEFAULTOPTION;
        FormOpacity CLASS_FORMOPACITY;
        public JobPen(MainForm frm)
        {
            InitializeComponent();
            this.FRM_MAINFORM = frm;
        }

        private Boolean isDrag = false;             // 마우스가 클릭상태인지 판별
        private Boolean isDragGS
        {
            get { return isDrag; }
            set
            {
                isDrag = value;
                if (isDrag) { CLASS_FORMOPACITY.formToDimly(false, 0.2, this.Opacity); }//this.Hide(); }
                else { CLASS_FORMOPACITY.formToSharp(1, this.Opacity); }//this.Show(); }
            }
        }
        private int drawMode = 0;                   // 0:펜모드    1: 사각형모드
        private Graphics[] g = new Graphics[0];     // 
        private Color PenColor = Color.Blue;
        private int PenWidth = 1;
        private Point previousPoint;

        private void JobPen_Load(object sender, EventArgs e)
        {
            CLASS_DEFAULTOPTION = new DefaultOption();
            CLASS_FORMOPACITY = new FormOpacity(this, 1, 30);
            this.TopMost = true;
            //this.Location = new Point(FRM_MAINFORM.pictureBox1.PointToScreen(new Point(0, 0)).X + FRM_MAINFORM.pictureBox1.Width, FRM_MAINFORM.pictureBox1.PointToScreen(new Point(0, 0)).Y);
            this.Location = new Point(0, 0);
            this.Text = CompanyName.ToString();
            

            FRM_MAINFORM.LocationChanged += (b, d) => { this.Location = new Point(FRM_MAINFORM.pictureBox1.PointToScreen(new Point(0, 0)).X + FRM_MAINFORM.pictureBox1.Width, FRM_MAINFORM.pictureBox1.PointToScreen(new Point(0, 0)).Y); };
            FRM_MAINFORM.pictureBox1.MouseDown += new MouseEventHandler(Event_MouseDown);
            FRM_MAINFORM.pictureBox1.MouseUp += new MouseEventHandler(Event_MouseUp);
            FRM_MAINFORM.pictureBox1.MouseMove += new MouseEventHandler(Event_MouseMove);
        }
        private void Event_MouseDown(object sender, MouseEventArgs d)
        {
            if (d.Button == MouseButtons.Left)
            {
                isDragGS = true;
                previousPoint = d.Location;
                Array.Resize<Graphics>(ref g, g.Length + 1);
            }
        }
        private void Event_MouseUp(object sender, MouseEventArgs d)
        {
            isDragGS = false;
            FRM_MAINFORM.PRINTSCREEN = new Bitmap(FRM_MAINFORM.pictureBox1.Width, FRM_MAINFORM.pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(FRM_MAINFORM.PRINTSCREEN as Image);
            graphics.CopyFromScreen(FRM_MAINFORM.pictureBox1.PointToScreen(new Point(0, 0)), new Point(0, 0), FRM_MAINFORM.PRINTSCREEN.Size);
            if (CLASS_DEFAULTOPTION.AutoSaveGS == 1)
            {
                if (FRM_MAINFORM.AutoSavedPath != null)
                {
                    try { FRM_MAINFORM.PRINTSCREEN.Save(FRM_MAINFORM.AutoSavedPath); }
                    catch (Exception) { }
                }
                else
                    FRM_MAINFORM.FuncSave_Auto();
            }
        }
        private void Event_MouseMove(object sender, MouseEventArgs d)
        {
            if (isDrag == true && d.Button == MouseButtons.Left)
            {
                Pen currentPen;
                Point currentPoint = d.Location;
                currentPen = new Pen(PenColor);
                currentPen.Width = PenWidth;
                currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                if (drawMode == 0)
                {
                    g[g.Length - 1] = FRM_MAINFORM.pictureBox1.CreateGraphics();
                    g[g.Length - 1].DrawLine(currentPen, previousPoint, currentPoint);
                    //g[g.Length - 1].DrawPie(currentPen, new Rectangle(previousPoint, new Size(1, 1)),1,2);
                    //g[g.Length - 1].DrawRectangle(currentPen, new Rectangle(previousPoint, new Size(1, 1)));
                    //g[g.Length - 1].DrawEllipse(currentPen, new Rectangle(previousPoint, new Size(1, 1)));
                    //g[g.Length - 1].DrawEllipse(currentPen, previousPoint.X,previousPoint.Y, 10, 10);
                    /*Thread thth = new Thread(brushThread);
                    thth.Start(d.Location);*/
                    previousPoint = currentPoint;
                }
                else if (drawMode == 1)
                {


                }
                else
                {
                    throw new Exception();
                }

            }
        }

        private void JobPen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FRM_MAINFORM.PenFortoolStrip.BackColor = Color.White;
            FRM_MAINFORM.pictureBox1.MouseDown -= new MouseEventHandler(Event_MouseDown);
            FRM_MAINFORM.pictureBox1.MouseUp -= new MouseEventHandler(Event_MouseUp);
            FRM_MAINFORM.pictureBox1.MouseMove -= new MouseEventHandler(Event_MouseMove);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog temp = new ColorDialog();
            temp.Color = button1.BackColor;
            if (temp.ShowDialog() == DialogResult.OK)
            {
                PenColor = button1.BackColor = temp.Color;
                temp.Dispose();
            }
        }
    }
}
