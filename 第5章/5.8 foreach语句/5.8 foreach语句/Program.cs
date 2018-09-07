using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8_foreach语句
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcd";
            foreach (char item in str)
            {
                if (char.IsWhiteSpace(item))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(item); 
                }

            }

            Console.ReadKey();
        }
    }
}
