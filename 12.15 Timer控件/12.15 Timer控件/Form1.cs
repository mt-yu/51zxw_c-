using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace _12._15_Timer控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //MessageBox.Show("Test");

            /* 流水灯实例*/
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);       

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*定时播放器*/
            SoundPlayer sdp = new SoundPlayer();
            sdp.SoundLocation = @"D:\同鑫\51自学网C#\12.15 Timer控件\12.15 Timer控件\1.wav";

            label2.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute == 48 && DateTime.Now.Second == 15)
            {
                //sdp.Play();         //单次播放
                sdp.PlayLooping();  //循环播放
            }
            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute == 49 && DateTime.Now.Second == 0)
            {
                //sdp.Play();         //单次播放
                sdp.Stop();  //循环播放
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
