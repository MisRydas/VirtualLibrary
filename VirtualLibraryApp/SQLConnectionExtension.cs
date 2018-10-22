using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SQLConnectionExtensions
{
    static class SQLConnectionExtension
    {
        static String server = "78.61.151.149";
        static String database = "LibraryAppDB";
        static String uid = "LibraryAppUser";
        static String password = "AudiBMW";
        static String connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Sslmode=none;";

        private static MySqlConnection Connect()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void Query(this String query) //Paprastas metodas INSERT, DELETE sakiniams vykdyti, negražina rezultato.
        {
            MySqlConnection conn = Connect();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable SelectQuery(this String query) //Metodas SELECT sakiniams vykdyti, nes gražina reikšme supildytą į DataTable
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
