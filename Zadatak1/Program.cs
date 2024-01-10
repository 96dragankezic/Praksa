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
        // DM: Šta će ova funkcija da vrati ako joj se prosledi 0?   Po konvenciji: 0! = 1
        // a radi sigurnosti izvršavanja funkcije dobro je obraditi i slučaj negativnog broja,
        // pošto nema definicije za taj slučaj onda može na isti način kao i slučaj 0, npr: -3! = 1 .
        // Nema veze što je u Main funkciji osigurano da se funkciji neće proslediti negativan broj ili 0,
        // "sutra" ćeš tu funkciju da upotrebiš (prekopiraš) na drugom mestu i eto problema
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
