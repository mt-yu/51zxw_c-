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
                    myCon.Open();
                    string sql = "select * from mytable001";
                    SqlCommand myCom = new SqlCommand(sql, myCon);

                    myCom.CommandTimeout = 2;   //2s没连接成功则为出错
                    Console.WriteLine("创建对象成功");
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
