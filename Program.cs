namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkFactory factory = new StarbuzzDrinkFactory();

            Console.WriteLine("=== FACTORY PATTERN - STARBUZZ ===");
            Console.WriteLine();

            foreach (DrinkType type in Enum.GetValues<DrinkType>())
            {
                Beverage drink = factory.OrderDrink(type);
                Console.WriteLine($"{type,-22} -> {drink.GetDescription()}");
            }

            Console.WriteLine();
            Console.WriteLine("Alleen dranken uit DrinkType kunnen via de factory besteld worden.");
            Console.ReadLine();
        }
    }
}
