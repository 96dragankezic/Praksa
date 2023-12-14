using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbPalindrom.Models;
using Library;

namespace DbPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=DESKTOP-U8FHNKB\\SQLEXPRESS;Initial Catalog=Palindromes;Integrated Security=True";
            const string queryStringDelete = "DELETE FROM Palindromes";
            const string queryString = "SELECT * FROM Candidates";
            List<string> listPalindromes = new List<string>();
            Library.DBAccess dBAccess = new Library.DBAccess();

            //pristup bazi podataka koriscenjem Entity Frameworka
            using (var context = new PalindromDbContext())
            {
                //brisanje svih redova i tabeli Palindromes
                foreach(var item in context.Palindromes)
                {
                    context.Palindromes.Remove(item);
                }

                //citanje svih potencijalnih palindroma iz tabele Candidates
                var allPalindromes = context.Candidates.ToList();

                //upis svih palindroma u tabelu Palindromes
                int brKandidata = 0;
                foreach (var item in allPalindromes)
                {
                    brKandidata++;

                    if (Class1.funkcijaPalindrom(item.Text))
                    {
                        var tempPalindrome = new Palindrome();
                        tempPalindrome.Text = item.Text;
                        context.Palindromes.Add(tempPalindrome);
                        context.SaveChanges();
                    }
                }
                Console.Write($"Broj kandidata za proveru: {brKandidata}\n");
                Console.Write($"Broj nadjenih palindroma: {context.Palindromes.Count()}\n\n");
            }
            Console.ReadKey();


            //pristup bazi podataka koriscenjem ADO.NETa
            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dBAccess.obrisiSveRedoveIzTabela(queryStringDelete, connection);

                listPalindromes = dBAccess.procitajIzTabela(queryString, connection);

                dBAccess.upisiUTabelu(connection, listPalindromes);
                Console.ReadKey();
            }*/
        }
    }
}
