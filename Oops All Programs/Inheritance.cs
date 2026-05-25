using System;
namespace Oops_All_Programs
{
    class Branch
    {
        int bid;
        string bname;
        string baddress;
        public  Branch(int bid, string bname, string baddress)
        {
            this.bid = bid;
            this.bname = bname;
            this.baddress = baddress;
        }
        public void Branchdisplay()
        {
            Console.WriteLine("branch id is : " + bid);
            Console.WriteLine("branch name is: "+bname);
            Console.WriteLine("branch address id: " + baddress);
        }
    }
    class student:Branch
    {
        int id;
        string name;
        string clg;
        public student(int id, string name, string clg):base(1,"AAA","HYD")
        {
            this.id = id;
            this.name = name;
            this.clg = clg;
        }
        public void studentdisplay()
        {
            Console.WriteLine("student id is: " + id);
            Console.WriteLine("student name is : " + name);
            Console.WriteLine("student college is : " + clg);
            base.Branchdisplay();
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            student obj = new student(1, "JOHN", "LAYOLA");
            obj.studentdisplay();
        }
    }
}
