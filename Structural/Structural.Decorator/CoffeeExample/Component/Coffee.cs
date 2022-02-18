using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator.CoffeeExample
{
    public abstract class Coffee
    {
        protected string Description;

        public abstract string GetDescription();

        public abstract decimal Cost();
    }


    public abstract class CodimentDecorator : Coffee
    {

    }
}
