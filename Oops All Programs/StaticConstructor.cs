//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{ 
//    class student
//    {
//        int id;
//        string name;
//        static string clg;
//        public student(int id, string name)
//        {
//            this.id = id;
//            this.name = name;
//        }
//        static student()
//        {
//            clg = "JNTU";
//        }
//        public void Display()
//        {
//            Console.WriteLine("student id is : " + id);
//            Console.WriteLine("student name is  : " + name);
//        }
//        public static void CollegeDispaly()
//        {
//            Console.WriteLine("student college is : " + clg);
//        }
//    }
//    internal class StaticConstructor
//    {
//        static void Main(string[] args)
//        {
//            student obj = new student(1, "ABC");
//            obj.Display();
//            student s = new student(2, "XYZ");
//            s.Display();
//            student stu = new student(3,"AYO");
//            stu.Display();
//            student.CollegeDispaly();
//        }
//    }
//}
