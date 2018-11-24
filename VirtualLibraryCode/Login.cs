using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using static Logic.SQLConnection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginDataProvider
	{
		public bool correctData;
		public User user;

		public LoginDataProvider()
		{
			correctData = false;
		}
	}

	public class Login
    {
        public User user;
        public delegate void OnError<T1>(T1 message);
        public delegate void OnSuccess();
        ILoginView view;
        public Login(ILoginView view)
        {
            this.view = view;
            view.ButtonPressed += () => LoginCheck();
        }
        //sukuriam delegata.
        //	public delegate void LoginEventHandler(string username, string password, LoginEventsArgs eventArgs);
        //Sukuriam eventa.
        //	public event LoginEventHandler ThrowLoginEvent = delegate { };

        public void LoginCheck()
		{
            string error = "";
			//Gaunam informacija apie naudotojus is sql serverio
			DataTable userData = GetAllUsersInDataTable();

			//Tikriname ar yra toks vartotojas duomenu bazeje
			var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == view.Username && user.Field<string>("password") == view.Password select user;

			//Gauname informacija apie vartotoja, jei toks buvo rastas
			DataView result = userLogin.AsDataView();

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (result.Count == 1)
			{
				user = SQLConnection.GetUserById((int)result[0]["Id"]);
			}
			else
			{
                error = "Wrong username or password";

			}
		}
    }
}
