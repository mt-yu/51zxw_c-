 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _17._4_Csharp中正则表达式的构建与匹配
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(0349|0349-)\d{7,8}$";
            string[] input = {"010-1234567", "0349-1234567", "034912345678", "075912345678", "15112345678" };

            foreach(string outstr in input)
            {
                //静态（值）方法
                bool mybool = Regex.IsMatch(outstr.Trim(), pattern);
                if (mybool) Console.WriteLine(outstr + "是朔州市电话号码");
                else Console.WriteLine(outstr + "不是朔州市电话号码");
                
                //实例化方法
                Match mymatch = Regex.Match(outstr.Trim(), pattern);
                if (mymatch.Success) Console.WriteLine(outstr + "是朔州市电话号码");
                else Console.WriteLine(outstr + "不是朔州市电话号码");
            }




            Console.ReadKey();
        }

        
    }
}
