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

namespace _22._3_PathGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 80, 280, 120);
            PathGradientBrush pgb = new PathGradientBrush(gp);

            pgb.CenterColor = Color.FromArgb(255, 255, 0, 0);   //中心颜色
            Color[] colors = { Color.FromArgb(255, 0, 255, 0) };
            pgb.SurroundColors = colors;    //环绕颜色

            e.Graphics.FillEllipse(pgb, 0, 80, 280, 120);
            pgb.Dispose();


        }
    }
}
