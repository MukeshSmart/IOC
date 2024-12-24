using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IOC.PaymentFactory;

namespace IOC
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaymentMethodFactory _creditCard = () => new CreditCardPayment();
            PaymentProcessor paymentProcessor = new PaymentProcessor(_creditCard);
            paymentProcessor.Process(100.00m);   
        }
    }
}
