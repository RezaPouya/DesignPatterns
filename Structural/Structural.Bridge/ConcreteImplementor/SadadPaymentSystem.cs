using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public class SadadPaymentSystem : IPaymentSystem
    {
        public string message { get; set; }

        public void ProcessPayment(string paymentMethod)
        {
            message = $"The {paymentMethod} payment is done via Sadad payment system";
        }
    }
}
