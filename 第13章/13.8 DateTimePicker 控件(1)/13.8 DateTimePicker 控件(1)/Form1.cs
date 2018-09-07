using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._8_DateTimePicker_控件_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.Year.ToString() + "年" + dateTimePicker1.Value.Month.ToString() + "月" + dateTimePicker1.Value.Day.ToString() + "日";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
