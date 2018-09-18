using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._5_绘制多边形
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
            Pen p = new Pen(Color.Green, 3);
            Point[] pg = {
                          new Point(0, 76),
                          new Point(80, 76),
                          new Point(106, 0),
                          };
            g.DrawPolygon(p, pg);
            p.Dispose();
            g.Dispose();

        }
    }
}
