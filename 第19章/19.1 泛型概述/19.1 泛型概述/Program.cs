using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace _19._1_泛型概述
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型声明
            List<int> list = new List<int>();

            list.Add(2);
            list.AddRange(new int[] { 2, 3, 4, 5 });
            Console.WriteLine(list.Count);
            System.Collections.Generic.LinkedList<int> lk = new LinkedList<int>();
            Console.ReadKey();
        }
    }
}
