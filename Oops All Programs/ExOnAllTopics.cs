//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    abstract class person
//    {
//        public string name;
//        private int age;
//        private string role;
//        private string subject;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int Age
//        {
//            get { return age; }
//            set { age = value; }
//        }
//        public person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public void Display()
//        {
//            Console.WriteLine($"student name is : {name}");
//            Console.WriteLine($"student age is : {age}");
//        }
//        public abstract void Rollnum();
//    }
//    class Student : person
//    {
//        public int num;
//        public Student(string name, int age,int num) : base(name, age)
//        {
//            this.num = num;
//        }
//        public override void Rollnum()
//        {
//            Console.WriteLine("student roll number is : " + num);
//        }
       
//    }
    
//    internal class ExOnAllTopics
//    {
//        static void Main(string[] args)
//        {
//            person p = new Student("sri",21,2);
//            p.Display();
//            p.Rollnum();
//            //p=new Roles("study");
//            //p.Role();
//            //p = new Teacher("chemistry");
//            //p.Subject();
//            //p.Teacherrole();
//        }
//    }
//}






