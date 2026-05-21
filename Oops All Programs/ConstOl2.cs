//using System;
//using System.Diagnostics.Contracts;
//namespace Oops_All_Programs
//{
//    class overload
//    {
//        int id;
//        string name;
//        int sal;
//        public overload()
//        {
//            id = 101;
//            name = "anu";
//            sal = 35000;
//        }
//        public overload(int id,string name, int sal)
//        {
//            this.id = id;
//            this.name = name;
//            this.sal = sal;
//        }
//        public overload(string name)
//        {
//            this.name = name;
//        }
//        public overload(int sal)
//        {
//            this.sal=sal;
//        }
//        //public ConstOl2(int id)
//        //{
//        //    this.id = id;
//        //}
//        public void Display()
//        {
//            Console.WriteLine("emp id:" + id);
//            Console.WriteLine("emp name:" + name);
//            Console.WriteLine("emp sal:" + sal);
//        }
//    }
//    internal class ConstOl2
//    {
//        static void Main(string[] args)
//        {
//            overload ove = new overload();
//            ove.Display();
//            overload obj = new overload(102, "ash", 3456);
//            obj.Display();
//            overload load = new overload("da");
//            load.Display();
//            overload ol = new overload(34567);
//            ol.Display();

//        }
//    }
//}
