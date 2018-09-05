using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._8_窗体中控件的基本操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Size = new Size(500, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Size = new Size(200, 200);
            button3.Location = new System.Drawing.Point(5, 5);
        }
    }
}
