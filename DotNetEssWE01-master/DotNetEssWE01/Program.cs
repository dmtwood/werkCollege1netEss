using System;
using System.Runtime.InteropServices;
using WE01.Logica;

namespace DotNetEssWE01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dimi was here ===== Oef 1: Wissel =====");

            int a = 10, b = 20;
            Console.WriteLine("Waarden voor wissel:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Helper.Wissel(ref a, ref b);

            Console.WriteLine("Na wissel:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();

            Console.WriteLine("===== Oef 2: camelCase =====");
            Console.WriteLine("Voer een zin in:");
            string invoer = Console.ReadLine();

            // blijven invoer vragen indien invoer leeg was
            while (string.IsNullOrWhiteSpace(invoer))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige invoer!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("Voer een zin in:");
                invoer = Console.ReadLine();
            }

            Console.WriteLine(Helper.ZinNaarCamelCase(invoer));
            Console.WriteLine();

            Console.WriteLine("===== Oef 3: Kalender =====");

            Maand currentMonth = new Maand();
            currentMonth.Maandnr = 11;
            currentMonth.Jaar = 2002;
            Console.WriteLine(currentMonth);
            Console.ReadLine();
        }

    }
}
