using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public abstract class Payment
    {
        public IPaymentSystem _paymentSystem; 
        public abstract void MakePayment();
    }
}
