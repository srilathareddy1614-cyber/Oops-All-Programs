using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class myclass
    {
        public void Display()
        {
            Console.WriteLine("welcome to oops");
        }
        public virtual void show()
        {
            Console.WriteLine("show is calling");
        }
    }
    class dc : myclass
    {
        public void Message()
        {
            Console.WriteLine("message is calling");
        }
        public override void show()
        {
            //base.show();
            Console.WriteLine("this is overriden method");
        }
    }
    internal class VirtualMethod
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.Display();
            obj.show();
            dc objdc = new dc();
            objdc.Message();
            objdc.show();
        }
    }
}
