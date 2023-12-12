using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        public static void straniceCineTrougao(double a, double b, double c)
        {
            Math.Max(a, b, c);
        }
        static void Main(string[] args)
        {
            double a, b, c;
            while (true)
            {
                Console.WriteLine("Uneti duzine stranca trougla...");

                while(true)
                {
                    Console.Write("Stranica a: ");
                    if(double.TryParse(Console.ReadLine(), out a) ) 
                    {
                        if(a > 0)
                            break;
                    }
                }
                while (true)
                {
                    Console.Write("Stranica b: ");
                    if (double.TryParse(Console.ReadLine(), out b))
                    {
                        if (b > 0)
                            break;
                    }
                } 
                while (true)
                {
                    Console.Write("Stranica c: ");
                    if (double.TryParse(Console.ReadLine(), out c))
                    {
                        if (c > 0)
                            break;
                    }
                }

            }

        }
    }
}
