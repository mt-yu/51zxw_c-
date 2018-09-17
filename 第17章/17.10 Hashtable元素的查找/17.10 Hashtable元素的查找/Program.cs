using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._10_Hashtable元素的查找
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
            ht[5] = "hq";

            foreach (DictionaryEntry myht in ht)
            {  
                Console.WriteLine("{0}:{1}",myht.Key,myht.Value);
            }
            if (ht.ContainsKey(2))
                Console.WriteLine("存在");
            Console.ReadKey();
        }
    }
}
