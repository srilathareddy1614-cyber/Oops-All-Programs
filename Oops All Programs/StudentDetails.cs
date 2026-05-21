//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_All_Programs
//{
//    class student
//    {
//        int id;
//        string name;
//        string clg;
        
//        public void Details( int id,string name,string clg)
//        {
//            id = id;
//            name = name;
//            clg = clg;
//            Console.WriteLine("student id is: " + id);
//            Console.WriteLine("student name is : " + name);
//            Console.WriteLine("student clg is: " + clg);
//        }
//        public void Marks( double m1,double m2,double m3)
//        {
      
//            double total = m1 + m2 + m3;
//            double avg = total / 3;
//            Console.WriteLine("total marks : " + total);
//            Console.WriteLine("avg marks : " + avg);
//            if(avg>90)
//            {
//                Console.WriteLine("grade is A");
//            }
//            else if(avg>80)
//            {
//                Console.WriteLine("grade is B");
//            }
//            else if(avg>70)
//            {
//                Console.WriteLine("grade is C");
//            }
//            else if(avg>60)
//            {
//                Console.WriteLine("failed");
//            }
//            else
//            {
//                Console.WriteLine(" enter valid data");
//            }
//        }
//    }
//    internal class StudentDetails
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter student id");
//            int id=int.Parse(Console.ReadLine());
//            Console.WriteLine("enter student name");
//            string name = Console.ReadLine();
//            Console.WriteLine("enter clg");
//            string clg = Console.ReadLine();
//            Console.WriteLine("m1:");
//            double m1=double.Parse(Console.ReadLine());
//            Console.WriteLine("m2:");
//            double m2 = double.Parse(Console.ReadLine());
//            Console.WriteLine("m3:");
//            double m3 = double.Parse(Console.ReadLine());
//            student obj=new student();
//            obj.Details( id,  name,  clg);
//            obj.Marks(m1,m2,m3);

//        }
//    }
//}
