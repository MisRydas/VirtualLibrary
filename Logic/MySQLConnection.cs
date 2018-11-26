using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class MySQLConnection : IDBConnection
	{
		static String server = "78.61.151.149";
		static String database = "LibraryAppDB";
		static String uid = "LibraryAppUser";
		static String password = "AudiBMW";
		static String connectionString = "SERVER=" + server + ";" + "DATABASE=" +
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Sslmode=none;";

		private static MySqlConnection Connect()
		{
			MySqlConnection conn = new MySqlConnection(connectionString /*ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString*/);
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
