﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    public class PcPosPayment : Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("PcPos");
        }
    }
}
