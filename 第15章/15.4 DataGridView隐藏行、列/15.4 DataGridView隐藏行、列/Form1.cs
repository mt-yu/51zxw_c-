﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._4_DataGridView隐藏行_列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBcsharpDataSet.mytable001”中。您可以根据需要移动或删除它。
            this.mytable001TableAdapter.Fill(this.dBcsharpDataSet.mytable001);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "隐藏部门列")
            {
                dataGridView1.Columns[4].Visible = false;
                button1.Text = "显示部门列";
            }
            else
            {
                dataGridView1.Columns[4].Visible = true;
                button1.Text = "隐藏部门列";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "隐藏张三行")
            {
                dataGridView1.Rows[1].Visible = false;
                button2.Text = "显示张三行";
            }
            else
            {
                dataGridView1.Rows[1].Visible = true;
                button2.Text = "隐藏张三行";
            }

        }
    }
}
