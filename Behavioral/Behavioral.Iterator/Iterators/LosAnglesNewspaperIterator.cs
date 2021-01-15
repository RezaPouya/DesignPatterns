using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Iterators
{
    public class LosAnglesNewspaperIterator : IIterator
    {
        private string[] _rporters;
        private int _current;

        public LosAnglesNewspaperIterator(string[] rporters)
        {
            _rporters = rporters;
            _current = 0;
        }

        public string currentItem()
        {
            return _rporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _rporters.Length;
        }

        public string Next()
        {
            return _rporters[_current++];
        }
    }
}
