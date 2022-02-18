namespace Structural.Decorator.CoffeeExample
{
    public class HouseBlendCoffee : Coffee
    {
        public HouseBlendCoffee()
        {
            Description = "House Blend Coffee";
        }

        public override decimal Cost() => 0.89M;

        public override string GetDescription() => this.Description;
    }
}