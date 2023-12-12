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
            int odnos = 0;
            int brojBrojeva = 0;

            Console.Write("Unesite broj brojeva koji se unosi: ");
            brojBrojeva = int.Parse(Console.ReadLine());
            while (0 < brojBrojeva--) 
            {
                Console.Write("Unesite broj: ");
                if (int.Parse(Console.ReadLine()) % 3 == 0)
                   odnos += 1;
                else
                   odnos -= 1;              
            }
            if (odnos > 0)
                Console.WriteLine("Vise je celobrojnih brojeva koji su deljivi sa tri.");
            else if (odnos < 0)
                Console.WriteLine("Vise je celobrojnih brojeva deljivih sa dva.");
            else
                Console.WriteLine("Broj celobrojnih brojeva deljivih sa tri jednak je broju celobrojnih brojeva deljivih sa dva.");
            Console.ReadKey();
        }
    }
}
