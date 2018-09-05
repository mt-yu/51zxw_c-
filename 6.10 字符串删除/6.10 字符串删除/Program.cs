using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10_字符串删除
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "testimmt";
            Console.WriteLine(str1.Remove(3, 5));
            Console.WriteLine(str1.Remove(3));

            Console.ReadKey();

        }
    }
}
