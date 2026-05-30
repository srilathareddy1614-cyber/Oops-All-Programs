using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class BankAccount
    {
        long accnum;
        double balance;
        static string bankname = "SBI";
        public void display(long  accnum, double balance)
        {
             accnum=accnum;
             balance=balance;
            Console.WriteLine("bank name is : " + bankname);
            Console.WriteLine("account number is : " + accnum);
            Console.WriteLine("account balance is : " + balance);
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("deposited amount is : " + amount);
        }
        public void withdraw(double amount)
        {
            balance = balance - amount;
            Console.WriteLine("withdraw amount is : " + amount);
        }
    }
   
    internal class ExwithClassesObjects
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            obj.display(9876543212, 15000);
            obj.Deposit(5000);
            obj.withdraw(2000);
        }
    }
}
