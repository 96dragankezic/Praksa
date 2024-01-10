using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bazen, pumpa, isticanje, vremeUSec;

            Console.Write("Zapremina bazena u L: ");
            bazen = int.Parse(Console.ReadLine());
            
            Console.Write("Pumpa L/min: ");
            pumpa = int.Parse(Console.ReadLine());
            
            Console.Write("Isticanje L/min: ");
            isticanje = int.Parse(Console.ReadLine());

            // DM: Program radi ispravno ako zanemarimo mogućnost negativne vrednosti za bazen, pumpa i isticanje.
            // Ja, lično, bih specijalno obradio slučaj "pumpa==isticanje" jer je to deljenje sa 0, ali C# ne pravi exception već vremeUSec dobija specijalnu vrednost (double.PositiveInfinity)
            vremeUSec = bazen / ((pumpa - isticanje)/60);
            
            if (pumpa > isticanje)
                Console.WriteLine($"Bazen(L): {bazen} \nPumpa(L/min): {pumpa} \nIsticanje(L/min): {isticanje} \nBazen ce se napuniti za {(int)vremeUSec/60} minuta i {(int)vremeUSec%60} sekundi");
            else
                Console.WriteLine("Bazen se nece napuniti jer je brzina isticanja veca od brzine pumpanja!");

            Console.ReadKey();
        }
    }
}
