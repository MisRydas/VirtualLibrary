using System;
using Logic;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
    public partial class LastSearchesForm : Form
    {
		User user;
		LastSearches lastSearches;
		LastSearchesDataProvider lastSearchesData;



		public LastSearchesForm(User user)
        {
			InitializeComponent();

			this.user = user;
			lastSearches = new LastSearches();
			lastSearchesData = new LastSearchesDataProvider();

			lastSearches.GetLastUserSearches(lastSearchesData, user);

            if (lastSearchesData.isbn1 != null)
                pictureBox1.Load(lastSearchesData.bookData[0]["CoverLink"].ToString());
			if (lastSearchesData.isbn2 != null)
				pictureBox2.Load(lastSearchesData.bookData[1]["CoverLink"].ToString());
			if (lastSearchesData.isbn3 != null)
				pictureBox3.Load(lastSearchesData.bookData[2]["CoverLink"].ToString());
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Navigation.OpenBookMenu(this, user, lastSearches.GetBook(lastSearchesData.isbn1));
		}

		private void pictureBox2_Click(object sender, EventArgs e)
        {
			Navigation.OpenBookMenu(this, user, lastSearches.GetBook(lastSearchesData.isbn2));
		}

		private void pictureBox3_Click(object sender, EventArgs e)
        {
			Navigation.OpenBookMenu(this, user, lastSearches.GetBook(lastSearchesData.isbn3));
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
