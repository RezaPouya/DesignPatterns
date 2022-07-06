using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public abstract class Payment
    {
        public IPaymentSystem PaymentSystem; 
        public abstract void MakePayment();
    }
}
