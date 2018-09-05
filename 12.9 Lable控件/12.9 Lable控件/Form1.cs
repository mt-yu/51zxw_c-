using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._9_Lable控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(0, this.ClientSize.Width - label1.Size.Width);
            int y = r.Next(0, this.ClientSize.Height - label1.Size.Height);

            //this.label1.Location = new System.Drawing.Point(x, y);

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("点击了");
        }
    }
}
