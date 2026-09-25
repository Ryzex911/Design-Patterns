using System;

namespace GameApp
{
    internal class GameFacade
    {
        private GraphicsSystem graphics;
        private AudioSystem audio;
        private SaveSystem saveSystem;
        private NetworkService network;
        private GameEngine gameEngine;

        private bool isOnline;

        public GameFacade()
        {
            graphics = new GraphicsSystem();
            audio = new AudioSystem();
            saveSystem = new SaveSystem();
            network = new NetworkService();
            gameEngine = new GameEngine();
        }

        public void StartNormalMode(bool online)
        {
            isOnline = online;

            Console.WriteLine("Starting Normal Mode...");
            Console.WriteLine("-----------------------------------------");

            graphics.Initialize();
            graphics.SetResolution(1920, 1080);
            Console.WriteLine("-----------------------------------------");

            audio.Initialize();
            audio.SetVolume(70);
            Console.WriteLine("-----------------------------------------");

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();
            Console.WriteLine("-----------------------------------------");

            if (isOnline)
            {
                network.Connect();
                network.Login();
            }
            else
            {
                Console.WriteLine("Offline mode: Skipping network connection.");
            }

            Console.WriteLine("-----------------------------------------");

            gameEngine.LoadWorld();
            gameEngine.Start();

            Console.WriteLine("-----------------------------------------");
        }

        public void StartDeveloperMode(bool online)
        {
            isOnline = online;

            Console.WriteLine("Starting Developer Mode...");
            Console.WriteLine("-----------------------------------------");

            graphics.Initialize();
            graphics.SetResolution(1980, 1020);
            Console.WriteLine("-----------------------------------------");

            audio.Initialize();
            audio.SetVolume(82);
            Console.WriteLine("-----------------------------------------");

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();
            Console.WriteLine("-----------------------------------------");

            if (isOnline)
            {
                network.Connect();
                network.Login();
            }
            else
            {
                Console.WriteLine("Offline mode: Skipping network connection.");
            }

            Console.WriteLine("-----------------------------------------");

            gameEngine.LoadWorld();
            gameEngine.Start();

            Console.WriteLine("-----------------------------------------");
        }

        public void StopGame()
        {
            Console.WriteLine("Stopping Game...");
            Console.WriteLine("-----------------------------------------");

            saveSystem.Shutdown();
            Console.WriteLine("-----------------------------------------");

            graphics.Shutdown();
            Console.WriteLine("-----------------------------------------");

            audio.Shutdown();
            Console.WriteLine("-----------------------------------------");

            if (isOnline)
            {
                network.Disconnect();
                Console.WriteLine("-----------------------------------------");
            }

            gameEngine.Shutdown();
            Console.WriteLine("-----------------------------------------");
        }
    }
}