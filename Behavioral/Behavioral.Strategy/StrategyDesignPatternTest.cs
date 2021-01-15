using System;
using Xunit;

namespace Behavioral.Strategy
{
    public class StrategyDesignPatternTest
    {
        [Fact]
        public void Should_Pass_If_Rubber_Duck_Cant_Fly()
        {
            // arrange
            var rubberDuck = new RubberDuck();

            // act 
            var flyState = rubberDuck.Fly();

            // assert 
            Assert.IsType<NoFly>(rubberDuck.FlyBehaviour);
            Assert.Equal("The duck can't fly", flyState);
        }
    }
}
