﻿using System;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class Main : Form
	{
        User User { get; set; }
		public Main(User User)
		{
            this.User = User;
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void CameraScanButton_Click(object sender, EventArgs e)
		{
			//Paspaudus skenuoti, bus atidarytas naujas langas, kuriame bus galima pasirinkti barcode
			//(Vėliau bus pakeista į kameros skenavima).
			this.Hide();
			Camera cameraMenu = new Camera(User);
			cameraMenu.Show();
		}

		private void SearchBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			SearchBook searchBookMenu = new SearchBook();
			searchBookMenu.Show();
		}
	}
}
