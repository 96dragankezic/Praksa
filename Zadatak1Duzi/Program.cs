using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Zadatak1Duzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu za proveru da li je palindrom: ");
            string recenica = Console.ReadLine();
            recenica = recenica.Trim('.', '!', '?', ' ', ',');
            string[] reci = recenica.Split(' ', ',');
            recenica = "";
            for(int i = 0; i < reci.Length; i++)
            {
                recenica += reci[i];
            }
            recenica.ToLower();
            if (Library.Class1.funkcijaPalindrom(recenica))
            {
                Console.WriteLine("Jeste palindrom!");
            }
            else
            {
                Console.WriteLine("Nije palindrom!");
            }

            Console.ReadKey();
            //Library.Class1 library = new Library.Class1();
            //library.funkcija();
        }
    }
}
