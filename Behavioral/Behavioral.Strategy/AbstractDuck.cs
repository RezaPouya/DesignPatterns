using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy
{
    public abstract class AbstractDuck
    {
        protected AbstractDuck(string type, IFlyBehaviour flyBehaviour, IQuakBehaviour quakBehaviour)
        {
            Type = type;
            FlyBehaviour = flyBehaviour;
            QuakBehaviour = quakBehaviour;
        }

        public string Type { get; set; }
        internal IFlyBehaviour FlyBehaviour { get; set; }
        internal IQuakBehaviour QuakBehaviour { get; set; }

        public string Quak()
        {
            return this.QuakBehaviour.Quack();
        }

        public string Fly()
        {
            return this.FlyBehaviour.Fly();
        }

        public string Swim()
        {
            return "Its can swim";
        }

        public string Display()
        {
            return $"This  is {Type} Duck!";
        }
    }
}
