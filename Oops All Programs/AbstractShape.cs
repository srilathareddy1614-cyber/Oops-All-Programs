////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Oops_All_Programs
////{
////    abstract class Shape
////    {
////        public string shapename;
////        public Shape(string shapename)
////        {
////            this.shapename = shapename;
////        }
////        public void Details()
////        {
////            Console.WriteLine("shape is : " + shapename);
////        }
////        public abstract void Area();
////    }
////    abstract class Calculatearea:Shape
////    {
////        public double area;
////        public int radius;
////        public Calculatearea(string shapename,int radius) : base(shapename)
////        {
////            this.radius = radius;
////        }
////        public override void Area()
////        {
////            area = 3.14 * (radius * radius);
////            Console.WriteLine("area of " + shapename + " is : " + area);
////        }
////        public abstract void parameters();
////     }
////    class Calculateparameter:Calculatearea
////    {
////        public double Parameter;
////        public int length;
////        public int breadth;
////        public Calculateparameter(string shapename,int radius, int length, int breadth) :base(shapename,radius)
////        {
////            this.length = length;
////            this.breadth = breadth;
////        }

////        public override void parameters()
////        {
////            Parameter = length * breadth;
////            Console.WriteLine("area of " + shapename + " is :" + Parameter);
////        }
////    }
////    internal class AbstractShape
////    {
////        static void Main(string[] args)
////        {
////            Calculatearea obj = new Calculateparameter("circle", 5,8,9);
////            obj.Details();
////            obj.Area();
////            Calculateparameter sobj=new Calculateparameter("rectangle",5,8,9);
////            sobj.Details();
////            sobj.parameters();
////        }
////    }
////}




//using System;
//namespace project
//{
//    abstract class shape
//    {
//        public void shape1()
//        {
//            Console.WriteLine("shape is circle");
//        }
//        public void shape2()
//        {
//            Console.WriteLine("shape is rectangle");
//        }
//        public abstract void Circle(); 
//    }
//    abstract class Circlearea : shape
//    {
//        public int radius;
//        public Circlearea(int radius)
//        {
//            this.radius = radius;
//        }
//        public override void Circle()
//        {
//            double area = 22 / 7 * radius * radius;
//            Console.WriteLine("circle area is : " + area);
//        }
//        public abstract void Rectangle();
//    }
//    class Rectanglearea : Circlearea
//    {
//        public int length;
//        public int breadth;
//        public Rectanglearea(int radius,int length, int breadth): base(radius)
//        {
//            this.length = length;
//            this.breadth = breadth;
//        }
//        public override void Rectangle()
//        {
//            int area = length * breadth;
//            Console.WriteLine("area of reactangle is : " + area);
//        }
//    }
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            Circlearea obj = new Rectanglearea(5,8,9);
//            obj.shape1();
//            obj.Circle();
//            Rectanglearea r=new Rectanglearea(5,8,9);
//            r.shape2();
//            r.Rectangle(); 

//        }
//    }
//}