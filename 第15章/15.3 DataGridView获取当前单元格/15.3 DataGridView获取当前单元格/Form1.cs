using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._3_DataGridView获取当前单元格
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


        //sender对应当前操作的控件,如现在对应的是dataGridView //e对应当前事件的参数
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取行列索引

            #region 方法1:
            int row1 = e.RowIndex + 1;
            int col1 = e.ColumnIndex + 1;
            #endregion

            #region 方法2:
            int row2 = dataGridView1.CurrentCell.RowIndex + 1;
            int col2 = dataGridView1.CurrentCell.ColumnIndex + 1;
            #endregion

            #region 方法3:
            int row3 = dataGridView1.CurrentCellAddress.Y + 1;
            int col3 = dataGridView1.CurrentCellAddress.X + 1;
            #endregion

            #region 方法4(行的引用):
            int row4 = dataGridView1.CurrentRow.Index + 1;
            #endregion


            #region 获取单元格的Value
            //方法1
            // string cell = dataGridView1.Rows[row1-1].Cells[col1-1].Value.ToString();
            //方法2
            string cell = dataGridView1.CurrentCell.Value.ToString();


            #endregion
            MessageBox.Show("第" + row1.ToString() + "行,第" + col1.ToString() + "列\n内容为" + cell);

        }
    }
}
