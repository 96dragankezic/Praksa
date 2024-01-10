using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    internal class Program
    {
        // DM: Način unosa podataka je vrlo čudan (slovo pa Enter, slovo pa Enter...), smatram da treba da se koristi Console.ReadKey() umesto toga.
        // Zadatak možda nije bio dovoljno precizan. Nije uslov/poenta da se isključivo unese reč "barbara" nego da korisnik unosi slova po želji,
        // dakle korisnik može početi sa "a gde je " pa tek onda onda unese "barbara".
        // Da odmah kažem i slučaj koji će gotovo sigurno da promakne u razmišljanju: "a gde je barbarbara"
        static void Main(string[] args)
        {
            char[] rec = { 'b', 'a', 'r', 'b', 'a', 'r', 'a' };

            while(true) 
            {          
                for(int i = 0; i < rec.Length; i++) 
                {
                    Console.Write("Unesite slovo: ");
                    if (rec[i] == char.Parse(Console.ReadLine()))
                    {
                        if (rec.Length - 1 == i)
                        {
                            Console.WriteLine("Uneli ste rec barbara!");
                        }
                    }
                    else
                    {
                        break;
                    }        
                }
            }

            Console.ReadKey();
        }
    }
}
