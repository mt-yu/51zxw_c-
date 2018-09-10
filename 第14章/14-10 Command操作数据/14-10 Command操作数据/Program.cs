using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _14_10_Command操作数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";

            SqlConnection myCon = new SqlConnection(constr);

            try
            {
                using (myCon)
                {
                    #region/*创建Command 对象的过程*/
                    //myCon.Open();
                    //string sql = "select * from mytable001";
                    //SqlCommand myCom = new SqlCommand(sql, myCon);

                    //myCom.CommandTimeout = 2;   //2s没连接成功则为出错
                    //Console.WriteLine("创建对象成功");
                    #endregion

                    #region/*更改数据， ExcuteNonQuery()*/
                    //myCon.Open();
                    //string sql = @"insert dbo.mytable001(name, gender, age, department)values('酒九', '男', '35', '研发部')";
                    //SqlCommand myCom = new SqlCommand(sql, myCon);
                    //myCom.ExecuteNonQuery();
                    //Console.WriteLine("数据更改完成");
                    #endregion

                    #region /*执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行 ExecuteScalar() 有返回值*/
                    myCon.Open();
                    string sql = "select max(age) from mytable001";
                    SqlCommand myCom = new SqlCommand(sql, myCon);
                    int t = 0;
                    t = (int ) myCom.ExecuteScalar();
                    Console.WriteLine("年龄最大的是" + t + "岁");
                    
                    #endregion





                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                
            }
            finally
            {
                myCon.Close();
            }

            Console.ReadKey();
        }
    }
}
