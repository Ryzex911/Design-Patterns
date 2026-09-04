using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck RobotDuck = new RobotDuck();


            Console.WriteLine("Mallard Duck");
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();
            Console.WriteLine();

            Console.WriteLine("Redhead Duck");
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();

            Console.WriteLine();

            Console.WriteLine("Decoy Duck");
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.PerformSwim();

            Console.WriteLine();

            Console.WriteLine("Rubber Duck");
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();

            Console.WriteLine();



            Console.WriteLine("Robot Duck");
            RobotDuck.PerformSwim();


        }
    }
}