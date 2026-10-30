using System;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Singleton Pattern ===");
            Console.WriteLine();

            // Twee keer GetInstance aanroepen
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            // Controleren of het echt hetzelfde object is
            Console.WriteLine(
                "boiler1 en boiler2 zijn dezelfde instance: "
                + ReferenceEquals(boiler1, boiler2)
            );

            Console.WriteLine();
            Console.WriteLine("=== ChocolateBoiler testen ===");

            boiler1.fill();

            Console.WriteLine(
                $"Empty: {boiler1.IsEmpty}, Boiled: {boiler1.IsBoiled}"
            );

            boiler1.boil();

            Console.WriteLine(
                $"Empty: {boiler1.IsEmpty}, Boiled: {boiler1.IsBoiled}"
            );

            boiler1.drain();

            Console.WriteLine(
                $"Empty: {boiler1.IsEmpty}, Boiled: {boiler1.IsBoiled}"
            );

            Console.WriteLine();
            Console.WriteLine("=== Thread safe test ===");

            ChocolateBoiler?[] boilers = new ChocolateBoiler?[100];

            Parallel.For(0, 100, i =>
            {
                boilers[i] = ChocolateBoiler.GetInstance();
            });

            bool allSame = boilers.All(
                boiler => ReferenceEquals(boiler1, boiler)
            );

            Console.WriteLine(
                "Alle threads kregen dezelfde instance: " + allSame
            );

            Console.WriteLine();
            Console.WriteLine("Druk op Enter om af te sluiten.");

            Console.ReadLine();
        }
    }
}