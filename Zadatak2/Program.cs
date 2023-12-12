using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        public static bool straniceCineTrougao(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b,c));
            bool cineTrougao = false;

            if (max == c && a + b > c)
                cineTrougao = true;
            else if(max == b && a + c > b)
                cineTrougao = true;
            else if(max == a && b + c > a)
                cineTrougao = true;

            return cineTrougao;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            while (true)
            {
                Console.WriteLine("Uneti duzine stranca trougla...");

                while(true)
                {
                    Console.Write("Stranica a: ");
                    if(int.TryParse(Console.ReadLine(), out a) ) 
                    {
                        if(a > 0)
                            break;
                    }
                }
                while (true)
                {
                    Console.Write("Stranica b: ");
                    if (int.TryParse(Console.ReadLine(), out b))
                    {
                        if (b > 0)
                            break;
                    }
                } 
                while (true)
                {
                    Console.Write("Stranica c: ");
                    if (int.TryParse(Console.ReadLine(), out c))
                    {
                        if (c > 0)
                            break;
                    }
                }
                if (straniceCineTrougao(a, b, c))
                    Console.WriteLine("Stranice cine trougao!");
                else
                    Console.WriteLine("Stranice ne cine trougao!");

            }

        }
    }
}
