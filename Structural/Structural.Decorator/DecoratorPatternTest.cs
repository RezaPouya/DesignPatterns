using Structural.Decorator.CoffeeExample.ConcreteComponents;
using Structural.Decorator.CoffeeExample.ConcreteDecorators;
using Structural.Decorator.ConcreteComponents;
using Structural.Decorator.ConcreteDecorators;
using Xunit;

namespace Structural.Decorator.Test
{
    public class DecoratorPatternTest
    {
        [Fact]
        public void Should_Pass_If_Can_Calculate_Compact_Car_Price_Correctly()
        {
            // arrange
            CompactCar car = new CompactCar();

            // act
            var price = car.GetPrice();

            // assert
            Assert.Equal(100_000_000, price);
        }

        [Fact]
        public void Should_Pass_If_Can_Calculate_Compact_Car_Price_With_Navigation_Correctly()
        {
            // arrange
            CompactCar car = new CompactCar();
            Navigation navigation = new Navigation(car);

            // act
            var price = navigation.GetPrice();

            // assert
            Assert.Equal(100_500_000, price);
        }

        [Fact]
        public void Should_Pass_If_Can_Calculate_Compact_Car_Price_With_Navigation_And_SunRoof_Correctly()
        {
            // arrange
            CompactCar car = new CompactCar();
            Navigation navigation = new Navigation(car);
            SunRoof sunRoof = new SunRoof(navigation);

            // act
            var price = sunRoof.GetPrice();

            // assert
            Assert.Equal(103_300_000, price);
        }

        [Fact]
        public void Should_Pass_If_Can_Calculate_EspressoCoffe_Price_Correctly()
        {
            // arrange
            EspressoCoffee coffee = new EspressoCoffee();

            // act
            var price = coffee.Cost();

            // assert
            Assert.Equal(1.30M, price);
        }

        [Fact]
        public void Should_Pass_If_Can_Calculate_EspressoCoffe_With_Mik_Price_Correctly()
        {
            // arrange
            EspressoCoffee coffee = new EspressoCoffee();
            
            MikeCoffee milkCoffee = new MikeCoffee(coffee);

            // act
            var price = milkCoffee.Cost();

            // assert
            Assert.Equal(1.40M, price);
        }
    }
}