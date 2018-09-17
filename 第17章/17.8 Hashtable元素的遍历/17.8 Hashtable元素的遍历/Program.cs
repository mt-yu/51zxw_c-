using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._8_Hashtable元素的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "zs");
            ht.Add(2, "ls");
            ht.Add(3, "ww");
            ht.Add(4, "zl");
            foreach(DictionaryEntry myobj in ht)
            {
                Console.WriteLine(myobj.Key+"="+myobj.Value);
            }

            Console.ReadKey();

        }
    }
}
