using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._7_MDI窗体
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void 层叠cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFrom cf1 = new ChildFrom();
            cf1.MdiParent = this;

            cf1.Show();

        }

        private void 水平HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
