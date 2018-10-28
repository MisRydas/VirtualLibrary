using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class MissingBooks : Form
	{
		public MissingBooks()
		{
			InitializeComponent();

			DataTable missingBooks = SQLConnection.GetAllMissingBooksISBN();

			DataView result = missingBooks.AsDataView();

			MessageBox.Show(result[0][0].ToString() /*+ "\n" + result[1][0].ToString() + "\n" + result[2][0].ToString() + "\n" + result[3][0].ToString()*/);

		}
	}
}
