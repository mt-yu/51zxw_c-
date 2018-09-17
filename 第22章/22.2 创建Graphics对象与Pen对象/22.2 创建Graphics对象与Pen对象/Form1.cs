using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._2_创建Graphics对象与Pen对象
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //#1
            Graphics g1 = e.Graphics;
            //#2
            Bitmap imgTemp = new Bitmap(200, 200);
            Graphics g2 = Graphics.FromImage(imgTemp);
            //#3
            Graphics g3 = this.CreateGraphics();

            MessageBox.Show("Test");

        }
    }
}
