using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _17._6正则表达式拆分
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "一、张三 二、李四 三、王五 四、赵六";
            string pattern = @"\b[一二三四]、";

            //静态值方法
            foreach (string outstr in Regex.Split(input, pattern))
            {
                if(!string.IsNullOrEmpty(outstr))
                    Console.WriteLine(outstr);
            }
            

            //实例引用方法

            Console.ReadKey();
        }
    }
}
