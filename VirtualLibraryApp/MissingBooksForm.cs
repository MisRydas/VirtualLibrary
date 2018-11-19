using Logic;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class MissingBooksForm : Form
	{
		User user;
		MissingBooks missingBooks;

		public MissingBooksForm(User user)
		{
			InitializeComponent();

			this.user = user;
			missingBooks = new MissingBooks();

			dataGridView1.DataSource = missingBooks.GetMissingBooks();
		}

		private void Back_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
