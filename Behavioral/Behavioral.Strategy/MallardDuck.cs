namespace Behavioral.Strategy
{
    public class MallardDuck : AbstractDuck
    {
        public MallardDuck() : base(nameof(MallardDuck), new FlyWithWing(), new FastQuak())
        {
        }
    }
}