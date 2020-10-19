using System;
using WerkCollege1DG.WC1.Logica;

namespace WerkCollege1DG
{
    class Program
    {
        static void Main(string[] args)
        {

            // lees twee integers in en wissel ze van plaats
            Console.WriteLine(" ==== Helper.Wissel functie wisselt 2 waarden ");
            int a = 0;
            int b = 0;
            Console.WriteLine("Geef een eerste waarde in");
            string aS = Console.ReadLine();
            a = int.Parse(aS);
            Console.WriteLine("Geef een tweede waarde in");
            string bS = Console.ReadLine();
            b = int.Parse(bS);

            Console.WriteLine("Waarden voor de wissel");
            Console.WriteLine($"Eerste waarde = {a}.");
            Console.WriteLine($"Tweede waarde = {b}.");

            Helper.Wissel(ref a, ref b);

            Console.WriteLine("Waarden na de wissel");
            Console.WriteLine($"Eerste waarde = {a}.");
            Console.WriteLine($"Tweede waarde = {b}.");




        }
    }
}
