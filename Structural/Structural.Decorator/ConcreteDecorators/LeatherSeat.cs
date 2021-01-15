using Structural.Decorator.Components;
using Structural.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.ConcreteDecorators
{
    public class LeatherSeat : CarDecorator
    {
        public LeatherSeat(Car car) :  base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} , {this.Description}";
        }

        public override long GetPrice() => base.GetPrice() + 3_500_000;
    }
}
