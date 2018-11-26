using System;
using Logic;
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
	public partial class BookForm : Form
	{

		public BookForm(DataView bookdata, int i)
		{
			InitializeComponent();

			//Informacija apie knyga
			BookName.Text = bookdata[i]["BookName"].ToString();
			ISBN13.Text = bookdata[i]["ISBN13"].ToString();
			ISBN10.Text = bookdata[i]["ISBN10"].ToString();
			Author.Text = bookdata[i]["Author"].ToString();
			Publisher.Text = bookdata[i]["Publisher"].ToString();
			Published.Text = bookdata[i]["Published"].ToString();
			ListPrice.Text = bookdata[i]["ListPrice"].ToString();
			BookCoverBox.Load(bookdata[i]["CoverLink"].ToString());
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
