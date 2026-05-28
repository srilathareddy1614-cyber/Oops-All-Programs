//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    abstract class project
//    {
//        public void Start()
//        {
//            Console.WriteLine("started the class");
//        }
//        public void Resume()
//        {
//            Console.WriteLine("resume the class");
//        }
//        public void Display()
//        {
//            Console.WriteLine("welcome");
//        }
//        public abstract void End();
//    }
//    class DerivedClass:project
//    {
//        public override void End()
//        {
//            Console.WriteLine("session has ended");
//        }
//    }
//    internal class Abstraction
//    {
//        static void Main(string[] args)
//        {
//            project p = new DerivedClass();
//            p.Display();
//            p.Start();
//            p.Resume();
//            p.End();
//        }
//    }
//}
