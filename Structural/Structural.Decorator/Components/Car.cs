using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.Components
{
    public abstract class Car
    {
        protected  string Description { get; set; }

        public abstract string GetDescription();

        public abstract long GetPrice();
    }
}
