using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFileName = @"D:\同鑫\51自学网C#\test\text\test.txt";
            FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] buff = new byte[fs.Length];
            byte [] bu =  buff[1024];
            return;
        }
    }
}
