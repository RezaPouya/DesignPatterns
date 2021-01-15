namespace Behavioral.Strategy
{
    public class RubberDuck : AbstractDuck
    {
        public RubberDuck() : base(nameof(RubberDuck), new NoFly(), new FastQuak())
        {
        }
    }
}