using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SQLConnectionExtensions;

namespace VirtualLibraryApp
{
    public class SQLConnection
    {

        public static User GetUserById(int id)
        {
            User user = new User();
            string query = String.Format("SELECT * FROM Users WHERE Id = {0};", id);
            DataTable dt = query.SelectQuery();
            user.Id = (int)dt.Rows[0]["Id"];
            user.UserName = (string)dt.Rows[0]["UserName"];
            if (dt.Rows[0]["FirstName"] != DBNull.Value) user.FirstName = (string)dt.Rows[0]["FirstName"];
            if (dt.Rows[0]["LastName"] != DBNull.Value) user.LastName = (string)dt.Rows[0]["LastName"];
            user.IsAdmin = (ulong)dt.Rows[0]["IsAdmin"] == 1 ? true : false;
            return user;
        }

        public static void AddNewUser(String UserName, String Password, String FirstName, String LastName)
        {
            string query = String.Format("Insert into Users (UserName, Password, FirstName, LastName) VALUES ('{0}', '{1}', '{2}', '{3}');;", UserName, Password, FirstName, LastName);
            query.Query();
        }

        public static void AddISBNToHistory(int UserId, String ISBN)
        {
            string query = String.Format("Insert into ISBNSearches (UserId, ISBN) VALUES ('{0}', '{1}');;", UserId, ISBN);
            query.Query();
        }

		public static void AddNewBook(String BookName, String ISBN13, String ISBN10, String Author, String Genre, String Publisher, int Published, double ListPrice, String CoverLink)
		{
			string query = String.Format("Insert into Books (BookName, ISBN13, ISBN10, Author, Publisher, Published, ListPrice, CoverLink, Genre) VALUES " +
										"('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');;",
										BookName, ISBN13, ISBN10, Author, Publisher, Published, ListPrice, CoverLink, Genre);
            query.Query();
        }

        public static DataTable GetAllBooksInDataTable()
        {
            String query = "Select * FROM Books;";
            return query.SelectQuery();
        }

        public static DataTable GetAllUsersInDataTable()
        {
            String query = "Select * FROM Users;";
            return query.SelectQuery();
        }

        public static DataTable GetLastSearches(int userId)
        {
            String query = String.Format("SELECT b.ISBN13, b.CoverLink FROM ISBNSearches s JOIN Books b ON s.ISBN = b.ISBN13 WHERE s.UserId = {0} ORDER BY s.Time DESC;", userId.ToString());
            return query.SelectQuery();
        }

		public static DataTable GetAllMissingBooksISBN()
		{
			String query = String.Format("SELECT DISTINCT S.ISBN " +
										"FROM ISBNSearches S, Books B " +
										"WHERE LENGTH(S.ISBN) = 13 AND S.ISBN NOT IN (B.ISBN13) OR LENGTH(S.ISBN) = 10 AND S.ISBN NOT IN (B.ISBN10) " +
									    "ORDER BY S.Time DESC;");
			return query.SelectQuery();
		}

		public static DataView GetBookByISBNInDataView(string isbn)
        {
            String query = String.Format("SELECT * FROM Books WHERE ISBN13 = {0};", isbn);
            return query.SelectQuery().AsDataView();
        }
    }
}
