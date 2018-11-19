using System;
using System.Data;
using System.Drawing;
using Logic;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using DarrenLee.Media;
using System.Threading.Tasks;

namespace VirtualLibraryApp
{

    public partial class CameraForm : Form
	{
		private Scanner scanner = new Scanner();
		private ScannerDataProvider scannerData = new ScannerDataProvider();
		public User user;
		Camera myCamera = new Camera();

        public CameraForm(User user)
		{
			this.user = user;
			InitializeComponent();

			GetInfo();			
			myCamera.OnFrameArrived += myCamera_OnFrameArrived;
		}

		private void ScanButton_Click(object sender, EventArgs e)
		{
			scanner.ScanBook(BarcodeImageBox.Image, scannerData, user);
			System.Threading.Thread.Sleep(500);

			if (scannerData.wrongCode)
			{
				MessageBox.Show("Wrong ISBN, please try again.");
			}
			else if(scannerData.bookNotFound)
			{
				MessageBox.Show("We don't have this book at the moment, please try another one.");
			}
			else if(scannerData.barcodeNotFound)
			{
				MessageBox.Show("Barcode wasn't found.");
			}
			else
			{
				if (scannerData.bookData != null)
				{
					Navigation.OpenBookMenu(this, user, scannerData.bookData);
				}
				else
				{
					MessageBox.Show("Error");
				}
			}
		}

		private void Back1_Click(object sender, EventArgs e)
		{
			myCamera.Stop();
			this.Close();
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
			BarcodeImageBox.Image = e.GetFrame();
		}

		private void CameraResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			myCamera.Start(CameraResolutionComboBox.SelectedIndex);
		}

		private void CameraScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			myCamera.Stop();
		}
	}
}