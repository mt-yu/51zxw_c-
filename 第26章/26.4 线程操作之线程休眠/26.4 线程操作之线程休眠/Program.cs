using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _26._4_线程操作之线程休眠
{
    class Program
    {
        public static void method()
        {
            string state;
            for (int i = 1; i <= 5000; i++)
            {
                state = Thread.CurrentThread.ThreadState.ToString();
                if (i % 5 == 0)
                {
                    Console.WriteLine("当前线程状态:{0}", state);
                }
            }

        }

        static void Main(string[] args)
        {
            //委托实例
            ThreadStart ts = new ThreadStart(method);
            Thread t = new Thread(ts);
            t.Start();

            while (t.IsAlive)
            {
                Console.WriteLine("线程开始执行！");
                Thread.Sleep(1);
            }
          
            Console.ReadLine();
        }
    }
}
