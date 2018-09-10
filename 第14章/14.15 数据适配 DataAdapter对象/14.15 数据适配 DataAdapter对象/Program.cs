using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace _14._15_数据适配_DataAdapter对象
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";
            SqlConnection mycon = new SqlConnection(constr);

            try
            {
                using (mycon)
                {
                    #region /*填充DataSet数据集*/
                    //mycon.Open();
                    //Console.WriteLine("打开数据库成功");
                    //string sql = "select * from mytable001";
                    //SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);

                    //DataSet myds = new DataSet();
                    //myda.Fill(myds, "mytable001");

                    //Console.WriteLine("填充成功");
                    //outValue(myds);
                    #endregion

                    #region /*更改数据源*/
                    mycon.Open();
                    string updatesql = "update mytable001 set gender = '女' where name = '张三'";
                    SqlDataAdapter mysda = new SqlDataAdapter("select * from mytable001", mycon);
                    mysda.UpdateCommand = new SqlCommand(updatesql, mycon);

                    DataSet myds = new DataSet();
                    mysda.Fill(myds, "mytable001");     //acceptchange() 处于true 的状态
                    Console.WriteLine("原dataset对象内容");
                    outValue(myds);

                    DataRow row = myds.Tables[0].Rows[0];
                    row["gender"] = "女";
                    mysda.Update(myds, "mytable001");
                    Console.WriteLine("更改后dataset对象内容");

                    outValue(myds);
                    #endregion




                }

  

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("关闭数据库");
                mycon.Close();
            }


            Console.ReadKey();
        }

        public static void outValue(DataSet ds)
        {
            Console.WriteLine("调用outValue");
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("表名:" + dt.TableName);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "\t");   
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
