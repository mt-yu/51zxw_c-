using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._3_分部类概述及使用
{
    partial class arithmetic    //阶乘
    {
        public int factorial(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }


    partial class arithmetic    //平方
    {
        public int square(int num)
        {
            return num * num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            arithmetic ari = new arithmetic();
            Console.WriteLine(ari.factorial(2));
            Console.WriteLine(ari.square(2));

            Console.ReadKey();
        }
    }


}
