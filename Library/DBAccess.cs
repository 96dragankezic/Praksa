﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DBAccess : IDBAccess
    {
        public void obrisiSveRedoveIzTabela(string queryStringDelete, SqlConnection connection)
        {
            //Brisanje svih redova iz tabele Palindromes
            SqlCommand command = new SqlCommand(queryStringDelete, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

        public List<string> procitajIzTabela(string queryString, SqlConnection connection)
        {
            //Citanje svih redova iz tabele Candidates
            List<String> list = new List<String>();
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int brKandidata = 0;
                while (reader.Read())
                {
                    brKandidata++;
                    if (Library.Class1.funkcijaPalindrom(reader[0].ToString()))
                    {
                        list.Add(reader[0].ToString());
                    }
                    //Console.WriteLine(reader[0]);
                }
                Console.Write($"Broj kandidata za proveru: {brKandidata}\n");
                Console.Write($"Broj nadjenih palindroma: {list.Count()}\n\n");

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();

            return list;
        }

        public void upisiUTabelu(SqlConnection connection, List<string> list)
        {
            //Upis svih palindroma u tabelu Palindromes
            SqlCommand command = new SqlCommand();
            try
            {
                Console.WriteLine("***Palindromi***");
                connection.Open();
                foreach (String str in list)
                {
                    Console.WriteLine(str);
                    string query = $"INSERT INTO Palindromes (Text) VALUES ('{str}')";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
    }
}
