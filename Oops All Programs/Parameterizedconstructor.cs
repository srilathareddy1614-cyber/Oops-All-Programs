//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    class employee
//    {
//        int id;
//        string name;
//        double sal;
//        static string companyname = "infosys"; 
//       public employee(int Id, string Name, double Sal)
//        {
//            id = Id;
//            name = Name;
//            sal = Sal;
//        }
//        public void Display()
//        {
//            Console.WriteLine("employee id is: " + id);
//            Console.WriteLine("employee name is: " + name);
//            Console.WriteLine("employee salary is: " + sal);
//            Console.WriteLine("employee company name is: " + companyname);
//        }
//    }
//    internal class Parameterizedconstructor
//    {
//        static void Main(string[] args)
//        {
//            employee emp = new employee(101, "srilatha", 30000);
//            emp.Display();
//            employee obj = new employee(102, "anusha", 35000);
//            obj.Display();
//        }
//    }
//}
