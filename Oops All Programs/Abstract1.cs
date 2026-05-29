//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    abstract class HMWBS
//    {
//        public void BillDetails()
//        {
//            Console.WriteLine("bill generated");
//        }
//        public abstract void GetBill(double units);
//    }
//    class residentialcustomers : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 7;
//            Console.WriteLine("residential customer bill is " + bill);
//        }
//    }
//    class commercialcustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 10;
//            Console.WriteLine("commercial customer bill is " + bill);
//        }
//    }
//    class agriculturecustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 0;
//            Console.WriteLine("agriculture customer bill is " + bill);
//        }
//    }
//    class industrycustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 15;
//            Console.WriteLine("industry customer bill is " + bill);
//        }
//    }
//    internal class Abstract1
//    {
//        static void Main(string[] args)
//        {
//            HMWBS obj = new residentialcustomers();
//            obj.BillDetails();
//            Console.WriteLine("enter number of units");
//            double unit = double.Parse(Console.ReadLine());
//            obj.GetBill(unit);
//            obj = new commercialcustomer();
//            obj.GetBill(unit);
//            obj = new industrycustomer();
//            obj.GetBill(unit);
//            obj = new agriculturecustomer();
//            obj.GetBill(unit);
//        }
//    }
//}
