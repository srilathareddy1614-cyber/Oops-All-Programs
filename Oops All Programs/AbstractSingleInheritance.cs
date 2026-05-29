//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    abstract class vehicle
//    {
//        protected string vehiclename;
//        public vehicle(string vehiclename)
//        {
//            this.vehiclename = vehiclename;
//        }
//        public void showdetails()
//        {
//            Console.WriteLine($"vehicle name is : {vehiclename}");
//        }
//        public abstract void vehicletype(); 
//    }
//    abstract class vehiclemodel:vehicle
//    {
//        public string modelname;
//        public vehiclemodel(string vehiclename,string modelname):base(vehiclename)
//        {
//            this.modelname = modelname;
//        }
//        public void Display()
//        {
//            Console.WriteLine($"model name is : {modelname}");
//        }
//        public abstract void modeltype();
//    }
//    class vehicledata:vehiclemodel
//    {
//        public int vehiclenum;
//        public vehicledata(string vehiclename,string modelname,int vehiclenum):base(vehiclename,modelname)
//        {
//            this.vehiclenum= vehiclenum;
//        }
//        public override void vehicletype()
//        {
//            Console.WriteLine(" vehicle type is cars");
//        }
//        public override void modeltype()
//        {
//            Console.WriteLine(" model type is electric");
//        }
//    }
//    internal class AbstractSingleInheritance
//    {
//        static void Main(string[] args)
//        {
//            vehicledata vd = new vehicledata("audi", "A8", 5555);
//            vd.vehicletype();
//            vd.modeltype();
//            vd.showdetails();
//            vd.Display();
      
            
//        }
//    }
//}
