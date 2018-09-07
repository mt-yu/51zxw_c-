using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._3_ImageList控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (imageList1.Images.Count > 0)
                for (int i = imageList1.Images.Count-1; i >= 0; i--)
                    imageList1.Images.RemoveAt(i);


                
            //声明一个图形变量
            Image img1 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\BrazilianPine_ZH-CN10573180887_1920x1080.jpg");
            Image img2 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\CastleFrankenstein_ZH-CN8604017330_1920x1080.jpg");
            Image img3 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\LawnBowling_ZH-CN10492037230_1920x1080.jpg");
            Image img4 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\SunFlowersStorm_ZH-CN8706728441_1920x1080.jpg");
            Image img5 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\VenetianRowing_ZH-CN6668445308_1920x1080.jpg");
            Image img6 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\0.jpg");
            Image img7 = Image.FromFile(@"D:\同鑫\51自学网C#\BingImage\1.jpg");

            //imageList 添加元素的方法
            //1种    添加单个元素
            imageList1.Images.Add(img1);
                
            //2种    添加多个元素
            imageList1.Images.AddRange(new Image[] {img2, img3, img4, img5}); 

            //3种    AddStrip
            imageList1.Images.AddStrip(img6);
            imageList1.Images.AddStrip(img7);

            //创建一个handle 句柄，
            Graphics mygrap = Graphics.FromHwnd(this.Handle);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                imageList1.Draw(mygrap, new Point(50, 50), i);

                //Draw 有三种重载
                //1. (Graphics 对象， 左上角点坐标， 索引值)

                //2. （Graphics 对象， 水平坐标， 垂直坐标， 索引值）

                //3. (Graphics 对象， 水平，垂直，图形宽，图像高， 索引值)

                System.Threading.Thread.Sleep(500);    // 系统延时1秒
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

                //删除imagelist（集合） 对象的方法 
                //removeAt(索引)
            if (imageList1.Images.Count > 2)
            {
              imageList1.Images.RemoveAt(6);
              imageList1.Images.RemoveAt(5);
              imageList1.Images.RemoveAt(4);
              imageList1.Images.RemoveAt(3);
              imageList1.Images.RemoveAt(2);
            }

            Graphics mygrap = Graphics.FromHwnd(this.Handle);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                imageList1.Draw(mygrap, new Point(50, 50), i);
                System.Threading.Thread.Sleep(500);    // 系统延时1秒
            }

            
        }
    }
}
