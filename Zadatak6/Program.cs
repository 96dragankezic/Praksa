using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    internal class Program
    {
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
