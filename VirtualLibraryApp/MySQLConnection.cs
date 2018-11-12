using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace VirtualLibraryApp
{
    public class MySQLConnection : IDBConnection
    {
        private static MySqlConnection Connect()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);
            conn.Open();
            return conn;
        }

        public void Query(String query) //Paprastas metodas INSERT, DELETE sakiniams vykdyti, negražina rezultato.
        {
            MySqlConnection conn = Connect();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable SelectQuery(String query) //Metodas SELECT sakiniams vykdyti, nes gražina reikšme supildytą į DataTable
        {
            MySqlConnection conn = Connect();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = command;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            conn.Close();
            return dTable;
        }

    }
}
