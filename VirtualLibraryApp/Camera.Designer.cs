namespace VirtualLibraryApp
{
	partial class Camera
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoadBarcodeButton = new System.Windows.Forms.Button();
			this.BarcodeImageBox = new System.Windows.Forms.PictureBox();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BarcodeImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// LoadBarcodeButton
			// 
			this.LoadBarcodeButton.BackColor = System.Drawing.Color.Gold;
			this.LoadBarcodeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadBarcodeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LoadBarcodeButton.Location = new System.Drawing.Point(327, 410);
			this.LoadBarcodeButton.Name = "LoadBarcodeButton";
			this.LoadBarcodeButton.Size = new System.Drawing.Size(210, 67);
			this.LoadBarcodeButton.TabIndex = 1;
			this.LoadBarcodeButton.Text = "Load Barcode";
			this.LoadBarcodeButton.UseVisualStyleBackColor = false;
			this.LoadBarcodeButton.Click += new System.EventHandler(this.LoadBarcodeButton_Click);
			// 
			// BarcodeImageBox
			// 
			this.BarcodeImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BarcodeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BarcodeImageBox.Location = new System.Drawing.Point(126, 36);
			this.BarcodeImageBox.Name = "BarcodeImageBox";
			this.BarcodeImageBox.Size = new System.Drawing.Size(599, 350);
			this.BarcodeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BarcodeImageBox.TabIndex = 0;
			this.BarcodeImageBox.TabStop = false;
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.Gold;
			this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Back.Location = new System.Drawing.Point(12, 12);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(92, 54);
			this.Back.TabIndex = 23;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Camera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.LoadBarcodeButton);
			this.Controls.Add(this.BarcodeImageBox);
			this.Name = "Camera";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Camera";
			((System.ComponentModel.ISupportInitialize)(this.BarcodeImageBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox BarcodeImageBox;
		private System.Windows.Forms.Button LoadBarcodeButton;
		private System.Windows.Forms.Button Back;
	}
}