//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    abstract class person
//    {
//        protected string name;
//        protected int age;
//        public person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public void display()
//        {
//            Console.WriteLine("student name is : " + name);
//            Console.WriteLine("student age is : " + age);
//        }
//        public void Role()
//        {
//            Console.WriteLine("student role is to study");
//        }
//        public abstract void Rollnum();
//    }
//    abstract class Student:person
//    {
//        public int num;
//        public Student(string name,int age,int num):base(name,age)
//        {
//            this.num = num;
//        }
//        public abstract void Subject();
//    }
//    class Teacher:Student
//    {
//        public string sub;
//        public Teacher(string name, int age,int num,string sub) : base(name, age,num)
//        {
//            this.sub = sub;
//        }
//        public override void Rollnum()
//        {
//            Console.WriteLine($"student roll number is : {num} ");
//        }
//        public override void Subject()
//        {
//            Console.WriteLine($"subject name is : {sub}");
//        }
//        public void teacherrole()
//        {
//            Console.WriteLine("teacher role is teaching");
//        }
//    }
//    internal class AbstractInheritanceex
//    {
//        static void Main(string[] args)
//        {
//            Teacher t = new Teacher("srilatha", 21, 5, "maths");
//            t.display();
//            t.Rollnum();
//            t.Role();
//            t.Subject();
//            t.teacherrole();
//        }
//    }
//}
