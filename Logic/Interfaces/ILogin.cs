using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public interface ILogin
	{
		event Action ButtonPressed;

		String Username { get; }
		String Password { get; }
		void OnLoginSuccessful();
		void OnError(string message);
	}
}
