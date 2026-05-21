//using System;
//namespace Oops_All_Programs
//{
//    class student
//    {
//        int sid;
//        string sname;

//        public student(int sid, string sname)
//        {
//            this.sid = sid;
//            this.sname = sname;
//        }
//        public void Display()
//        {
//            Console.WriteLine("student id is: " + sid);
//            Console.WriteLine("student name is:" + sname);
//            Console.WriteLine("**************************************");
//        }
//    }
//    internal class StudentArray
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enetr number of students");
//            int n=int.Parse(Console.ReadLine());
//            student[] stu = new student[n];
//            for(int i=0;i<n;i++)
//            {
//                Console.WriteLine("enetr student id");
//                int id=int.Parse(Console.ReadLine());
//                Console.WriteLine("enter student name");
//                string name=Console.ReadLine();
//                stu[i]=new student(id, name);
//            }
//            for(int i=0;i<stu.Length;i++)
//            {
//                stu[i].Display();
//            }
//        }
//    }
//}
