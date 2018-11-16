using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using static VirtualLibraryCode.SQLConnection;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryCode
{
	public class LoginEventsArgs : EventArgs
	{
		public bool correctData { get; set; }
		public DataView result { get; set; } //Bus pakeista i 		public User user { get; set; }


		public LoginEventsArgs()
		{
			correctData = false;
			DataView result; //Bus pakeista i User user;

		}
	}

	public class LoginCode
    {

		//sukuriam delegata.
		public delegate void LoginEventHandler(string username, string password, LoginEventsArgs eventArgs);
		//Sukuriam eventa.
		public event LoginEventHandler ThrowLoginEvent = delegate { };

		public void LoginCheck(string username, string password, LoginEventsArgs eventArgs)
		{
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
				eventArgs.correctData = true;
				eventArgs.result = result; //Bus pakeista i 				eventArgs.user = SQLConnection.GetUserById((int)result[0]["Id"]);

			}
			else
			{
				eventArgs.correctData = false;
			}
		}
    }
}
