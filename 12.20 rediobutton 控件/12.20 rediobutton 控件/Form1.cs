using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._20_rediobutton_控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(adminrabtn.Checked | userbtn.Checked))
            {
                MessageBox.Show("请选择登录用户类型");
            }
            else if(adminrabtn.Checked)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "123456" )
                    MessageBox.Show("登录成功");
                else
                    MessageBox.Show("用户名或密码错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
