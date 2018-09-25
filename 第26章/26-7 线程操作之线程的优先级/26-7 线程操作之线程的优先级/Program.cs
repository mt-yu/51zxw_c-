using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _26_7_线程操作之线程的优先级
{

    class Program
    {
        public static void method()
        {

                Console.WriteLine("线程的名称:{0}", Thread.CurrentThread.Name.ToString());
                Console.WriteLine("线程的优先级:{0}", Thread.CurrentThread.Priority.ToString());

        }
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(method);
            ThreadStart ts2 = new ThreadStart(method);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);

            t1.Name = "t1";
            t2.Name = "t2";

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.BelowNormal;
            
            t1.Start();
            //Thread.Sleep(5);
            t2.Start();

            Console.ReadLine();
        }
    }
}
