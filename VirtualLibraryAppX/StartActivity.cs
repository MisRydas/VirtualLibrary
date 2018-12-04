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

namespace VirtualLibraryAppX
{
	[Activity(Label = "Virtual Library", Theme = "@style/AppTheme"/*, MainLauncher = true*/)]
	public class StartActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

		//	Intent login = new Intent(this, typeof(LoginActivity));
			
			//StartActivity(login);
			// Create your application here
		}
	}
}