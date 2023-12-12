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
            double bazen, pumpa, isticanje;

            Console.Write("X: ");
            bazen = int.Parse(Console.ReadLine());
            
            Console.Write("Y: ");
            pumpa = int.Parse(Console.ReadLine());
            
            Console.Write("Z: ");
            isticanje = int.Parse(Console.ReadLine());

            if (pumpa > isticanje)
                Console.WriteLine($"Bazen(L): {bazen} \nPumpa(L/min): {pumpa} \nIsticanje(L/min): {isticanje} \nBazen ce se napuniti za {bazen/(pumpa - isticanje)} minuta");
            else
                Console.WriteLine("Bazen se nece napuniti jer je brzina isticanja veca od brzine pumpanja!");

            Console.ReadKey();
        }
    }
}
