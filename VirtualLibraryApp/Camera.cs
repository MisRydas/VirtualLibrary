using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using static VirtualLibraryApp.SQLConnection;
using DarrenLee.Media;
using System.Threading.Tasks;

delegate void Check<T1, T2>(T1 i, T2 s);
delegate Result Deleg();
namespace VirtualLibraryApp
{

    public partial class CameraScreen : Form
	{

		public User User { get; set; }
		DataView result;
		Camera myCamera = new Camera();
        public CameraScreen(User User)

		{
			this.User = User;
			InitializeComponent();

			GetInfo();
			myCamera.OnFrameArrived += myCamera_OnFrameArrived;
		}
		private void GetInfo()
		{
			var myCameraResolutions = myCamera.GetSupportedResolutions();

			foreach (var r in myCameraResolutions)
				CameraResolutionComboBox.Items.Add(r);

			CameraResolutionComboBox.SelectedIndex = 0;
		}
		private void myCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
		{
			Image img = e.GetFrame();
			BarcodeImageBox.Image = img;

		}


		private void LoadBarcodeButton_Click(object sender, EventArgs e)
		{

            Result result;
            Check<int, string> ch1013 = new Check<int, string>(Check1013);
            Deleg res = new Deleg(BarcodeLoader);

            //iskvieciam delegata
            result = res();
            ch1013(result.Text.Length, result.Text);
        }


        public async void CheckISBN(string isbn, int isbnLength)
        {

			await GetBookInDataView(isbn, isbnLength);

			//jei knyga rasta, tai atidarom langa su informacija apie ja, jei knyga nerasta praso ieskoti vel.
			if (result.Count > 0)
            {
                this.Hide();
                Book bookMenu = new Book(User, result);
                bookMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("We don't have this book at the moment, please try another one.");
            }
        }

		public Task GetBookInDataView(string isbn, int isbnLength)
		{
			return Task.Factory.StartNew(() =>
			{
				//ieskom knygos su isbn
				//	bookdata = SQLConnection.SelectQuery("SELECT * FROM Books WHERE ISBN" + isbnLength + " = '" + isbn + "';");
				SQLConnection.AddISBNToHistory(User.Id, isbn);

				DataTable bookData = GetAllBooksInDataTable();

				var bookInformation = from book in bookData.AsEnumerable() where book.Field<string>("ISBN" + isbnLength) == isbn select book;

				result = bookInformation.AsDataView();
			});
		}



		private void ScanButton_Click(object sender, EventArgs e)
		{
			//skenuoja knygos barcode tuo metu, jei jo nepagauna, nemeta jokio erroro ir reik spaust vel
			try
			{
                Result result;
                Deleg res = new Deleg(ScanClick);
                result = res();
                //instantiate'inam delegata naudodami anonymous method'a
                Check<int, string> ch1013 = new Check<int, string>(Check1013);
                //iskvieciam delegata
                ch1013(result.Text.Length, result.Text);

            }
			catch (MessagingToolkit.Barcode.NotFoundException)
			{
				MessageBox.Show("Can't find barcode, please try again.");
			}
		}

        //delegatu metodai
        private Result ScanClick()
        {
            //Nuskenuojami barcodo duomenis ir gaunamas knygos isbn kodas.
            BarcodeDecoder Scanner = new BarcodeDecoder();
            Result result = Scanner.Decode(new Bitmap(BarcodeImageBox.Image));
            //Atidaromas tinklapis su informacija apie ieskoma knyga.(Tik kaip pavyzdys, vėliau bus pakeista).
            //System.Diagnostics.Process.Start("https://isbnsearch.org/isbn/" + result.Text);
            return result;
        }
        private Result BarcodeLoader()
        {
            //Atidaromas aplankas, kuriame yra barcode pavyzdziai ir pasirinkus barcod'a jis yra uzkraunamas.
            OpenFileDialog OD = new OpenFileDialog();
            OD.InitialDirectory = System.IO.Directory.GetParent(@"../../../ ").FullName + @"\Barcode Images";
            if (OD.ShowDialog() == DialogResult.OK)
                BarcodeImageBox.Load(OD.FileName);

            //Nuskenuojami barcodo duomenis ir gaunamas knygos isbn kodas.
            BarcodeDecoder Scanner = new BarcodeDecoder();
            Result result = Scanner.Decode(new Bitmap(BarcodeImageBox.Image));

            return result;
        }
        private void Check1013(int length, string text)
        {
            if (length == 13)
            {
                CheckISBN(text, 13);
            }
            else if (length == 10)
            {
                CheckISBN(text, 10);
            }
            else
            {
                MessageBox.Show("Wrong ISBN, please try again.");
            }
        }

        private void CameraResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			myCamera.Start(CameraResolutionComboBox.SelectedIndex);
		}

		private void CameraScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			myCamera.Stop();
		}

		private void Back1_Click(object sender, EventArgs e)
		{
            myCamera.Stop();
            this.Close();
		}
	}
}