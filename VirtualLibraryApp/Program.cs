using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace VirtualLibraryApp
{
	static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			LoginForm loginMenu = new LoginForm();
			Login login = new Login(loginMenu);
			Application.Run(loginMenu);
		}
	}
}
