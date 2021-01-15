using Structural.Decorator.Components;

namespace Structural.Decorator.Decorators
{
    public class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override string GetDescription()
            => _car.GetDescription();

        public override long GetPrice() => _car.GetPrice();
    }
}