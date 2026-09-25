namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer? _dvdPlayer;

        public void SetInput(DvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector input ingesteld op DVD Player.");
        }

        public void On()
        {
            Console.WriteLine("Projector aan.");
        }

        public void Off()
        {
            Console.WriteLine("Projector uit.");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector TV mode.");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector widescreen mode.");
        }
    }
}