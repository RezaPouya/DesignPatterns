using Structural.Decorator.Components;
using Structural.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.ConcreteDecorators
{
    public class SunRoof : CarDecorator
    {
        public SunRoof(Car car) :  base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} , {this.Description}";
        }

        public override long GetPrice() => base.GetPrice() + 2_800_000;
    }
}
