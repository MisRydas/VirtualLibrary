using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Logic;

namespace VirtualLibraryAppX
{
	[Activity(Label = "Navigation")]
	public class Navigation : Activity
	{

		public void OpenLoginMenu(Context package)
		{
			LoginActivity logAct = new LoginActivity();
			Login login = new Login(logAct);
			Intent loginMenu = new Intent(package,logAct.Class);
			package.StartActivity(loginMenu);
		}

		public void OpenMainMenu(Context package)
		{
			Intent mainMenu = new Intent(package, typeof(MainActivity));
			package.StartActivity(mainMenu);
		}
	}
}