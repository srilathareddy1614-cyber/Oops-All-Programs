using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{ 
    class access
    {
        public int a = 10;
        public void Mymethod()
        {
            Console.WriteLine("value of a is : " + a);
        }
    }
    class class1
    {
        public void method()
        {
            access a=new access();
            Console.WriteLine("value of a under method is : " + a.a);
        }
    }
    internal class Public_am
    {
        static void Main(string[] args)
        {
            access a=new access();
            a.Mymethod();
            Console.WriteLine("valus of a under main method is :" + a.a);
            class1 cs = new class1();
            cs.method();
        }
    }
}
