using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _18._1迭代器的概述
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = "test";
            ArrayList al = new ArrayList();
            for (int i = 0; i < mystr.Length; i++)
            {
                al.Add(mystr[i]);
            }
            TestForeach(al);

            Console.ReadKey();
        }

        static void TestForeach(ArrayList al)
        { 
            foreach(var outval in al)
                Console.WriteLine(outval);
        }
    }
}
