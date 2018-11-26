using System;
using Logic;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class LastSearchesForm : Form, ILastSearches
	{
		public event Action LoadSearches;

		DataView bookData;

		public LastSearchesForm()
		{
			InitializeComponent();
		}

		public void LoadSearch()
		{
			LoadSearches();
		}

		public void LoadBooks(DataView bookData)
		{
			this.bookData = bookData;

			if (bookData[0]["CoverLink"] != null)
				pictureBox1.Load(bookData[0]["CoverLink"].ToString());
			if (bookData[1]["CoverLink"] != null)
				pictureBox2.Load(bookData[1]["CoverLink"].ToString());
			if (bookData[2]["CoverLink"] != null)
				pictureBox3.Load(bookData[2]["CoverLink"].ToString());
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Navigation.OpenBookMenu(this, bookData, 0);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
        {
			Navigation.OpenBookMenu(this, bookData, 1);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
        {
			Navigation.OpenBookMenu(this, bookData, 2);
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
