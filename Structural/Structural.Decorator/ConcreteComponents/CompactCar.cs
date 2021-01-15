using Structural.Decorator.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.ConcreteComponents
{
    public class CompactCar : Car
    {
        
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override string GetDescription() => this.Description;

        public override long GetPrice() => 100_000_000;
    }
}
