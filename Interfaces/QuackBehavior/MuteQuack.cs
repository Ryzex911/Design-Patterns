using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class MuteQuack : QuackBehavior
    {

        public MuteQuack()
        {

        }

        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }

    }
}
