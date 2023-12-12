using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        public static int izracunajFaktorijel(int brojFakt)
        {
            int rez = 1;

            while(brojFakt > 0)
            {
                rez *= brojFakt--;
            }
            
            return rez;
        }
        public static int izracunajFaktorijelRekurzivno(int brojFakt)
        {
            int rez = brojFakt;

            if (brojFakt == 1)
                return 1;
            rez *= izracunajFaktorijelRekurzivno(brojFakt - 1); 
            
            return rez;
        }
        public static void Main(string[] args)
        {
            int brojFakt = 0;
            
            while(true)
            {
                Console.Write("Unesite broj za izracunavanje faktorijela: ");
                if (int.TryParse(Console.ReadLine(), out brojFakt))
                {
                    if (brojFakt > 0)
                    {
                        Console.WriteLine("Faktorijel unetog broja " + brojFakt + " normalno je: " + izracunajFaktorijel(brojFakt));
                        Console.WriteLine("Faktorijel unetog broja " + brojFakt + " rekurzijom je: " + izracunajFaktorijelRekurzivno(brojFakt) + "\n");
                    }
                }
            }
        }
    }
}
