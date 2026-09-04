using System;
using StrategyPattern.Interfaces.QuackBehavior;


namespace StrategyPattern.Interfaces.QuackBehavior  
{


    internal class RegularQuack : QuackBehavior
    {
        public RegularQuack()
        {

        }

        public void Quack()
        {
            Console.WriteLine("quack");
        }

    }
}