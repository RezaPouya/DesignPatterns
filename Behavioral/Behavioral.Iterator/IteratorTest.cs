using Behavioral.Iterator.Aggregates;
using Behavioral.Iterator.Iterators;
using System;
using System.Text;
using Xunit;

namespace Behavioral.Iterator
{
    public class IteratorTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange 
            NewYorkNewspaper nyNewspaper = new NewYorkNewspaper();
            IIterator newYorkNewspaperIterator = nyNewspaper.CreateIterator();

            // Act 
            var msg = PrintIterator(newYorkNewspaperIterator);

            // Assert 
            Assert.Contains("New York", msg);
        }


        private string PrintIterator(IIterator iterator)
        {
            var report = new StringBuilder();
           
            while(iterator.IsDone() != true)
            {
                report.AppendLine(iterator.Next());
            }

            return report.ToString();
        }
    }
}
