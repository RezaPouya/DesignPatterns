using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.CoffeeExample.ConcreteComponents
{
    public class EspressoCoffee : Coffee
    {
        public EspressoCoffee()
        {
            Description = "Espresso Coffee";
        }

        public override double Cost() => 1.30;

        public override string GetDescription() => this.Description;
        
    }
}
