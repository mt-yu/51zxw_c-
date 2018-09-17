using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_索引器在类中的使用
{
    class Program
    {
        public class indexText //访问类实例
        {
            private int[] array = new int[10];  // 初始化数组容量为10
            public int this[int index]
            {
                get {
                    if (index < 0 || index >= 10)
                        return -1;
                    else
                        return array[index];
                    }
                set 
                {
                    if (index >= 0 && index < 10)
                        array[index] = value;
                }
            }

        }

        public class weekIndex //访问类成员
        { 
            string[] Week ={"星期一","星期二","星期三","星期四","星期五","星期六","星期日"};
            private int getDay(string weekText)
            {
                int i = 0;
                foreach (string day in Week)
                {
                    if (day == weekText) return i;
                    i++;
                }
                return -1;
            }
            public int this[string week]
            {
                get { return getDay(week); }
            }

        }
        static void Main(string[] args)
        {
            //访问类实例
            indexText Arr = new indexText();
            Arr[-5] = 5;
            Arr[0] = 15;
            Arr[1] = 30;
            Arr[11] = 65;
            Console.WriteLine("{0},{1}", Arr[-5],Arr[11]);

            //访问类成员
            weekIndex we = new weekIndex();
            Console.WriteLine(we["星期一"]);



            Console.ReadKey();
        }
    }
}
