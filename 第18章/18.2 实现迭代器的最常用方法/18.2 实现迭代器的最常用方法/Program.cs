using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _18._2_实现迭代器的最常用方法
{
    class Program
    {
        public static IEnumerable SimpleDemo()
        {
            yield return "string1";
            yield return "string2";
            yield return "string3";
            //yield break;
            yield return "string4";
            yield return "string5";

        }

        //写一个自己的迭代类的方法
        public class Months : IEnumerable
        { 
            string[] months = {"Jan", "Feb", "Mar", "Apr", "May","June", "July", "Aug", "Sep", "Oct", "Nov", "Dec"};
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < months.Length; i++)
                {
                    yield return months[i];
                }
            }
        }
        static void Main(string[] args)
        {
            foreach (string item in SimpleDemo())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("------------------");

            Months mon = new Months();
            foreach (string m in mon)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }
    }
}
