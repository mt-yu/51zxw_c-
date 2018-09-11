using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._9_DataGridView绘制行序号
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

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle myrec = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 5, e.RowBounds.Height); // 5 为行号于第一列的间隔
            //DrawText(IDeviceContext dc, text, font, Rectangle bounds, foreColor, TextFormatFlags);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, myrec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right); 
        }
    }
}
