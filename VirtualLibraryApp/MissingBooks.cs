using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class MissingBooks : Form
	{
		User user;

		public MissingBooks(User user)
		{
			this.user = user;

			InitializeComponent();

			DataTable missingBooks = SQLConnection.GetAllMissingBooksISBN();

			DataView result = missingBooks.AsDataView();

			dataGridView1.DataSource = result;
		}

		private void Back_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
