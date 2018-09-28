namespace VirtualLibraryApp
{
	partial class Main
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
			this.CameraScanButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CameraScanButton
			// 
			this.CameraScanButton.Location = new System.Drawing.Point(269, 177);
			this.CameraScanButton.Name = "CameraScanButton";
			this.CameraScanButton.Size = new System.Drawing.Size(214, 90);
			this.CameraScanButton.TabIndex = 0;
			this.CameraScanButton.Text = "Scan Book";
			this.CameraScanButton.UseVisualStyleBackColor = true;
			this.CameraScanButton.Click += new System.EventHandler(this.CameraScanButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CameraScanButton);
			this.Name = "Main";
			this.Text = "Virtual Library App";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CameraScanButton;
	}
}