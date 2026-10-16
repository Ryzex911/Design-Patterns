namespace FactoryPattern
{
    // Creator uit het Factory Method Pattern.
    public abstract class DrinkFactory
    {
        public Beverage OrderDrink(DrinkType type)
        {
            Beverage drink = CreateDrink(type);

            Console.WriteLine($"Bestelling gemaakt: {type}");

            return drink;
        }

        // Factory Method:
        // subclasses bepalen welk Beverage-object wordt gemaakt.
        protected abstract Beverage CreateDrink(DrinkType type);
    }
}
