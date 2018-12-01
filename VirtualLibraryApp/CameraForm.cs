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

    public partial class CameraForm : Form, IScanner
	{
		public event Action ButtonPressed;

		public Image BookImage => BarcodeImageBox.Image;

		Camera myCamera = new Camera();



        public CameraForm()
		{
			InitializeComponent();

			GetInfo();			
			myCamera.OnFrameArrived += myCamera_OnFrameArrived;
		}

		private void ScanButton_Click(object sender, EventArgs e)
		{
			ButtonPressed();
		//	System.Threading.Thread.Sleep(500);
		}

		public void OnBookFound(DataView bookData)
		{
			Navigation.OpenBookMenu(this, bookData, 0);
		}

		public void OnError(string message)
		{
			MessageBox.Show(message);
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