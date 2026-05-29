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
//        private int id;
//        public person(string name, int id)
//        {
//            this.name = name;
//            this.id = id;
//        }
//        public void Display()
//        {
//            Console.WriteLine($"name {name} and age {id}");
//        }
//        public abstract void role();
//    }
//    class student : person
//    {
//        public int rollnum;
//        public student(string name, int age, int rollnum) : base("sri", 121)
//        {
//            Console.WriteLine("roll numberr is : " + rollnum);
//        }

//        public override void role()
//        {
//            Console.WriteLine("i am a student");
//        }
//    }


//    internal class ConstructorAbstract
//    {
//        static void Main(string[] args)
//        {
//            student s = new student("ravi", 21, 101);
//            s.Display();
//            s.role();
//        }
//    }
//}
