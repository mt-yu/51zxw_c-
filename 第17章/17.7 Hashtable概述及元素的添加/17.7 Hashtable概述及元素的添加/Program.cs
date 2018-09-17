using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._7_Hashtable概述及元素的添加
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //添加元素
            ht.Add(1, "zs");
            ht.Add(2, "ls");
            Console.WriteLine(ht[1]);

            ht[3] = "ww"; //
            ht[1] = "zl";

            Console.WriteLine(ht.Count);
            Console.WriteLine(ht[1]);

            Console.ReadKey();

        }
    }
}
