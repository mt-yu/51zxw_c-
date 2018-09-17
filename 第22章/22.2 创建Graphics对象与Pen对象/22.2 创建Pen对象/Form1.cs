using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._2_创建Pen对象
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            //定义笔的颜色为蓝色，大小为2
            Pen p = new Pen(Color.Blue, 2);
            // 左上角点 椭圆的长轴 + 椭圆的短轴
            Rectangle rect = new Rectangle(0,80,280,120);
            
            g1.DrawEllipse(p,rect);

            //释放Graphics资源
            g1.Dispose();
            
        }
    }
}
