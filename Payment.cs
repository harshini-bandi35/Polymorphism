/* 1.	1. Explain Polymorphism in C# with a Real-World Example.
   **Estimated Time:** 5 minutes
   *polymorphism is basically an interface which includes both class and methods to have more forms
   *which meanse the same method can be used in different ways in different classes.
here is the real world example of polymorphism, which is an online payment system.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Payment
    {
        public virtual void Paymentmethod()
        {
            Console.WriteLine("This is the online payment system");

        }
    }
    public class CreditCard : Payment
    {
        public override void Paymentmethod()
        {
            Console.WriteLine("This is the creditcard payment method");
        }
    }
    public class DebitCard : Payment
    {
        public override void  Paymentmethod()
        {
            Console.WriteLine("This is the debitcard payment method");
        }
    }
    public class UPIpayment : Payment
    {
        public override void Paymentmethod()
        {
            Console.WriteLine("This is the UPI payment method");
        }
    }
}
