using Behavioral.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Iterator.Aggregates
{
    public class LosAnglesNewspaper : INewsPaper
    {
        private string[] _reporters;

        public LosAnglesNewspaper()
        {
            _reporters = new[]
            {
                "Jhone Doe - Los Angles" ,
                "Sam Smith - Los Angles" ,
                "Alen Rivers - Los Angles" ,
                "Max Payne - Los Angles"
            };
        }

        public IIterator CreateIterator()
        {
            return new LosAnglesNewspaperIterator(_reporters);
        }
    }
}
