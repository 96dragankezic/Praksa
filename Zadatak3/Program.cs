using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int odnos = 0; //jedna prosta promenljiva
            int brojBrojeva = 0;
            double broj;
            Console.Write("Unesite broj brojeva koji se unosi: ");
            brojBrojeva = int.Parse(Console.ReadLine());
            while (0 < brojBrojeva--) 
            {
                Console.Write("Unesite broj: ");
                broj = double.Parse(Console.ReadLine());
                if (broj % 3 == 0 && broj % 2 == 0)
                   odnos += 0;
                else if (broj % 3 == 0)
                   odnos += 1;
                else if(broj % 2 == 0)
                    odnos -= 1;
            }
            if (odnos > 0)
                Console.WriteLine("Vise je celobrojnih brojeva koji su deljivi sa tri za " + Math.Abs(odnos));
            else if (odnos < 0)
                Console.WriteLine("Vise je celobrojnih brojeva deljivih sa dva za " + Math.Abs(odnos));
            else
                Console.WriteLine("Broj celobrojnih brojeva deljivih sa tri jednak je broju celobrojnih brojeva deljivih sa dva.");
            Console.ReadKey();
        }
    }
}
