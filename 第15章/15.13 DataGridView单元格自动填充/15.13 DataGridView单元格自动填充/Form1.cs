using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._13_DataGridView单元格自动填充
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

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string titleText = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
            if (titleText.Equals("department"))
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    DataCollection.Add("开发部");
                    DataCollection.Add("市场部");
                    DataCollection.Add("技术支持部");
                    DataCollection.Add("财务部");
                    autoText.AutoCompleteCustomSource = DataCollection;

                }
            }
        }
    }
}
