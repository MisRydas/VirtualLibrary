using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using static Logic.SQLConnection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class Login
    {
		public static User user;
        ILogin loginData;
        public Login(ILogin loginData)
        {
            this.loginData = loginData;
			loginData.ButtonPressed += () => LoginCheck();
        }

        public void LoginCheck()
		{
            string error = "";
			//Gaunam informacija apie naudotojus is sql serverio
			DataTable userData = GetAllUsersInDataTable();

			//Tikriname ar yra toks vartotojas duomenu bazeje
			var userLogin = from user in userData.AsEnumerable() where user.Field<string>("username") == loginData.Username && user.Field<string>("password") == loginData.Password select user;

			//Gauname informacija apie vartotoja, jei toks buvo rastas
			DataView result = userLogin.AsDataView();

			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (result.Count == 1)
			{
				user = SQLConnection.GetUserById((int)result[0]["Id"]);
				loginData.OnLoginSuccess(user);
			}
			else
			{
                error = "Wrong username or password";
				loginData.OnError(error);
			}
		}
    }
}
