namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Lichten aan.");
        }

        public void Off()
        {
            Console.WriteLine("Lichten uit.");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Lichten gedimd naar {value}%.");
        }
    }
}