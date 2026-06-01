using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_All_Programs
{
    interface Ipaymentgateway
    {
        void processpayment();
    }
    class paypal: Ipaymentgateway
    {
        public void processpayment()
        {
            Console.WriteLine("your payment is processed through Paypal");
        }
    }
    class upi:Ipaymentgateway
    {
        public void processpayment()
        {
            Console.WriteLine("your Payment is processing through UPI");
        }
    }
    class creditcard:Ipaymentgateway
    {
        public void processpayment()
        {
            Console.WriteLine("ur payment is processing through credit card");
        }
    }
    class debitcard:Ipaymentgateway
    {
        public void processpayment()
        {
            Console.WriteLine("ur Payment is processed through debit card");
        }
    }
    class netbanking:Ipaymentgateway
    {
        public void processpayment()
        {
            Console.WriteLine("ur Payment is done by net banking");
        }
    }
    internal class MultipleInterface2
    {
        static void Main(string[] args)
        {
            Ipaymentgateway p1=new paypal();
            p1.processpayment();
            Ipaymentgateway p2=new upi();
            p2.processpayment();
            Ipaymentgateway p3=new creditcard();    
            p3.processpayment();
            Ipaymentgateway p4=new debitcard();
            p4.processpayment();
            Ipaymentgateway p5=new netbanking();
            p5.processpayment();
        }
    }
}
