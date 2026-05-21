using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class newclass
    {
        int a;
        int b;
        public newclass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            int c= a + b;
            Console.WriteLine("sum is: " + c);
        }
    }
    internal class AddUsingThisKeyword
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass(25, 38);
            obj.Add();
        }
    }
}
