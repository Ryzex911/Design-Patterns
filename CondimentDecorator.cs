namespace FactoryPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected readonly Beverage beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
