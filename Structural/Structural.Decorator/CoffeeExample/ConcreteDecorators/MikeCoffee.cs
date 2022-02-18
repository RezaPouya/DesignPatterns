using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.CoffeeExample.ConcreteDecorators
{
    class MikeCoffee : CondimentDecorator
    {
        //protected Coffee _coffee;

        public MikeCoffee(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription() => $"{_coffee.GetDescription()} Milk";

        public override decimal Cost() => _coffee.Cost() + 0.1M;
    }
}

