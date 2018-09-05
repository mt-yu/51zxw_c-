using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._8_checkbox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctcbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xhxcbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (ctcbx.Checked)
            {
                if (xtcbx.Checked)
                {
                    if (xhxcbx.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
                    }
                }
                else
                {
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                }
            }
            else 
            {
                if (xtcbx.Checked)
                {
                    if (xhxcbx.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    }
                }
                else
                {
                    textBox1.Font = new Font(textBox1.Font,FontStyle.Regular);
                }
            }
        }
    }
}
