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
		User user;
		ILogin loginData;
		public Login(ILogin loginData)
		{
			this.loginData = loginData;
			loginData.ButtonPressed += () => LoginCheck();
		}

		public void LoginCheck()
		{
			//Gaunam naudotoja is duomenu bazes su ivestais duomenimis.
			User user = SQLConnection.GetUserByPassword(loginData.Username, loginData.Password);
			//Jei vartotojo ivestas vardas ir slaptazodis atitiko, atidaromas meniu langas, kitu atveju 
			//lentele, kad duomenys blogi.
			if (user != null)
			{
				this.user = user;
				loginData.OnLoginSuccessful();
			}
			else
			{
				string error = "Incorrect Username or Password. Please, try again.";
				loginData.OnError(error);
			}
		}
    }
}
