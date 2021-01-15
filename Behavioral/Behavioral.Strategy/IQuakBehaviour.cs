using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy
{
    public interface IQuakBehaviour
    {
        string Quack();
    }

    public class FastQuak : IQuakBehaviour
    {
        public string Quack()
        {
            return "Qauk!Quak!Quak";
        }
    }


    public class LoadQuak : IQuakBehaviour
    {
        public string Quack()
        {
            return "Qaaaauk!....Quaaaak!....Quaaaak!";
        }
    }
}
