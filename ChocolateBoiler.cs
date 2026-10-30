using System;

namespace Singleton
{
    internal sealed class ChocolateBoiler
    {
        private static volatile ChocolateBoiler? instance;
        private static readonly object lockObject = new object();

        private bool empty;
        private bool boiled;

        public bool IsEmpty
        {
            get { return empty; }
        }

        public bool IsBoiled
        {
            get { return boiled; }
        }

        // Private constructor:
        // hierdoor kan buiten deze class geen ChocolateBoiler worden gemaakt.
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        // Singleton + thread safe met Double Checked Locking
        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                }
            }

            return instance;
        }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;

                Console.WriteLine("Boiler is gevuld.");
            }
        }

        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;

                Console.WriteLine("Boiler is geleegd.");
            }
        }

        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;

                Console.WriteLine("Chocolade is gekookt.");
            }
        }
    }
}