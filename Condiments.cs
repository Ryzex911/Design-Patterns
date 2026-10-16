namespace FactoryPattern
{
    public class ExtraEspresso : CondimentDecorator
    {
        public ExtraEspresso(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Espresso";
        }
    }

    public class Water : CondimentDecorator
    {
        public Water(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Water";
        }
    }

    public class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk Foam";
        }
    }

    public class Liquor : CondimentDecorator
    {
        public Liquor(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Liquor";
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }

    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }
    }

    public class Lemon : CondimentDecorator
    {
        public Lemon(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Lemon";
        }
    }

    public class ChocolateCondiment : CondimentDecorator
    {
        public ChocolateCondiment(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Chocolate";
        }
    }

    public class BlackChocolate : CondimentDecorator
    {
        public BlackChocolate(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Black Chocolate";
        }
    }

    public class WhiteChocolate : CondimentDecorator
    {
        public WhiteChocolate(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", White Chocolate";
        }
    }

    public class HalfMilk : CondimentDecorator
    {
        public HalfMilk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Half Milk";
        }
    }

    public class VanillaSugar : CondimentDecorator
    {
        public VanillaSugar(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Vanilla Sugar";
        }
    }

    public class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Cream";
        }
    }

    public class Honey : CondimentDecorator
    {
        public Honey(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Honey";
        }
    }

    public class IceCream : CondimentDecorator
    {
        public IceCream(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Ice cream";
        }
    }

    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }

    public class Ice : CondimentDecorator
    {
        public Ice(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Ice";
        }
    }

    public class Syrup : CondimentDecorator
    {
        public Syrup(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Syrup";
        }
    }

    public class Whiskey : CondimentDecorator
    {
        public Whiskey(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whiskey";
        }
    }
}
