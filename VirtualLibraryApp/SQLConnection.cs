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

        /*public static User GetUserById(int id)
        {
            User user = new User();
            string query = String.Format("SELECT * FROM Users WHERE Id = {0};", id);
            DataTable dt = SelectQuery(query);
            user.id = (int)dt.Rows[0]["Id"];
            user.name = (string)dt.Rows[0]["Name"];
            user.email = (string)dt.Rows[0]["Email"];
            return user;
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM Users WHERE IsActive = 1";
            DataTable dt = SelectQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                users.Add(new User((int)dt.Rows[i]["Id"], (string)dt.Rows[i]["Name"], (string)dt.Rows[i]["Email"]));
            }
            return users;
        }*/
    }
}
