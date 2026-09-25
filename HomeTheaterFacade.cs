namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier amp;
        private Tuner tuner;
        private DvdPlayer dvdPlayer;
        private CdPlayer cdPlayer;
        private Projector projector;
        private TheaterLights lights;
        private Screen screen;
        private PopcornPopper popcornPopper;

        public HomeTheaterFacade(
            Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popcornPopper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Film wordt gestart...");
            Console.WriteLine("----------------------------------");

            popcornPopper.On();
            popcornPopper.Pop();

            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movie);

            Console.WriteLine("----------------------------------");
        }

        public void EndMovie()
        {
            Console.WriteLine("Film wordt gestopt...");
            Console.WriteLine("----------------------------------");

            popcornPopper.Off();

            lights.On();

            screen.Up();

            projector.Off();

            amp.Off();

            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();

            Console.WriteLine("----------------------------------");
        }
    }
}