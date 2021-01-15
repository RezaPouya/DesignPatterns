using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Iterators
{
    public interface IIterator
    {
        void First();         // set current element to the first element
        string Next();        // advances current to next element
        bool IsDone();        // check if end of collection 
        string currentItem(); // returns the current element
    }
}
