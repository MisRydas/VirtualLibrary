using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{	
	public class Registration
	{
		IRegistration registrationData;
		User user;

		public Registration(IRegistration registrationData)
		{
			user = new User();
			this.registrationData = registrationData;
			registrationData.ButtonPressed += () => CreateAccount();
		}

		public void CreateAccount()
		{
			string error = "";
			// Jei buvo paliktas bent vienas tuscias laukas, programa meta errora
			if (string.IsNullOrEmpty(registrationData.Username) || string.IsNullOrEmpty(registrationData.Password) || string.IsNullOrEmpty(registrationData.ConfirmPassword) || string.IsNullOrEmpty(registrationData.Firstname) || string.IsNullOrEmpty(registrationData.Lastname))
			{
				error += "Please fill mandatory fields";
			}
			// Jei passwordai nevienodi programa meta errora
			else if (registrationData.Password != registrationData.ConfirmPassword)
			{
				error += "Passwords do not match";
			}
			else if (!CheckPassword(registrationData.Password.Trim()))
			{
				error += "Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.";
			}

			if (error.Length != 0)
			{
				registrationData.OnError(error);
			}
			// Jei visi laukai irasyti ir slaptazodziai sutampa, tuomet programa i DB iraso naujo vartuotojo duomenis
			else
			{
				//Nusiskaitomos reikšmės iš textboxų
				user.UserName = registrationData.Username.Trim();
				user.Password = registrationData.Password.Trim();
				user.FirstName = registrationData.Firstname.Trim();
				user.LastName = registrationData.Lastname.Trim();
				//Pridedamas useris į DB
				SQLConnection.AddNewItem(user);

				registrationData.OnRegistrationSuccess();
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
