using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11_字符串修剪
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] c = {'+', '-'};
            string str1 = "-+-+a++test--";
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim(c));
            Console.WriteLine(str1.TrimEnd(c));
            Console.ReadKey();
        }
    }
}
