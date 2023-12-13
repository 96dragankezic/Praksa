using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                dBAccess.obrisiSveRedoveIzTabela(queryStringDelete, connection);

                listPalindromes = dBAccess.procitajIzTabela(queryString, connection);

                dBAccess.upisiUTabelu(connection, listPalindromes);
                Console.ReadKey();
            }
        }
    }
}
