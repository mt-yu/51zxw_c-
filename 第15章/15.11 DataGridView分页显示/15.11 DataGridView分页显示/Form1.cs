using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._11_DataGridView分页显示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //声明数据适配器和数据集方便填充
        private SqlDataAdapter pagingDA;
        private DataSet pagingDS = new DataSet();

        private int StartVal = 0; // 起始值
        private int valPerPage = 3; //每页显示的内容
        private int totalValNumber; //总条数
        private int currentPage = 1;//当前页


        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";
            SqlConnection mycon = new SqlConnection(constr);

            try
            {
                mycon.Open();
                string sql = "select * from mytable001";
                pagingDA = new SqlDataAdapter(sql, mycon);
                pagingDA.Fill(pagingDS, "mytable001");
                totalValNumber = pagingDS.Tables[0].Rows.Count;
                //总页数计算
                int totalPageNumber = (totalValNumber % valPerPage == 0) ? (totalValNumber / valPerPage) : (totalValNumber / valPerPage + 1);
                toolStripLabel1.Text = "/" + totalPageNumber;

                //加载数据
                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }
            

        }

        private void LoadData()
        {
            currentPage = StartVal / valPerPage + 1;
            toolStripTextBox1.Text = currentPage.ToString();

            pagingDS.Clear();
            pagingDA.Fill(pagingDS, StartVal, valPerPage, "mytable001");

            //绑定数据源
            bindingSource1.DataSource = pagingDS.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;

        }

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                StartVal = StartVal - valPerPage;
                if (StartVal < 0)
                {
                    MessageBox.Show("已经是第一页");
                    StartVal = 0;
                    return;
                }
            }
            if (e.ClickedItem.Text == "下一页")
            {
                StartVal = StartVal + valPerPage;
                if (StartVal > totalValNumber)
                {
                    MessageBox.Show("已经是最后一页");
                    StartVal = StartVal - valPerPage;
                    return;
                }
            }
            LoadData();
        }
    }
}
