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
    public partial class Character : Form
    {
        public Character()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        Font ff = new Font("돋움", 13);

        private void button1_Click(object sender, EventArgs e)
        {
            
            FontDialog CHARACTER_FONTDIALOG = new FontDialog();
            CHARACTER_FONTDIALOG.Font = ff;

            if (CHARACTER_FONTDIALOG.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = CHARACTER_FONTDIALOG.Font;
            }

        }
    }
}
