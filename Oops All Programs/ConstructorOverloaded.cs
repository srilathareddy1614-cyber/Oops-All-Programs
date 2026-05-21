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
        string clg;
        public student()
        {
            id = 101;
            name = "anu";
            clg = "xyz";
        }
        public student(int id,string name,string clg)
        {
            this.id = id;
            this.name = name;
            this.clg = clg;
        }
        public student(int id,string name)
        {
            this.id = id;
            this.name = name;
            clg = "not provided";
        }
        public void Display()
        {
            Console.WriteLine("student id is: " + id);
            Console.WriteLine("student name is: " + name);
            Console.WriteLine("student college is: " + clg);
        }
    }
    internal class ConstructorOverloaded
    {
        static void Main(string[] args)
        {
            student stu=new student();
            stu.Display();
            student obj=new student(102,"sri","HIJ");
            obj.Display();
            student para = new student(103, "latha");
            para.Display();
        }
    }
}
