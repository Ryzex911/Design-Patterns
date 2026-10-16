namespace FactoryPattern
{
    // Concrete Creator.
    public class StarbuzzDrinkFactory : DrinkFactory
    {
        protected override Beverage CreateDrink(DrinkType type)
        {
            Beverage drink;

            switch (type)
            {
                case DrinkType.Espresso:
                    drink = new Espresso();
                    break;

                case DrinkType.Doppio:
                    drink = new ExtraEspresso(new Espresso());
                    break;

                case DrinkType.Lungo:
                    drink = new Water(new Espresso());
                    break;

                case DrinkType.Macchiato:
                    drink = new MilkFoam(new Espresso());
                    break;

                case DrinkType.Corretta:
                    drink = new Liquor(new Espresso());
                    break;

                case DrinkType.ConPanna:
                    drink = new Whip(new Espresso());
                    break;

                case DrinkType.Cappuccino:
                    drink = new MilkFoam(
                                new SteamedMilk(
                                    new Espresso()));
                    break;

                case DrinkType.Americano:
                    drink = new Water(
                                new Water(
                                    new Espresso()));
                    break;

                case DrinkType.CaffeLatte:
                    drink = new MilkFoam(
                                new SteamedMilk(
                                    new SteamedMilk(
                                        new Espresso())));
                    break;

                case DrinkType.FlatWhite:
                    drink = new SteamedMilk(
                                new SteamedMilk(
                                    new Espresso()));
                    break;

                case DrinkType.Romana:
                    drink = new Lemon(new Espresso());
                    break;

                case DrinkType.Morocchino:
                    drink = new MilkFoam(
                                new ChocolateCondiment(
                                    new Espresso()));
                    break;

                case DrinkType.Mocha:
                    drink = new Whip(
                                new SteamedMilk(
                                    new ChocolateCondiment(
                                        new Espresso())));
                    break;

                case DrinkType.Bicerin:
                    drink = new Whip(
                                new WhiteChocolate(
                                    new BlackChocolate(
                                        new Espresso())));
                    break;

                case DrinkType.Breve:
                    drink = new HalfMilk(
                                new MilkFoam(
                                    new Espresso()));
                    break;

                case DrinkType.RafCoffee:
                    drink = new Cream(
                                new VanillaSugar(
                                    new Espresso()));
                    break;

                case DrinkType.MeadRaf:
                    drink = new Cream(
                                new Honey(
                                    new Espresso()));
                    break;

                case DrinkType.Galao:
                    drink = new MilkFoam(
                                new MilkFoam(
                                    new Espresso()));
                    break;

                case DrinkType.CaffeAffogato:
                    drink = new IceCream(
                                new ExtraEspresso(
                                    new Espresso()));
                    break;

                case DrinkType.ViennaCoffee:
                    drink = new Whip(
                                new Whip(
                                    new ExtraEspresso(
                                        new Espresso())));
                    break;

                case DrinkType.Glace:
                    drink = new IceCream(new Espresso());
                    break;

                case DrinkType.ChocolateMilk:
                    drink = new Milk(
                                new Milk(
                                    new Chocolate()));
                    break;

                case DrinkType.DemiCreme:
                    drink = new Cream(
                                new Cream(
                                    new ExtraEspresso(
                                        new Espresso())));
                    break;

                case DrinkType.LatteMacchiato:
                    drink = new MilkFoam(
                                new SteamedMilk(
                                    new SteamedMilk(
                                        new Espresso())));
                    break;

                case DrinkType.Freddo:
                    drink = new Ice(
                                new Liquor(
                                    new Espresso()));
                    break;

                case DrinkType.Frappuccino:
                    drink = new Whip(
                                new SteamedMilk(
                                    new Ice(
                                        new Espresso())));
                    break;

                case DrinkType.CaramelFrappuccino:
                    drink = new Syrup(
                                new Cream(
                                    new SteamedMilk(
                                        new Ice(
                                            new Espresso()))));
                    break;

                case DrinkType.Frappe:
                    drink = new IceCream(
                                new SteamedMilk(
                                    new SteamedMilk(
                                        new Espresso())));
                    break;

                case DrinkType.IrishCoffee:
                    drink = new Whip(
                                new Whiskey(
                                    new ExtraEspresso(
                                        new Espresso())));
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type),
                        type,
                        "Deze drank staat niet op de kaart.");
            }

            return drink;
        }
    }
}
