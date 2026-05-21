using System;
namespace Oops_All_Programs
{
    class student
    {
        int id;
        string name;
        static string clg = "Navodaya";
    
    public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Details()
        {
            Console.WriteLine("studnt id is: " + id);
            Console.WriteLine("student name is: " + name);
            Console.WriteLine("student clg is: " + clg);
        }
    }
    internal class Student1
    {
        static void Main(string[] args)
        {
            student obj = new student(101, "srilatha");
            obj.Details();
        }
    }
}
