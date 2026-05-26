//using System;
//namespace Oops_All_Programs
//{
//    public class Person
//    {
//        public int Age;
//        public string Name;
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//        public Person(Person previousperson)
//        {
//            Name = previousperson.Name;
//            Age = previousperson.Age;
//        }
//        public string Details()
//        {
//            return Name + " is " + Age.ToString();
//        }
//    }
//    internal class CopyConstructor2
//    {
//        static void Main(string[] args)
//        {
//            Person p1 = new Person("goerge", 39);
//            Person p2 = new Person(p1);
//            p1.Age = 39;
//            p2.Age = 41;
//            p2.Name = "charles";
//            Console.WriteLine(p1.Details());
//            Console.WriteLine(p2.Details());
//            Console.WriteLine(" press any key to exit");
//            Console.ReadKey();
//        }
//    }
//}
