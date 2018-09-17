using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4_索引器概述及声明
{
    public class Clerk
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //字段
        private char gender;
        //属性
        public char Gender
        {
            get 
            {   if(gender != '男' && gender != '女')
                    gender = '男'; 
                return gender;
            }
            set
            {
                gender = value;
            }
        }


        private int[] myint = new int[10];
        //索引器
        public int this[int index]
        {
            get { return myint[index]; }
            set { myint[index] = value; }
        }

        private int[] myintv = new int[10];
        //虚拟索引器
        public virtual int this[int index]
        {
            get { return myintv[index]; }
        }

        //外部索引器
        public extern int this[int index]
        {//不提供任何实际的实现，所以他提供空的get和set
            get;
            set;
        }

    }

   
    abstract class indexEaxmple
    {
        //抽象索引器
        public abstract int this[int index]
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
