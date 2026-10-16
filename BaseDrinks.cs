namespace FactoryPattern
{
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }
    }

    public class Chocolate : Beverage
    {
        public override string GetDescription()
        {
            return "Chocolate";
        }
    }
}
