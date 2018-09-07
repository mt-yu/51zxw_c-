using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._12_ErrorProvider控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 10)
            {
                
                errorProvider1.SetError(textBox1, "用户名必须为8到10位");
                errorProvider1.Icon = new Icon(@"D:\同鑫\51自学网C#\BingImage\ProgressError.ico");
            }
            else
            {
                errorProvider1.SetError(textBox1, "正确");
                errorProvider1.Icon = new Icon(@"D:\同鑫\51自学网C#\BingImage\ProgressSuccess.ico");
            }
            if (textBox1.Text.Length == 0)
                errorProvider1.SetError(textBox1, "");
        }
    }
}
