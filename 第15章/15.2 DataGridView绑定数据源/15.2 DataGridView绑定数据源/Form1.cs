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

namespace _15._2_DataGridView绑定数据源
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBindMode.DataSource = BindModeSource().Tables[0];
            dgvNonBindMode.DataSource = NonBindModeSource();
        }


        //绑定模式的数据源（即连接数据库）
        private DataSet BindModeSource()
        { 
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";
            SqlConnection mycon = new SqlConnection(constr);

            DataSet myds = new DataSet();
            try 
	        {	        
		        mycon.Open();
                string sql = "select name,gender from mytable001";
                SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                myda.Fill(myds, "mytable001");
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
            finally
            {
                mycon.Close();
            }

            return myds;
        
        }

        //非绑定模式的数据源 (即离线模式)
        private DataTable NonBindModeSource()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("name", Type.GetType("System.String"));
            mydt.Columns.Add("gender", Type.GetType("System.String"));
            string[,] mystr = { { "张三", "女" }, { "李四", "男" }, { "王五", "男" } };
            for (int i = 0; i < mystr.Length / 2; i++)
            {
                DataRow mydr = mydt.NewRow();
                mydr[0] = mystr[i, 0];
                mydr[1] = mystr[i, 1];
                mydt.Rows.Add(mydr);
            }

            return mydt;
        }




    }
}
