using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VirtualLibraryApp.SQLConnection;

namespace VirtualLibraryApp
{
    public partial class LastSearches : Form
    {
        private string isbn1;
        private string isbn2;
        private string isbn3;
        public LastSearches(User user)
        {
            InitializeComponent();
            DataView bookdata = GetLastSearches(user.Id).AsDataView();
            isbn1 = bookdata[0]["ISBN13"].ToString();
            isbn2 = bookdata[1]["ISBN13"].ToString();
            isbn3 = bookdata[2]["ISBN13"].ToString();
            pictureBox1.Load(bookdata[0]["CoverLink"].ToString());
            pictureBox2.Load(bookdata[1]["CoverLink"].ToString());
            pictureBox3.Load(bookdata[2]["CoverLink"].ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataView result = GetBookByISBNInDataView(isbn1);
            Book b = new Book(result);
            this.Hide();
            b.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataView result = GetBookByISBNInDataView(isbn2);
            Book b = new Book(result);
            this.Hide();
            b.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataView result = GetBookByISBNInDataView(isbn3);
            Book b = new Book(result);
            this.Hide();
            b.ShowDialog();
        }
    }
}
