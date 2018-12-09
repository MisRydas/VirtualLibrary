using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LogicWebService
{
	/// <summary>
	/// Summary description for LastSearches
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class LastSearches : System.Web.Services.WebService
	{
		[WebMethod]
		public DataTable GetLastUserSearches()
		{
			DataTable books = SQLConnection.GetLastSearches(Login.user.Id);
			books.TableName = "Books";
			return books;
		}
	}
}
