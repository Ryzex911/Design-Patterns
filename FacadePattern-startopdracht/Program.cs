namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GameFacade gameface = new GameFacade();
            gameface.StartNormalMode(true);
            gameface.StopGame();
            gameface.StartDeveloperMode(false);
            gameface.StopGame();
            Console.ReadLine();

        }
    }
}