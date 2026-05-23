using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class student
    {
        int id;
        string name;
        public student()
        {
            id = 1;
            name = "ABC";
            Console.WriteLine("student details are assigned");
        }
        public void Display()
        {
            Console.WriteLine("student id is: " + id);
            Console.WriteLine("student name is: " + name);
        }
    }
    internal class SingleResponsible1
    {
        static void Main(string[] args)
        {
            student  s=new student();
            s.Display();
        }
    }
}
