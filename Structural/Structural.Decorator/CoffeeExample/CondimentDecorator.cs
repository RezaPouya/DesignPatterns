namespace Structural.Decorator.CoffeeExample
{
    public abstract class CondimentDecorator : Coffee
    {
        protected Coffee _coffee;

        public CondimentDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override string GetDescription() => _coffee.GetDescription();

        public override decimal Cost() => _coffee.Cost();
    }
}