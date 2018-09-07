using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._3_RichTextBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void ls18btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书", 18);
        }

        private void restbtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionColor = System.Drawing.SystemColors.ControlDark;
            richTextBox1.SelectionFont = new System.Drawing.Font("宋体", 12F);
        }

        private void itembtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void diwenbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Gold;
        }
    }
}
