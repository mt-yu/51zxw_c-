using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _26._6_线程操作之终止线程
{
    class Program
    {
        public static void method()
        {
            for (int i = 1; i < 4000; i++)
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
            Thread t = new Thread(method);
            Console.WriteLine("线程开始启动");
            t.Start();
            int i = 0;
            while(t.IsAlive)
            {
                i++;
                //缓冲时间
                Thread.Sleep(5);
                if (i == 5)
                {
                    t.Abort();
                    Console.WriteLine("\r\t线程被终止");               
                }

            }

                Console.ReadLine();
            
        }
    }
}
