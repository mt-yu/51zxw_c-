using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _26._3_线程操作之创建线程
{
    class Program
    {
        public static void method()
        {
            for (int i = 101; i < 201; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i.ToString());             
                }
                else Console.Write(i.ToString() + "  ");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(method);
            Thread t = new Thread(ts);
            t.Start();

            Console.ReadLine();
        }
    }
}
