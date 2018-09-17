using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace _22._3_LinearGridientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 140), new Point(280, 60), Color.Red, Color.FromArgb(255,0,0,255));

            g.FillEllipse(lgb, 0, 80, 280, 120);


            lgb.Dispose();
            g.Dispose();

        }
    }
}
