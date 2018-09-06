using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._28_TabControl控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "点击了" + tabControl1.SelectedTab.Text + "[" + tabControl1.SelectedIndex.ToString() + "]";
 
            //MessageBox.Show("点击了" + tabControl1.SelectedTab.Text + "[" + tabControl1.SelectedIndex.ToString() + "]");
        }
    }
}
