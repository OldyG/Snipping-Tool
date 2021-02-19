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
    public partial class ColorList : Form
    {
        MainForm mainform;
        public ColorList(Form frm)
        {
            InitializeComponent();
            if (frm is MainForm)
                mainform = frm as MainForm;
        }

        private void ColorList_Load(object sender, EventArgs e)
        {
            //listView 디자인
            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 100;
            listView1.Columns[2].Width = 100;
            listView1.Size = new Size(listView1.Columns[0].Width + listView1.Columns[1].Width + listView1.Columns[2].Width + 30, 500);
            groupBox1.Size = new Size(listView1.Size.Width, groupBox1.Height);



            //this.Form 디자인
            this.Text = "RGB";
            this.Location = new Point(mainform.Location.X + mainform.Size.Width, mainform.Location.Y);
            this.Size = new Size(listView1.Size.Width + 10, listView1.Location.Y + listView1.Size.Height + 50);
            this.LocationChanged += (b, d) => { mainform.Location = new Point(this.Location.X - mainform.Size.Width, this.Location.Y); };



            //listview옵션
            listView1.MultiSelect = true;
            listView1.FullRowSelect = true;
            //listView1.HideSelection = true;

            listView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            listView1.AutoArrange = true;
            listView1.BorderStyle = BorderStyle.None;
            listView1.CheckBoxes = true;
            listView1.LabelEdit = true;
            listView1.LabelWrap = true;

            listView1.ItemSelectionChanged += (b, d) =>
                {
                    for (int i = 0 ; i < listView1.Items.Count ; i++)
                    {
                        if (listView1.Items[i].Selected)
                            listView1.Items[i].Checked = true;
                        else
                            listView1.Items[i].Checked = false;
                    }
                    System.Threading.Thread msg = new System.Threading.Thread(titleNameChange);
                    msg.Start(listView1.SelectedItems.Count + "개 선택되었습니다.");

                };
            listView1.KeyDown += (b, d) =>
                {
                    if (d.KeyCode == Keys.Delete)
                        listView1.SelectedItems[0].Remove();
                    if (d.Control && d.KeyCode == Keys.C)
                        setClipboard_Selected();
                    if (d.Control && d.KeyCode == Keys.A)
                    {
                        for (int i = 0 ; i < listView1.Items.Count ; i++)
                            listView1.Items[i].Selected = true;
                    }
                };
            listView1.DoubleClick += (b, d) => { setClipboard(); };
        }

        private void setClipboard_Selected()
        {
            string[][] datalist = new string[0][];
            Array.Resize<string[]>(ref datalist, listView1.CheckedIndices.Count);


            string[] temp = new string[0];
            Array.Resize<string>(ref temp, listView1.CheckedIndices.Count);

            for (int i = 0 ; i < temp.Length ; i++) { temp[i] = setClipboard(i); }




            string sum = "";
            for (int i = 0 ; i < temp.Length ; i++)
            {
                sum += temp[i];
                if (i != temp.Length - i)
                    sum += textBox_구분기호.Text;
                sum += Environment.NewLine;
            }

            Clipboard.SetText(sum);
            System.Threading.Thread msg = new System.Threading.Thread(titleNameChange);
            msg.Start("저장되었습니다.");
        }
        private String setClipboard(int index = 0)
        {
            string[] datalist = new string[0];
            if (chk절대위치.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[index].SubItems[0].Text;
            }
            if (chk상대위치.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[index].SubItems[1].Text;
            }
            if (chkRGB.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[index].SubItems[2].Text;
            }
            this.Text = listView1.SelectedItems.Count.ToString();


            string sum = "";
            for (int i = 0 ; i < datalist.Length ; i++)
            {
                sum += datalist[i];
                if (i != datalist.Length - 1)
                    sum += textBox_구분기호.Text;
            }
            sum += Environment.NewLine;
            Clipboard.SetText(sum);
            System.Threading.Thread msg = new System.Threading.Thread(titleNameChange);
            msg.Start("저장되었습니다.");
            return sum.Remove(sum.Length-2,2);
        }

        /*
        private void setClipboard_Selected()
        {
            string[][] datalist = new string[0][];
            Array.Resize<string[]>(ref datalist, listView1.CheckedIndices.Count);


            for (int i = 0; i < datalist.GetLength(0); i++)
                datalist[i] = new string[]{
                                    chk절대위치.Checked?listView1.CheckedItems[i].SubItems[0].Text:"",
                                    chk상대위치.Checked?listView1.CheckedItems[i].SubItems[1].Text:"",
                                    chkRGB.Checked?listView1.CheckedItems[i].SubItems[2].Text:"",
                                           };

            string sum = "";
            for (int i = 0; i < datalist.Length; i++)
            {
                for (int j = 0; j < datalist[i].Length; j++)
                {
                    sum += datalist[i][j];
                    if (j != datalist.Length - j) sum += textBox_구분기호.Text;
                }
                sum += Environment.NewLine;
            }
            
            Clipboard.SetText(sum);
            System.Threading.Thread msg = new System.Threading.Thread(titleNameChange);
            msg.Start("저장되었습니다.");
//            MessageBox.Show(sum);
        }
        private void setClipboard()
        {
            string[] datalist = new string[0];
            if (chk절대위치.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[0].SubItems[0].Text;
            }
            if (chk상대위치.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[0].SubItems[1].Text;
            }
            if (chkRGB.Checked)
            {
                Array.Resize<string>(ref datalist, datalist.Length + 1);
                datalist[datalist.Length - 1] = listView1.SelectedItems[0].SubItems[2].Text;
            }
            this.Text = listView1.SelectedItems.Count.ToString();


            string sum = "";
            for (int i = 0; i < datalist.Length; i++)
            {
                sum += datalist[i];
                if (i != datalist.Length - 1) sum += textBox_구분기호.Text;
            }
            sum += Environment.NewLine;
            Clipboard.SetText(sum);

            System.Threading.Thread msg = new System.Threading.Thread(titleNameChange);
            msg.Start("저장되었습니다.");
        }*/
        void titleNameChange(object temp)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate() { this.Text = temp as String; }));
            }
            else
                this.Text = temp as string;
            System.Threading.Thread.Sleep(1000);
            this.Text = "RGB";
        }

    }
}
