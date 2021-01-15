using Behavioral.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Aggregates
{
    public class NewYorkNewspaper : INewsPaper
    {
        private List<string> _reporters;

        public NewYorkNewspaper()
        {
            _reporters = new List<string>()
            {
                "Sam Doe - New York Newspaper" ,
                "Alen Smith - New York Newspaper" ,
                "Max Rivers - New York Newspaper" ,
            };
        }

        public IIterator CreateIterator()
        {
            return new NewYorkNewspaperIterator(_reporters);
        }
    }
}
