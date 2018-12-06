using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicWebService
{
	public class SQLConnection
	{
		private static IDBConnection conn = null;
		private static IDBConnection Conn
		{
			get
			{
				if (conn == null)
				{
					conn = new MySQLConnection();
				}
				return conn;
			}
		}

		public static User GetUserById(int id)
		{
			User user = new User();
			string query = String.Format("SELECT * FROM Users WHERE Id = {0};", id);
			DataTable dt = Conn.SelectQuery(query);
			user.Id = (int)dt.Rows[0]["Id"];
			user.UserName = (string)dt.Rows[0]["UserName"];
			if (dt.Rows[0]["FirstName"] != DBNull.Value) user.FirstName = (string)dt.Rows[0]["FirstName"];
			if (dt.Rows[0]["LastName"] != DBNull.Value) user.LastName = (string)dt.Rows[0]["LastName"];
			user.IsAdmin = (ulong)dt.Rows[0]["IsAdmin"] == 1 ? true : false;
			return user;
		}

		public static void AddISBNToHistory(int UserId, String ISBN)
		{
			string query = String.Format("Insert into ISBNSearches (UserId, ISBN) VALUES ('{0}', '{1}');;", UserId, ISBN);
			Conn.Query(query);
		}

		public static void AddNewItem(IItem item)
		{
			string query = String.Format("Insert into {0} {1} VALUES {2};",
										item.TableName(), item.TypesInString(), item.ValuesInString());
			Conn.Query(query);
		}

		public static DataTable GetAllBooksInDataTable()
		{
			String query = "Select * FROM Books;";
			return Conn.SelectQuery(query);
		}

		public static DataTable GetAllUsersInDataTable()
		{
			String query = "Select * FROM Users;";
			return Conn.SelectQuery(query);
		}

		public static DataTable GetLastSearches(int userId)
		{
			String query = String.Format("SELECT b.BookName, b.ISBN13, b.ISBN10, b.Author, b.Publisher, b.Published, b.ListPrice, b.CoverLink FROM ISBNSearches s JOIN Books b ON s.ISBN = b.ISBN13 WHERE s.UserId = {0} ORDER BY s.Time DESC;", userId.ToString());
			return Conn.SelectQuery(query);
		}

		public static DataTable GetAllMissingBooksISBN()
		{
			String query = String.Format("SELECT S.ISBN, COUNT(S.ISBN) AS 'Kiek kartų ieškota', S.Time AS 'Pirmą kartą ieškota' " +
										"FROM ISBNSearches S " +
										"WHERE LENGTH(S.ISBN) = 13 AND S.ISBN NOT IN (SELECT ISBN13 FROM Books) OR " +
										"LENGTH(S.ISBN) = 10 AND S.ISBN NOT IN (SELECT ISBN10 FROM Books) " +
										"GROUP BY ISBN " +
										"ORDER BY S.Time DESC;");
			return Conn.SelectQuery(query);
		}

		public static DataTable GetBookByISBNInDataView(string isbn)
		{
			String query = String.Format("SELECT * FROM Books WHERE ISBN13 = {0};", isbn);
			return Conn.SelectQuery(query);
		}

		public static string GetBookName(string isbn)
		{
			String query = String.Format("SELECT BookName FROM Books WHERE ISBN13 = {0};", isbn);
			DataView dv = Conn.SelectQuery(query).AsDataView();
			return dv[0]["BookName"].ToString();
		}
	}
}