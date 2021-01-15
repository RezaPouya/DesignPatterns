namespace Structural.Decorator.CoffeeExample
{
    public class HouseBlendCoffee : Coffee
    {
        public HouseBlendCoffee()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost() => 0.89;

        public override string GetDescription() => this.Description;
    }
}