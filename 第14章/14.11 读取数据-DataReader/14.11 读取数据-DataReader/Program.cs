using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._11_读取数据_DataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = GetConnectionString();
            SqlConnection mycon = new SqlConnection(constr);

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    string sql = "select * from mytable001";
                    SqlCommand mycom = new SqlCommand(sql, mycon);

                    //声明datareader
                    SqlDataReader mydtr;
                    mydtr = mycom.ExecuteReader();
                    if (mydtr.HasRows)
                    {
                        //Console.WriteLine("mytable001存在数据");
                    }
                    else { Console.WriteLine("mytable001不存在数据"); }

                    //Console.WriteLine(mydtr.FieldCount);
                    //Console.WriteLine(mydtr.IsClosed);
                    //Console.WriteLine(mydtr.GetName(1));
                    //Console.WriteLine(mydtr.GetDataTypeName(1));
                    //Console.WriteLine(mydtr.GetOrdinal("name"));
                    //if(mydtr.Read())
                    //    Console.WriteLine(mydtr.GetValue(1));

                    object[] myobj = new object[mydtr.FieldCount];
                    
                    while (mydtr.Read())
                    {
                        mydtr.GetValues(myobj);
                        foreach (object outobj in myobj) Console.Write(outobj + "\t");

                        Console.WriteLine("\n");
                    }

                    

                    mydtr.Close();
                    //Console.WriteLine(mydtr.IsClosed);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }

            Console.ReadKey();

        }

        static private string GetConnectionString()
        { 
            return @"Data Source = DESKTOP-8BNS2H2\SQLMT; user = sa; pwd = asdf12; database = DBcsharp";
        }
    }
}
