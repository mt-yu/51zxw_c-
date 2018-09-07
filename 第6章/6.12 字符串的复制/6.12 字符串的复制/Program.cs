using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._12_字符串的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "test";

            string st2 = string.Copy(st1);

            string st3 = st2;

            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            string str1 = "test-immt-y";
            char[] c1 = new char[20];
 

            Console.ReadKey();

        }
    }
}
