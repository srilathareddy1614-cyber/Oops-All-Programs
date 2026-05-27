using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class Patient
    {
        private string name;
        private int age;
        private string medhistory;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Medhistory
        {
            get { return medhistory; }
            set {  medhistory = value; }
        }
        public Patient(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public bool IsEligibleForSurgery()
        {
            return Age >= 18;
        }
        public void DislayHistory()
        {
            Console.WriteLine("patient name is : " + name);
            Console.WriteLine("patient age is : " + age);
        }
    }
    internal class Encapsulation3
    {
        static void Main(string[] args)
        {
            Patient p = new Patient("ravi", 31);
            p.DislayHistory();
            p.Medhistory="DIABETICS";
            Console.WriteLine("patient is eligible or not : "+p.IsEligibleForSurgery());
            Console.WriteLine("patient is suffering with " +p.Medhistory);
            Patient p1 = new Patient("raji", 48);
            p1.DislayHistory();
            p1.Medhistory = "HIGH BP";
            Console.WriteLine("patient is eligible or not : " + p1.IsEligibleForSurgery());
            Console.WriteLine("patient is suffering with " + p1.Medhistory);
        }
    }
}
