using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VirtualLibraryApp
{
	public partial class SearchBook : Form
	{
		Regex regex;
		DataView result;

	//	public User User { get; set; }

		public SearchBook()
		{
			InitializeComponent();
	//		this.User = user;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(SearchTextBox.Text))
			{
				MessageBox.Show("Write keyword to find book.");
			}
			else
			{

			}
		}
	}
}
