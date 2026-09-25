namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner? _tuner;
        private DvdPlayer? _dvdPlayer;
        private CdPlayer? _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier aan.");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier uit.");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            _cdPlayer = cdPlayer;
            Console.WriteLine("CD Player ingesteld op amplifier.");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine("DVD Player ingesteld op amplifier.");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Stereo geluid ingesteld.");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound ingesteld.");
        }

        public void SetTuner(Tuner tuner)
        {
            _tuner = tuner;
            Console.WriteLine("Tuner ingesteld.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume ingesteld op {volume}.");
        }
    }
}