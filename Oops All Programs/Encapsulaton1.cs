using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    class account
    {
        private double balance;
        public void Diposit(double amount)
        {
            if(amount>0)
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if(amount<=balance)
            {
                balance -= amount;
            }
        }
        public double Getbalance()
        {
            return balance;
        }
    }
    internal class Encapsulaton1
    {
        static void Main(string[] args)
        {
            account acc=new account();
            acc.Diposit(5000);
            acc.Withdraw(2000);
            Console.WriteLine("balance is : "+acc.Getbalance());

        }
    }
}
