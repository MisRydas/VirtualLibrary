using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public interface IRegistration
	{
		event Action ButtonPressed;
		String Username { get; }
		String Password { get; }
		String ConfirmPassword { get; }
		String Firstname { get; }
		String Lastname { get; }
		void OnRegistrationSuccess();
		void OnError(string message);
	}
}
