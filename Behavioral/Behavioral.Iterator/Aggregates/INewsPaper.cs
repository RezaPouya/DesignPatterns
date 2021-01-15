using Behavioral.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Aggregates
{
    public interface INewsPaper
    {
        IIterator CreateIterator();
    }
}
