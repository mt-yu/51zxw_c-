using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
namespace _15._7_DataGridView直接修改数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //数据库连接方法
        private SqlConnection GetConnection()
        {
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";
            SqlConnection mycon = new SqlConnection(constr);
            return mycon;
        }

        //数据库绑定方法
        private void dgvBind()
        {
            SqlConnection mycon = GetConnection();
            DataSet myds = new DataSet();
            try
            {
                mycon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from mytable001", mycon);
                DataTable table = new DataTable();
                sda.Fill(table);

                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = table;
                this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBind();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection mycon = GetConnection();
            try
            {
                mycon.Open();
                //获取当前单元格 的字段，和当前修改的值
                string mystr1 = dataGridView1.Columns[e.ColumnIndex].HeaderText + "=" + @"'" + dataGridView1.CurrentCell.Value.ToString() + @"'";
                
                //获取单元格对应的行和列
                string mystr2 = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //string mystr3 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                string updatesql = @"update mytable001 set " + mystr1 + "where id = " + mystr2 ;
                SqlCommand mycom= new SqlCommand(updatesql, mycon);

                mycom.ExecuteNonQuery();
                dgvBind();
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


    }
}
