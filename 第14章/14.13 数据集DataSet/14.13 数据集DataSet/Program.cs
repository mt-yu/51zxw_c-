using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _14._13_数据集DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*创建DataSet对象*/
            DataSet myds = new DataSet("chsharp51zxw");

            /*创建DataTable对象*/
            DataTable mydt = new DataTable("mytable002");

            /*将DataTable对象加入DataSet对象*/
            myds.Tables.Add(mydt);

            /*定义列，并向DataTable中增加已经定义好的列*/
            DataColumn mydcoll1 = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn mydcoll2 = new DataColumn("name", Type.GetType("System.String"));
            DataColumn mydcoll3 = new DataColumn("department", Type.GetType("System.String"));
            mydt.Columns.Add(mydcoll1);
            mydt.Columns.Add(mydcoll2);
            mydt.Columns.Add(mydcoll3);

            /*插入行数据*/
            string[,] mystr = {{"张三", "研发部"},{"李四", "研发部"},{"王五", "研发部"},{"赵六", "研发部"} };

            for (int i = 0; i < mystr.Length / 2; i++)
            {
                DataRow myrow = mydt.NewRow();
                myrow["id"] = i;
                myrow[1] = mystr[i, 0];
                myrow[2] = mystr[i, 1];
                mydt.Rows.Add(myrow);

            }
            myds.AcceptChanges();   //保存提交

            Console.WriteLine("更改前的数据");
            outValues(myds);


            DataTable mydt002 = mydt.Clone();   //复制表结构但不复制数据 可与Merge搭配使用
            DataRow mydrow = mydt002.NewRow();
            mydt002.Rows.Add(new object[] { 4, "王小二", "测试部" });
            mydt002.Rows.Add(new object[] { 5, "张小四", "技术部" });

            myds.Merge(mydt002);    //将mydt002及其架构合并到myds中
            Console.WriteLine("\n合并后的数据集");
            outValues(myds);

            DataSet myds001 = myds.Copy();
            DataSet myds002 = myds.Clone();
            Console.WriteLine("copy结果: ");
            outValues(myds001);

            Console.WriteLine("clone结果");
            outValues(myds002);




            Console.ReadKey();

        }

        public static void outValues(DataSet ds)    //实现遍历dataset
        {
            foreach (DataTable outtable in ds.Tables)
            {
                Console.WriteLine("表名称:" + outtable.TableName);

                foreach (DataRow outdr in outtable.Rows)
                {
                    foreach (DataColumn outdcol in outtable.Columns)
                    {
                        Console.Write(outdr[outdcol] +  "\t");
                        
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
