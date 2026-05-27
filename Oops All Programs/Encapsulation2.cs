using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class account
    {
        private double balance;
        private string pin;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            if(amount >0)
            {
                balance += amount;
            }
        }
        public void withdraw(double amount,string enteredpin)
        {
            if(enteredpin==pin&&amount<=balance)
            {
                balance -= amount;
            }
        }
        public account(double initialbalance,string accountpin)
        {
            balance = initialbalance;
            pin = accountpin;
        }
    }
    internal class Encapsulation2
    {
        static void Main(string[] args)
        {
            account acc = new account(10000, "1234");
            acc.Deposit(5000);
            acc.withdraw(2000, "8987");
            Console.WriteLine("final balance is : " + acc.Balance);
        }
    }
    
}


