//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    interface Ishape
//    {
//        void Area();
//        double Perimeter();
//    }
//    public class Circle : Ishape
//    {
//        public double radius { get; set; }
//        public void area()
//        {
//            Console.WriteLine("area of circle is : " + (Math.PI * radius * radius));
//        }
//        public double Perimeter()
//        {
//            return 2 * Math.PI + radius;
//        }
//    }
//    public class Rectangle : Ishape
//    {
//        public double length { get; set; }
//        public double width { get; set; }
//        public void area()
//        {
//            Console.WriteLine("area of rectangle is : " + (length * width));
//        }
//        public double Perimeter()
//        {
//            return 2 * (length + width);
//        }
//    }
//    internal class InterfaceEx
//    {
//        static void Main(string[] args)
//        {
//            Ishape circle = new Circle { radius = 5 };
//            circle.Area();
//            Console.WriteLine("perimeter of circle is : " + circle.Perimeter());
//            Ishape rectangle = new Rectangle { length = 5, width = 6 };
//            rectangle.Area();
//            Console.WriteLine("perimeter of reactangle is : " + rectangle.Perimeter());
//        }
//    }
//}
