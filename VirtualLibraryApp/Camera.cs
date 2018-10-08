using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.Barcode;


namespace VirtualLibraryApp
{
	public partial class Camera : Form
	{
		DataTable bookdata;
        public User User { get; set; }
		public Camera(User User)
		{
            this.User = User;
			InitializeComponent();
		}

		private void LoadBarcodeButton_Click(object sender, EventArgs e)
		{
			//Atidaromas aplankas, kuriame yra barcode pavyzdziai ir pasirinkus barcod'a jis yra uzkraunamas.
			OpenFileDialog OD = new OpenFileDialog();
            OD.InitialDirectory = System.IO.Directory.GetParent(@"../../../ ").FullName + @"\Barcode Images";
			if (OD.ShowDialog() == DialogResult.OK)
				BarcodeImageBox.Load(OD.FileName);
			//Nuskenuojami barcodo duomenis ir gaunamas knygos isbn kodas.
			BarcodeDecoder Scanner = new BarcodeDecoder();
			Result result = Scanner.Decode(new Bitmap(BarcodeImageBox.Image));
			//Atidaromas tinklapis su informacija apie ieskoma knyga.(Tik kaip pavyzdys, vėliau bus pakeista).
			//System.Diagnostics.Process.Start("https://isbnsearch.org/isbn/" + result.Text);


			//Tikrina ISBN formatą ar isbn13 ar isbn10, jei nei vienas, tai rastas blogas kodas.
			if (result.Text.Length == 13)
			{
				CheckISBN(result.Text, 13);
			}
			else if (result.Text.Length == 10)
			{
				CheckISBN(result.Text, 10);
			}
			else
			{
				MessageBox.Show("Wrong ISBN, please try again.");
			}
		}

		//Tikrinam isbn ar yra tokia knyga duombazej
		private void CheckISBN(string isbn, int isbnLength)
		{
			//ieskom knygos su isbn
			bookdata = SQLConnection.SelectQuery("SELECT * FROM Books WHERE ISBN" + isbnLength + " = '" + isbn + "';");


			//jei knyga rasta, tai atidarom langa su informacija apie ja, jei knyga nerasta praso ieskoti vel.
			if (bookdata.Rows.Count > 0)
			{
				this.Hide();
				Book bookMenu = new Book(bookdata);
				bookMenu.Show();
				SQLConnection.AddISBNToHistory(User.Id, isbn);
			}
			else
			{
				MessageBox.Show("We don't have this book at this time, please try another one.");
			}
		}
	}
}
