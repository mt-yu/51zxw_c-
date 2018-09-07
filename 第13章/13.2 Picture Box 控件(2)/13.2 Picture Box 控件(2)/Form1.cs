using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._2_Picture_Box_控件_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i = 0;//图片索引参数
        //获取知道文件夹下所有文件的路径
        public string[] path = Directory.GetFiles(@"D:\同鑫\51自学网C#\13.2 Picture Box 控件(2)\13.2 Picture Box 控件(2)\image\");

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置图片如何在pictualBox中显示
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //设置默认显示的图片
            pictureBox1.Image = Image.FromFile(@"D:\同鑫\51自学网C#\13.2 Picture Box 控件(2)\13.2 Picture Box 控件(2)\image\0.jpg");

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            { i = path.Length - 1; }
            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i > path.Length - 1)
            { i = 0; }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
