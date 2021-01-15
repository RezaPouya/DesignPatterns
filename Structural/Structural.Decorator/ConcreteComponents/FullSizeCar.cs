using Structural.Decorator.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.ConcreteComponents
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }

        public override string GetDescription() => this.Description;

        public override long GetPrice() => 150_000_000;
    }
}
