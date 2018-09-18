using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _22._5_绘制基本图形之矩形与多边形
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
            Pen p = new Pen(Color.Red, 3);

            //绘制矩形
            g.DrawRectangle(p, 10, 10, 20, 20);
            
            //绘制多边形

            
            //释放资源
            p.Dispose();
            g.Dispose();



        }
    }
}
