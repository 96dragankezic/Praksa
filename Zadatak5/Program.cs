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

            vremeUSec = bazen / ((pumpa - isticanje)/60);
            

            if (pumpa > isticanje)
                Console.WriteLine($"Bazen(L): {bazen} \nPumpa(L/min): {pumpa} \nIsticanje(L/min): {isticanje} \nBazen ce se napuniti za {(int)vremeUSec/60} minuta i {(int)vremeUSec%60} sekundi");
            else
                Console.WriteLine("Bazen se nece napuniti jer je brzina isticanja veca od brzine pumpanja!");

            Console.ReadKey();
        }
    }
}
