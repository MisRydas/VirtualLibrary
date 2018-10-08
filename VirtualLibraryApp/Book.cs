using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class Book : Form
	{
		public Book(string isbn)
		{
			InitializeComponent();

			if (isbn.Length == 13)
			{
				DataTable data = SQLConnection.SelectQuery("SELECT * FROM Books WHERE ISBN13 = '" + isbn + "';");
				MessageBox.Show(data.Rows[0][0].ToString());
			}
		}
	}
}
