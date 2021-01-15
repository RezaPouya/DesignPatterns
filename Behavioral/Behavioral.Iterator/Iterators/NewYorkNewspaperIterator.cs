using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behavioral.Iterator.Iterators
{
    public class NewYorkNewspaperIterator : IIterator
    {
        private List<string> _rporters;
        private int _current;

        public NewYorkNewspaperIterator(List<string> rporters)
        {
            _rporters = rporters;
            _current = 0;
        }


        public string currentItem()
        {
            return _rporters.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _rporters.Count;
        }

        public string Next()
        {
            return _rporters.ElementAt(_current++);
        }
    }
}
