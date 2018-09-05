using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7_字符串分割
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "51zxw-test-123+555";
            char[] c = { '-', '+' };
            string []str2 = str1.Split(c);
            foreach (string item in str2)
	        {
		            Console.Write(item+" ");
	        }

            Console.ReadKey();
        }
    }
}
