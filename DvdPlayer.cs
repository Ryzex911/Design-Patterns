namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD Player aan.");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player uit.");
        }

        public void Eject()
        {
            Console.WriteLine("DVD uitgeworpen.");
        }

        public void Pause()
        {
            Console.WriteLine("DVD gepauzeerd.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Film '{movie}' wordt afgespeeld.");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD surround audio ingesteld.");
        }

        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DVD two channel audio ingesteld.");
        }

        public void Stop()
        {
            Console.WriteLine("DVD gestopt.");
        }
    }
}