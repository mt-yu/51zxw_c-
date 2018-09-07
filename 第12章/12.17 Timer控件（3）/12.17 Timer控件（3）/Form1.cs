using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._17_Timer控件_3_
{
    public partial class Form1 : Form
    {
        public static int t = 0;       // 每10ms 进入中断并计数   
        public Form1()
        {
            InitializeComponent();
        }

        public string GetTimeFormat(int t)
        {
            string hh, mm, ss, mms;
            int temp = t / 100;     //temp 为所有的秒
            int ms = t % 100;
            int h = temp / 3600;
            int m = temp / 60 % 60;
            int s = temp % 60;
            if (ms < 10) mms = "0" + ms.ToString();
            else mms = ms.ToString();
            if (h < 10) hh = "0" + h.ToString();
            else hh = h.ToString();
            if (m < 10) mm = "0" + m.ToString();
            else mm = m.ToString();
            if (s < 10) ss = "0" + s.ToString();
            else ss = s.ToString();
            
            
            return  hh + ":" + mm + ":" + ss + "." + mms;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            label1.Text = GetTimeFormat(t);
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                startbtn.Text = "开始计时";
                clearbtn.Enabled = true;
            }
            else 
            {
                timer1.Start();
                startbtn.Text = "停止计时";
                clearbtn.Enabled = false;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            label1.Text = GetTimeFormat(t = 0);  
        }
    }
}
