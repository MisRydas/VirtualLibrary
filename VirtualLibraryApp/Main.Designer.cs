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
			this.SearchBook = new System.Windows.Forms.Button();
			this.CameraScanButton = new System.Windows.Forms.Button();
			this.AddBook = new System.Windows.Forms.Button();
			this.lastSearchesButton = new System.Windows.Forms.Button();
			this.LogOut = new System.Windows.Forms.Button();
			this.MissingBooks = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SearchBook
			// 
			this.SearchBook.BackColor = System.Drawing.Color.Gold;
			this.SearchBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SearchBook.Location = new System.Drawing.Point(320, 203);
			this.SearchBook.Margin = new System.Windows.Forms.Padding(2);
			this.SearchBook.Name = "SearchBook";
			this.SearchBook.Size = new System.Drawing.Size(214, 90);
			this.SearchBook.TabIndex = 1;
			this.SearchBook.Text = "Search Book";
			this.SearchBook.UseVisualStyleBackColor = false;
			this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
			// 
			// CameraScanButton
			// 
			this.CameraScanButton.BackColor = System.Drawing.Color.Gold;
			this.CameraScanButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CameraScanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CameraScanButton.Location = new System.Drawing.Point(320, 12);
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
			this.AddBook.Location = new System.Drawing.Point(320, 298);
			this.AddBook.Name = "AddBook";
			this.AddBook.Size = new System.Drawing.Size(214, 90);
			this.AddBook.TabIndex = 1;
			this.AddBook.Text = "Add Book";
			this.AddBook.UseVisualStyleBackColor = false;
			this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
			// 
			// lastSearchesButton
			// 
			this.lastSearchesButton.BackColor = System.Drawing.Color.Gold;
			this.lastSearchesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastSearchesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lastSearchesButton.Location = new System.Drawing.Point(320, 108);
			this.lastSearchesButton.Name = "lastSearchesButton";
			this.lastSearchesButton.Size = new System.Drawing.Size(214, 90);
			this.lastSearchesButton.TabIndex = 2;
			this.lastSearchesButton.Text = "Last Searches";
			this.lastSearchesButton.UseVisualStyleBackColor = false;
			this.lastSearchesButton.Click += new System.EventHandler(this.lastSearchesButton_Click);
			// 
			// LogOut
			// 
			this.LogOut.BackColor = System.Drawing.Color.Gold;
			this.LogOut.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LogOut.Location = new System.Drawing.Point(12, 12);
			this.LogOut.Name = "LogOut";
			this.LogOut.Size = new System.Drawing.Size(130, 54);
			this.LogOut.TabIndex = 24;
			this.LogOut.Text = "Log Out";
			this.LogOut.UseVisualStyleBackColor = false;
			this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
			// 
			// MissingBooks
			// 
			this.MissingBooks.BackColor = System.Drawing.Color.Gold;
			this.MissingBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MissingBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MissingBooks.Location = new System.Drawing.Point(320, 394);
			this.MissingBooks.Name = "MissingBooks";
			this.MissingBooks.Size = new System.Drawing.Size(214, 90);
			this.MissingBooks.TabIndex = 25;
			this.MissingBooks.Text = "Missing Books";
			this.MissingBooks.UseVisualStyleBackColor = false;
			this.MissingBooks.Click += new System.EventHandler(this.MissingBooks_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.MissingBooks);
			this.Controls.Add(this.LogOut);
			this.Controls.Add(this.SearchBook);
			this.Controls.Add(this.lastSearchesButton);
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
		private System.Windows.Forms.Button SearchBook;
		private System.Windows.Forms.Button AddBook;
    private System.Windows.Forms.Button lastSearchesButton;
		private System.Windows.Forms.Button LogOut;
		private System.Windows.Forms.Button MissingBooks;
	}
}