using System;
using System.Data;
using static LogicWebService.SQLConnection;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LogicWebService
{
	/// <summary>
	/// Summary description for Login
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class Login : System.Web.Services.WebService
	{
		public static User user;

		[WebMethod]
		public bool LoginCheck(string username, string password, out string error)
		{
			error = "";
			//Gaunam informacija apie naudotojus is sql serverio
			DataTable userData = GetAllUsersInDataTable();

			//Tikriname ar yra toks vartotojas duomenu bazeje
			var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == username && user.Field<string>("password") == password select user;

			//Gauname informacija apie vartotoja, jei toks buvo rastas
			DataView result = userLogin.AsDataView();

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (result.Count == 1)
			{
				user = SQLConnection.GetUserById((int)result[0]["Id"]);
				return true;
			}
			else
			{
				error = "Wrong username or password";
				return false;
			}
		}
	}
}
