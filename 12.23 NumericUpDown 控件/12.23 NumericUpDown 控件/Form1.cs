using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._23_NumericUpDown_控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < numericUpDown1.Maximum)
                numericUpDown1.Value += numericUpDown1.Increment;
            return ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown1.Minimum)
                numericUpDown1.Value -= numericUpDown1.Increment;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.DecimalPlaces = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("设置小数点位数值错误");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Increment = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("设置增量值错误");
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "将要显示的结果";
        }
    }
}
