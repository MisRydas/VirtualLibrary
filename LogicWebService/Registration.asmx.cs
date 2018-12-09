using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace LogicWebService
{
	/// <summary>
	/// Summary description for Registration
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class Registration : System.Web.Services.WebService
	{
		[WebMethod]
		public void CreateAccount(ref string error, string username, string password, string cPassword, string firstname, string lastname)
		{
			User user = new User();
			error = "";
			// Jei buvo paliktas bent vienas tuscias laukas, programa meta errora
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
			{
				error += "Please fill mandatory fields";
			}
			// Jei passwordai nevienodi programa meta errora
			else if (password != cPassword)
			{
				error += "Passwords do not match";
			}
			else if (!CheckPassword(password.Trim()))
			{
				error += "Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.";
			}

			// Jei visi laukai irasyti ir slaptazodziai sutampa, tuomet programa i DB iraso naujo vartuotojo duomenis
			if (error.Length == 0)
			{
				//Nusiskaitomos reikšmės iš textboxų
				user.UserName = username.Trim();
				user.Password = password.Trim();
				user.FirstName = firstname.Trim();
				user.LastName = lastname.Trim();
				//Pridedamas useris į DB
				SQLConnection.AddNewItem(user);
			}
		}

		public bool CheckPassword(String Password)
		{
			Regex regex;
			regex = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z]).{8,}$");

			return regex.IsMatch(Password.ToString()) ? true : false;
		}
	}
}
