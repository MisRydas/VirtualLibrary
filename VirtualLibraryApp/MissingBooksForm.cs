using System;
using Logic;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class MissingBooksForm : Form, IMissingBooks
	{
		public event Action LoadMissingBooks;


		public MissingBooksForm()
		{
			InitializeComponent();
		}

		public void LoadBooks()
		{
			LoadMissingBooks();
		}

		public void OnMissingBooksFound(DataView missingBooks)
		{
			dataGridView1.DataSource = missingBooks;
		}


		private void Back_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
