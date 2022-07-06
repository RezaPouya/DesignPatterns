using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public class OnlinePayment : Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Online");
        }
    }
}
