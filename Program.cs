namespace NoDesignPatternsBetaalmethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BetaalProcessor processor = new BetaalProcessor(new CreditcardBetaalMethode("12345678912345677"));

            processor.VerwerkBetaling(
                100.00m,
                );

        }
    }
}
