using System;
using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.Barcode;


namespace VirtualLibraryApp
{
	public partial class Camera : Form
	{
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
			OD.InitialDirectory = System.IO.Directory.GetParent(@"../ ").FullName + @"\Barcode Images";
			if (OD.ShowDialog() == DialogResult.OK)
				BarcodeImageBox.Load(OD.FileName);
			//Nuskenuojami barcodo duomenis ir gaunamas knygos isbn kodas.
			BarcodeDecoder Scanner = new BarcodeDecoder();
			Result result = Scanner.Decode(new Bitmap(BarcodeImageBox.Image));
			//Atidaromas tinklapis su informacija apie ieskoma knyga.(Tik kaip pavyzdys, vėliau bus pakeista).
			System.Diagnostics.Process.Start("https://isbnsearch.org/isbn/" + result.Text);
            SQLConnection.AddISBNToHistory(User.Id, result.Text);
		}
	}
}
