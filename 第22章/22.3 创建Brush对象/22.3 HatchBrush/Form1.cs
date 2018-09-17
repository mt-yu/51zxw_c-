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
namespace _22._3_HatchBrush
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
            HatchBrush hb = new HatchBrush(HatchStyle.HorizontalBrick, Color.Red, Color.Yellow);
            e.Graphics.FillEllipse(hb, 0, 80, 280, 120);
            hb.Dispose();
        }
    }
}
