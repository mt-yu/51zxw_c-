using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _26._5_线程操作之线程的挂起与恢复
{
    class Program
    {
        public static void method()
        {
            for (int i = 1; i < 400; i++)
            {
                if (i % 40 == 0)
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.Write(">");
                }
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(method);
            Thread t = new Thread(ts);
            t.Start();
            while (t.IsAlive)
            {
                t.Suspend();
                Thread.Sleep(2000);
                t.Resume();
            }
            Console.ReadLine();
             
        }
    }
}
