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
		Navigation nav;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			nav = new Navigation();
			nav.OpenLoginMenu(this);
		}
	}
}