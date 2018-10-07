namespace VirtualLibraryApp
{
	partial class Book
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
			this.ISBN13 = new System.Windows.Forms.Label();
			this.ISBN10 = new System.Windows.Forms.Label();
			this.Author = new System.Windows.Forms.Label();
			this.Publisher = new System.Windows.Forms.Label();
			this.Published = new System.Windows.Forms.Label();
			this.ListPrice = new System.Windows.Forms.Label();
			this.BookCoverBox = new System.Windows.Forms.PictureBox();
			this.BookName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BookCoverBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ISBN13
			// 
			this.ISBN13.AutoSize = true;
			this.ISBN13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBN13.Location = new System.Drawing.Point(285, 90);
			this.ISBN13.Name = "ISBN13";
			this.ISBN13.Size = new System.Drawing.Size(74, 24);
			this.ISBN13.TabIndex = 1;
			this.ISBN13.Text = "ISBN-13";
			// 
			// ISBN10
			// 
			this.ISBN10.AutoSize = true;
			this.ISBN10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBN10.Location = new System.Drawing.Point(285, 120);
			this.ISBN10.Name = "ISBN10";
			this.ISBN10.Size = new System.Drawing.Size(74, 24);
			this.ISBN10.TabIndex = 2;
			this.ISBN10.Text = "ISBN-10";
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Author.Location = new System.Drawing.Point(285, 150);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(69, 24);
			this.Author.TabIndex = 3;
			this.Author.Text = "Author";
			// 
			// Publisher
			// 
			this.Publisher.AutoSize = true;
			this.Publisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Publisher.Location = new System.Drawing.Point(285, 180);
			this.Publisher.Name = "Publisher";
			this.Publisher.Size = new System.Drawing.Size(89, 24);
			this.Publisher.TabIndex = 4;
			this.Publisher.Text = "Publisher";
			// 
			// Published
			// 
			this.Published.AutoSize = true;
			this.Published.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Published.Location = new System.Drawing.Point(285, 210);
			this.Published.Name = "Published";
			this.Published.Size = new System.Drawing.Size(93, 24);
			this.Published.TabIndex = 5;
			this.Published.Text = "Published";
			// 
			// ListPrice
			// 
			this.ListPrice.AutoSize = true;
			this.ListPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListPrice.Location = new System.Drawing.Point(285, 240);
			this.ListPrice.Name = "ListPrice";
			this.ListPrice.Size = new System.Drawing.Size(84, 24);
			this.ListPrice.TabIndex = 6;
			this.ListPrice.Text = "List Price";
			// 
			// BookCoverBox
			// 
			this.BookCoverBox.Location = new System.Drawing.Point(40, 40);
			this.BookCoverBox.Name = "BookCoverBox";
			this.BookCoverBox.Size = new System.Drawing.Size(211, 276);
			this.BookCoverBox.TabIndex = 0;
			this.BookCoverBox.TabStop = false;
			// 
			// BookName
			// 
			this.BookName.AutoSize = true;
			this.BookName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookName.Location = new System.Drawing.Point(285, 40);
			this.BookName.Name = "BookName";
			this.BookName.Size = new System.Drawing.Size(140, 35);
			this.BookName.TabIndex = 7;
			this.BookName.Text = "BookName";
			// 
			// Book
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.BookName);
			this.Controls.Add(this.ListPrice);
			this.Controls.Add(this.Published);
			this.Controls.Add(this.Publisher);
			this.Controls.Add(this.Author);
			this.Controls.Add(this.ISBN10);
			this.Controls.Add(this.ISBN13);
			this.Controls.Add(this.BookCoverBox);
			this.Name = "Book";
			this.Text = "Book";
			((System.ComponentModel.ISupportInitialize)(this.BookCoverBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox BookCoverBox;
		private System.Windows.Forms.Label ISBN13;
		private System.Windows.Forms.Label ISBN10;
		private System.Windows.Forms.Label Author;
		private System.Windows.Forms.Label Publisher;
		private System.Windows.Forms.Label Published;
		private System.Windows.Forms.Label ListPrice;
		private System.Windows.Forms.Label BookName;
	}
}