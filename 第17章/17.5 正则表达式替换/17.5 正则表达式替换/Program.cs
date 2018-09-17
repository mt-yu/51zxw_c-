using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _17._5_正则表达式替换
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "welcome to www.mt_yu.com www.mt_yu.net www.mt_yu.org";
            string pattern = @"\bw{3}\.\w+\.(com|net|org)\b";   //正则表达式
            string replacement = "\n"+@"http:\\$&";                  //替换后的效果

            //                              带匹配字符串，正则表达式，替换内容，正则选项.IgnoreCase 忽略大小写
            Console.WriteLine(Regex.Replace(input, pattern, replacement, RegexOptions.IgnoreCase));
            Console.WriteLine(Regex.Replace(input, "www.", "\n"+@"http:\\$&", RegexOptions.IgnoreCase));

            //实例化方法
            Regex myregex = new Regex(pattern,RegexOptions.IgnoreCase);
            string result = myregex.Replace(input, replacement);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
