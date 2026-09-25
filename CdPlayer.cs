namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;

        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CD Player aan.");
        }

        public void Off()
        {
            Console.WriteLine("CD Player uit.");
        }

        public void Eject()
        {
            Console.WriteLine("CD uitgeworpen.");
        }

        public void Pause()
        {
            Console.WriteLine("CD gepauzeerd.");
        }

        public void Play()
        {
            Console.WriteLine("CD wordt afgespeeld.");
        }

        public void Stop()
        {
            Console.WriteLine("CD gestopt.");
        }
    }
}