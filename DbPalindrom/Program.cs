using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=DESKTOP-U8FHNKB\\SQLEXPRESS;Initial Catalog=Palindromes;Integrated Security=True";
            const string queryString = "SELECT * FROM Candidates";


            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0]);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
