using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace VirtualLibraryApp
{
    class SQLConnection
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

        public static void Query(String query) //Paprastas metodas INSERT, DELETE sakiniams vykdyti, negražina rezultato.
        {
            MySqlConnection conn = SQLConnection.Connect();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable SelectQuery(String query) //Metodas SELECT sakiniams vykdyti, nes gražina reikšme supildytą į DataTable
        {
            MySqlConnection conn = SQLConnection.Connect();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = command;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            conn.Close();
            return dTable;
        }

        public static User GetUserById(int id)
        {
            User user = new User();
            string query = String.Format("SELECT * FROM Users WHERE Id = {0};", id);
            DataTable dt = SelectQuery(query);
            user.Id = (int)dt.Rows[0]["Id"];
            user.UserName = (string)dt.Rows[0]["UserName"];
            if (dt.Rows[0]["FirstName"] != DBNull.Value) user.FirstName = (string)dt.Rows[0]["FirstName"];
            if (dt.Rows[0]["LastName"] != DBNull.Value) user.LastName = (string)dt.Rows[0]["LastName"];
            return user;
        }

        public static void AddNewUser(String UserName, String Password, String FirstName, String LastName)
        {
            string query = String.Format("Insert into Users (UserName, Password, FirstName, LastName) VALUES ('{0}', '{1}', '{2}', '{3}');;", UserName, Password, FirstName, LastName);
            Query(query);
        }
    }
}
