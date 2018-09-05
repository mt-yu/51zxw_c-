using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8字符串的合并
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strarr = { "51zxw", "immt", "test" };
            string str1 = string.Join("*", strarr);
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
