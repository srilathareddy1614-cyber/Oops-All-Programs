using System;
namespace Oops_All_Programs
{
    class Student
    {
        public int Id;
        public string Name;
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Student(Student stu)
        {
            Id = stu.Id;
            Name = stu.Name;
        }
        public void Display()
        {
            Console.WriteLine("student id is : " + Id);
            Console.WriteLine("student name is : " + Name);
        }
    }
    internal class CopyConstructor
    {
        static void Main(string[] args)
        {
            Student obj = new Student(1, "abc");
            obj.Display();
            Student stu = new Student(obj);
            stu.Display();
        }

    }
}
