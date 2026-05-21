//using System;
//namespace Oops_All_Programs
//{
//    class employee
//    {
//        int id;
//        string name;
//        int salary;
//        public employee(int id, string name, int sal)
//        {
//            this.id = id;
//            this.name = name;
//            this.salary = sal;
//        }
//        public void Display()
//        {
//            Console.WriteLine("employee id is: " + id);
//            Console.WriteLine("employee name is: " + name);
//            Console.WriteLine("employee salry is: " + salary);
//            Console.WriteLine("***********************************");
//            Console.WriteLine(" ");
//        }

//    }
//    internal class EmpArray
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter number of employees: ");
//            int n = int.Parse(Console.ReadLine());
//            employee[] emp = new employee[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("enter employee id: ");
//                int id = int.Parse(Console.ReadLine());
//                Console.WriteLine("enter employee name:");
//                string name = Console.ReadLine();
//                Console.WriteLine("enter employee salary :  ");
//                int sal = int.Parse(Console.ReadLine());
//                Console.WriteLine(" ");
//                emp[i] = new employee(id, name, sal);

//            }
//            for (int i = 0; i < emp.Length; i++)
//            {
//                emp[i].Display();
//            }
//        }
//    }
//}
