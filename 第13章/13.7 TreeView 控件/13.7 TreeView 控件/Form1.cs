using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._7_TreeView_控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                TreeNode tn = new TreeNode();
                tn.Text = textBox1.Text.Trim();
                treeView1.SelectedNode.Nodes.Add(tn);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //添加根节点
            if (textBox1.Text.Trim() != "")
            {
                TreeNode tn = new TreeNode();
                tn.Text = textBox1.Text.Trim();
                treeView1.Nodes.Add(tn);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn = treeView1.SelectedNode;
            if (tn.Nodes.Count > 0)
            {
                DialogResult myDR = MessageBox.Show("有子节点，确定删除？", "删除提示", MessageBoxButtons.YesNo);
                if (myDR == DialogResult.Yes)
                {
                    tn.Remove();
                }

            }
                
        }
    }
}
