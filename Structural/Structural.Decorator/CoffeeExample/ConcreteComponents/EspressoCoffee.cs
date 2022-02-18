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

        public override decimal Cost() => 1.30M;

        public override string GetDescription() => this.Description;
        
    }
}
