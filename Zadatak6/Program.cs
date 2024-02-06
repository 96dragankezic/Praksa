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
            int nadjenPuta = 0;

            while(true) 
            {          
                for(int i = 0; i < rec.Length; i++) 
                {
                    Console.Write("Unesite slovo: ");
                    if (rec[i] == Console.ReadKey().KeyChar)
                    {
                        //ako je nadjena rec "bar"
                        if (i == 2)
                        {
                            nadjenPuta++;
                            if (nadjenPuta == 1)
                            {
                                i = -1;
                            }
                            else if (nadjenPuta == 2) 
                            {
                                Console.Write("\nUnesite slovo: ");
                                char slovo = Console.ReadKey().KeyChar;
                                if ('a' == slovo)
                                {
                                    Console.WriteLine("\nUneli ste rec barbara!");
                                    nadjenPuta = 0;
                                    i = -1;
                                }
                                if('b' == slovo)
                                {
                                    nadjenPuta = 1;
                                    i = 0; 
                                }
                                else
                                {
                                    nadjenPuta = 0;
                                    i = -1;
                                }
                            }  
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        i = -1;
                    }        
                }
            }
        }
    }
}
