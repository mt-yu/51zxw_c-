using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _22._3_TextureBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string path = @"D:\同鑫\51自学网C#\第22章\22.3 创建Brush对象\22.3 TextureBrush\images\BrazilianPine_ZH-CN10573180887_1920x1080.jpg";
            Graphics g = e.Graphics;
            Bitmap img;
            if (File.Exists(path))
            {
                img = new Bitmap(path);
                Brush bh = new TextureBrush(img);
                g.FillEllipse(bh, 0, 80, 560, 240);
                
            }
            else
            {
                MessageBox.Show("Test");
            }
            g.Dispose();
        }
    }
}
