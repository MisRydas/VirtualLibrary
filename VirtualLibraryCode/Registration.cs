using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class RegistrationDataProvider
	{
		public bool emptyFields;
		public bool passwordsDontMatch;
		public bool passwordIsNotCorrect;

		public RegistrationDataProvider()
		{
			emptyFields = false;
			passwordsDontMatch = false;
			passwordIsNotCorrect = false;
		}
		
		public void ResetData()
		{
			emptyFields = false;
			passwordsDontMatch = false;
			passwordIsNotCorrect = false;
		}
	}

	public class Registration
	{
		User user = new User();

		public void CreateAccount(string username, string password, string cPassword, string firstname, string lastname, RegistrationDataProvider registrationData)
		{
			registrationData.ResetData();
			// Jei buvo paliktas bent vienas tuscias laukas, programa meta errora
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cPassword) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
			{
				registrationData.emptyFields = true;
			}
			// Jei passwordai nevienodi programa meta errora
			else if (password != cPassword)
			{
				registrationData.passwordsDontMatch = true;
			}
			// Jei visi laukai irasyti ir slaptazodziai sutampa, tuomet programa i DB iraso naujo vartuotojo duomenis
			else
			{
				//Nusiskaitomos reikšmės iš textboxų
				user.UserName = username.Trim();
				user.Password = password.Trim();

				if (!CheckPassword(password.Trim()))
				{
					registrationData.passwordIsNotCorrect = true;
					return;
				}
				else
				{
					user.FirstName = firstname.Trim();
					user.LastName = lastname.Trim();
					//Pridedamas useris į DB
					SQLConnection.AddNewItem(user);
				}
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
