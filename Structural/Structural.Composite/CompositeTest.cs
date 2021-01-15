using Structural.Composite.Composite;
using System;
using Xunit;

namespace Structural.Composite
{
    public class CompositeTest
    {
        [Fact]
        public void Test1()
        {
            Manager manager = new Manager("Mohammad", "Muhammadi", "Banu Hashem");
            manager.GetDetails();
            var detail = manager.Detail;
        }
    }
}
