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
			this.AddBook = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CameraScanButton
			// 
			this.CameraScanButton.BackColor = System.Drawing.Color.Gold;
			this.CameraScanButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CameraScanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CameraScanButton.Location = new System.Drawing.Point(307, 197);
			this.CameraScanButton.Name = "CameraScanButton";
			this.CameraScanButton.Size = new System.Drawing.Size(214, 90);
			this.CameraScanButton.TabIndex = 0;
			this.CameraScanButton.Text = "Scan ISBN";
			this.CameraScanButton.UseVisualStyleBackColor = false;
			this.CameraScanButton.Click += new System.EventHandler(this.CameraScanButton_Click);
			// 
			// AddBook
			// 
			this.AddBook.BackColor = System.Drawing.Color.Gold;
			this.AddBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddBook.Location = new System.Drawing.Point(307, 350);
			this.AddBook.Name = "AddBook";
			this.AddBook.Size = new System.Drawing.Size(214, 90);
			this.AddBook.TabIndex = 1;
			this.AddBook.Text = "Add Book";
			this.AddBook.UseVisualStyleBackColor = false;
			this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.AddBook);
			this.Controls.Add(this.CameraScanButton);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Virtual Library App";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CameraScanButton;
		private System.Windows.Forms.Button AddBook;
	}
}