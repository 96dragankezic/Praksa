using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi apoene: ");
            string[] apoeni = Console.ReadLine().Split(',');
            int[] apoeniInt = new int[apoeni.Length];
            Console.WriteLine("Unesi iznos za isplatu: ");
            int iznosIsplata = int.Parse(Console.ReadLine());

            for(int i = 0; i < apoeni.Length; i++)
            {
                apoeniInt[i] = int.Parse(apoeni[i].Trim(' '));
            }
            Array.Sort(apoeniInt);
            Array.Reverse(apoeniInt);

            for(int i = 0; i < apoeni.Length; i++)
            {
                if (iznosIsplata > apoeniInt[i])
                {
                    Console.WriteLine("Apoen " + apoeniInt[i] + ": " + iznosIsplata / apoeniInt[i]);
                    iznosIsplata -= iznosIsplata / apoeniInt[i] * apoeniInt[i];
                }
            }
            Console.WriteLine("Dodjem vam jos " + iznosIsplata + " :)");
            

            Console.ReadKey();
        }
    }
}
