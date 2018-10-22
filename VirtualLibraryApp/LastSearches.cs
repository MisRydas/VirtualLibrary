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
            isbn1 = bookdata.Count > 0 ? bookdata[0]["ISBN13"].ToString() : "";
            isbn2 = bookdata.Count > 1 ? bookdata[1]["ISBN13"].ToString() : "";
            isbn3 = bookdata.Count > 2 ? bookdata[2]["ISBN13"].ToString() : "";
            if (bookdata.Count > 0)
                pictureBox1.Load(bookdata[0]["CoverLink"].ToString());
            if(bookdata.Count > 1)
            pictureBox2.Load(bookdata[1]["CoverLink"].ToString());
            if(bookdata.Count > 2)
            pictureBox3.Load(bookdata[2]["CoverLink"].ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(isbn1.Length == 13)
            {
                DataView result = GetBookByISBNInDataView(isbn1);
                Book b = new Book(result);
                this.Hide();
                b.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isbn2.Length == 13)
            {
                DataView result = GetBookByISBNInDataView(isbn2);
                Book b = new Book(result);
                this.Hide();
                b.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isbn3.Length == 13)
            {
                DataView result = GetBookByISBNInDataView(isbn3);
                Book b = new Book(result);
                this.Hide();
                b.ShowDialog();
            }
        }
    }
}
