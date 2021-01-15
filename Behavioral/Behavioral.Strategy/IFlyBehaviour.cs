using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy
{
    public interface IFlyBehaviour
    {
        string Fly();
    }

    public class NoFly : IFlyBehaviour
    {
        public string Fly()
        {
            return "The duck can't fly";
        }
    }


    public class FlyWithWing : IFlyBehaviour
    {
        public string Fly()
        {
            return "The duck is Flying";
        }
    }
}
