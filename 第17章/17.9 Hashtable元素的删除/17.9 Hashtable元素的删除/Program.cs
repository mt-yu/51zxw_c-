using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._9_Hashtable元素的删除
{

    class Program
    {

        static void displey(Hashtable h)
        {
            foreach (DictionaryEntry myht in h)
            {
                Console.WriteLine("{0}:{1}", myht.Key, myht.Value);
                
            }
            Console.WriteLine(h.Count);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "zs");
            ht.Add(2, "ls");
            ht.Add(3, "ww");
            ht.Add(4, "zl");

            displey(ht);

            ht.Remove(2);
            displey(ht);

            ht.Clear();
            displey(ht);

            Console.ReadKey();
            
        }

        
    }
}
