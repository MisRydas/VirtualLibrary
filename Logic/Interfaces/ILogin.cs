using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	interface ILogin
	{
		event Action ButtonPressed;

		String Username { get; }
		String Password { get; }
		void OnError(string message);
	}
}
