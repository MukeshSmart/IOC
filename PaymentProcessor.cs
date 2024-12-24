using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IOC.PaymentFactory;

namespace IOC
{
    public class PaymentProcessor
    {
        private readonly PaymentMethodFactory _paymentMethodFactory;
        public PaymentProcessor(PaymentMethodFactory paymentMethodFactory)
        {
            _paymentMethodFactory = paymentMethodFactory;
        }

        public void Process(decimal amount)
        {
            var paymentMethod = _paymentMethodFactory();
            paymentMethod.ProcessPayment(amount);
        }
    }
}
