using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal interface IDBAccess
    {
        void obrisiSveRedoveIzTabela(string queryStringDelete, SqlConnection connection);
        void upisiUTabelu(SqlConnection connection, List<string> list);
        List<string> procitajIzTabela(string queryString, SqlConnection connection);
    }
}
