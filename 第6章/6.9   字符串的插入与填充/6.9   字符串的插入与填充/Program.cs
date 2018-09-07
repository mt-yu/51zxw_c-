using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9___字符串的插入与填充
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "test";
            //插入
            Console.WriteLine(str1.Insert(4,".com"));
            
            //填充
            Console.WriteLine(str1.PadRight(6, '*'));
            Console.ReadKey();
        }
    }
}
