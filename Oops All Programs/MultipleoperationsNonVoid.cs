//using System;
//namespace Oops_All_Programs
//{
//    class math
//    {
//        public int Add(int a,int b)
//        {
//            int c = a + b;
//            return c;
//        }
//        public int Sub(int a, int b)
//        {
//            int c = a - b;
//            return c;
//        }
//        public int Mul(int a, int b)
//        {
//            int c = a * b;
//            return c;
//        }
//        public int Div(int a, int b)
//        {
//            int c = a / b;
//            return c;
//        }
//        public int Mod(int a, int b)
//        {
//            int c = a % b;
//            return c;
//        }
//    }
//    internal class MultipleoperationsNonVoid
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter a number");
//            int x=int.Parse(Console.ReadLine());
//            Console.WriteLine("enter a number");
//            int y = int.Parse(Console.ReadLine());
//            math obj=new math();
//            int result= obj.Add(x, y);
//            int r1= obj.Sub(x, y);
//            int r2=obj.Mul(x, y);
//            int r3=obj.Div(x, y);
//            int r4=obj.Mod(x, y);
//            Console.WriteLine( " addition result is "+result);
//            Console.WriteLine("sub result is " + r1);
//            Console.WriteLine("mul result is " + r2);
//            Console.WriteLine("div result is " + r3);
//            Console.WriteLine(" mod result is " + r4);
//        }
//    }
//}
