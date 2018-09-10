using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _14._9_Connection连接_关闭数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQLServer数据库的连接分两种方式


            #region /* Windows 身份验证实现登录 */
            //                         服务器名称               安全性设置                    数据库名称
            //string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; integrated security = SSPI; Initial Catalog = DBcsharp";
            #endregion

            #region /*SQLServer 身份验证实现登录*/
            string constr = @"Server = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf123; database =  DBcsharp";
            // 创建数据库连接对象
            SqlConnection mysqlCon = new SqlConnection(constr);
            #endregion



            #region //关闭数据库方法1，但是不确定代码是否执行完成
            //mysqlCon.Close();
            #endregion


            #region/*关闭数据库方法2，通过using 语句实现数据库的关闭， 执行完该快自动关闭数据库 */
            //using (mysqlCon)
            //{
            //    mysqlCon.Open();

            //}
            #endregion


            #region/* 关闭数据库方法3, 通过try catch finally 来实现 */
            //try
            //{
            //    mysqlCon.Open();
            //    Console.WriteLine("DB成功打开");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    mysqlCon.Close();
            //}
            #endregion


            #region /*关闭数据库方法4 usig 与 try catch finally 结合使用*/
            try
            {
                using (mysqlCon)
                {
                    mysqlCon.Open();
                    Console.WriteLine("DB成功打开");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("DB成功打开失败");
                //throw;
            }
            finally
            {
                mysqlCon.Close();
            }
            #endregion

            Console.ReadKey();

        }
    }
}
