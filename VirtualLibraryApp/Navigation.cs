using System;
using System.Windows.Forms;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryApp
{
	class Navigation
	{
		private static Form menu;
		private static User user;

		public static void LoadUser(User navigationUser)
		{
			user = navigationUser;
		}

		public static void OpenMenu(String menuName, Form senderMenu, bool withUser)
		{

			if (withUser)
			{
				menu = Activator.CreateInstance(Type.GetType("VirtualLibraryApp." + menuName), user) as Form;
			}
			else
			{
				menu = Activator.CreateInstance(Type.GetType("VirtualLibraryApp." + menuName)) as Form;
			}
			senderMenu.Hide();
			menu.ShowDialog();
			senderMenu.Show();
		}
	} 
}
