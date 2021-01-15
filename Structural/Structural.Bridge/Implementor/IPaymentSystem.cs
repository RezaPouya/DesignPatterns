using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public interface IPaymentSystem
    {
        string message { get; set; } 
        void ProcessPayment(string paymentSystem);
    }
}
