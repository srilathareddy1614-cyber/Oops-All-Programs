using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class Employee
    {
        int id;
        string name;
        double sal;
        static string company;
        double salhike;
        public Employee(int id, string name, double sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }
        static Employee()
        {
            company = "infosys";
        }
        public void Display()
        {
            Console.WriteLine("employee id is : " + id);
            Console.WriteLine("employee name is : " + name);
            Console.WriteLine("employee salary is : " + sal);
        }
        public static void companydisplay()
        {
            Console.WriteLine("employee company is : " + company);
        }
        public void salaryhike( double per)
        {
            salhike = sal * per / 100;
            sal = sal + salhike;
            Console.WriteLine("hike : " + salhike);
            Console.WriteLine("salary after hike : " + sal);
        }
    }
    internal class EmpHW
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "ravi", 30000);
            emp.Display();
            Employee.companydisplay();
            emp.salaryhike(10);
            Employee obj = new Employee(2, "sita", 30000);
            obj.Display();
            Employee.companydisplay();
            obj.salaryhike(20);
        }
    }
}
