//using System;
//namespace Oops_All_Programs
//{
//    class employee
//    {
//        int id;
//        string name, loc, email;
//        long phno;
//        double sal;
//        public void Details(int id,string name,string loc,string email,long phno,double sal)
//        {
//            id = id;
//            name = name;
//            loc = loc;
//            email = email;
//            phno = phno;
//            sal = sal;
//            Console.WriteLine("emmployee id : " + id);
//            Console.WriteLine("emmployee name : " + name);
//            Console.WriteLine("emmployee location : " + loc);
//            Console.WriteLine("employee email : " + email);
//            Console.WriteLine("emmployee mobile number : " + phno);
//            Console.WriteLine("employee salry : " + sal);
//        }
//        public void Salary(double sal)
//        {
//            double hike =sal+(sal * 30/100);
//            Console.WriteLine("salary after hike : " + hike);
//        }
//    }
//    internal class EmpDetails
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("id : ");
//            int id=int.Parse(Console.ReadLine());
//            Console.WriteLine("name:");
//            string name=Console.ReadLine();
//            Console.WriteLine("location:");
//            string loc= Console.ReadLine();
//            Console.WriteLine("email:");
//            string email= Console.ReadLine();
//            Console.WriteLine("moblie:");
//            long phno=long.Parse( Console.ReadLine());
//            Console.WriteLine("salary : ");
//            double sal=double.Parse( Console.ReadLine());
//            employee obj = new employee();
//            obj.Details(id, name, loc, email, phno, sal);
//            obj.Salary(sal);
//        }
//    }
//}
