namespace VirtualLibraryApp
{
	partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            this.ISBN13Box = new System.Windows.Forms.TextBox();
            this.ISBN10Box = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.PublishedBox = new System.Windows.Forms.TextBox();
            this.ListPriceBox = new System.Windows.Forms.TextBox();
            this.BookCoverLinkBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN-13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN-10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 478);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Published";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 542);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "List Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(404, 616);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 44);
            this.label9.TabIndex = 8;
            this.label9.Text = "Book Cover Link";
            // 
            // BookNameBox
            // 
            this.BookNameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameBox.Location = new System.Drawing.Point(665, 62);
            this.BookNameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(354, 51);
            this.BookNameBox.TabIndex = 9;
            // 
            // ISBN13Box
            // 
            this.ISBN13Box.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN13Box.Location = new System.Drawing.Point(665, 130);
            this.ISBN13Box.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ISBN13Box.Name = "ISBN13Box";
            this.ISBN13Box.Size = new System.Drawing.Size(354, 51);
            this.ISBN13Box.TabIndex = 10;
            // 
            // ISBN10Box
            // 
            this.ISBN10Box.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN10Box.Location = new System.Drawing.Point(665, 198);
            this.ISBN10Box.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ISBN10Box.Name = "ISBN10Box";
            this.ISBN10Box.Size = new System.Drawing.Size(354, 51);
            this.ISBN10Box.TabIndex = 11;
            // 
            // AuthorBox
            // 
            this.AuthorBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorBox.Location = new System.Drawing.Point(665, 266);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(354, 51);
            this.AuthorBox.TabIndex = 12;
            // 
            // PublisherBox
            // 
            this.PublisherBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherBox.Location = new System.Drawing.Point(665, 404);
            this.PublisherBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(354, 51);
            this.PublisherBox.TabIndex = 13;
            // 
            // PublishedBox
            // 
            this.PublishedBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishedBox.Location = new System.Drawing.Point(665, 473);
            this.PublishedBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PublishedBox.Name = "PublishedBox";
            this.PublishedBox.Size = new System.Drawing.Size(354, 51);
            this.PublishedBox.TabIndex = 14;
            // 
            // ListPriceBox
            // 
            this.ListPriceBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPriceBox.Location = new System.Drawing.Point(665, 542);
            this.ListPriceBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ListPriceBox.Name = "ListPriceBox";
            this.ListPriceBox.Size = new System.Drawing.Size(354, 51);
            this.ListPriceBox.TabIndex = 15;
            // 
            // BookCoverLinkBox
            // 
            this.BookCoverLinkBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCoverLinkBox.Location = new System.Drawing.Point(665, 611);
            this.BookCoverLinkBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BookCoverLinkBox.Name = "BookCoverLinkBox";
            this.BookCoverLinkBox.Size = new System.Drawing.Size(354, 51);
            this.BookCoverLinkBox.TabIndex = 16;
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Gold;
            this.AddBookButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBookButton.Location = new System.Drawing.Point(532, 701);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(385, 127);
            this.AddBookButton.TabIndex = 17;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gold;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(21, 22);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(161, 98);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreBox.Location = new System.Drawing.Point(665, 335);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(354, 51);
            this.GenreBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 44);
            this.label4.TabIndex = 19;
            this.label4.Text = "Genre";
            // 
            // AddBook
            // 
            this.AcceptButton = this.AddBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1491, 912);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.BookCoverLinkBox);
            this.Controls.Add(this.ListPriceBox);
            this.Controls.Add(this.PublishedBox);
            this.Controls.Add(this.PublisherBox);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.ISBN10Box);
            this.Controls.Add(this.ISBN13Box);
            this.Controls.Add(this.BookNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox BookNameBox;
		private System.Windows.Forms.TextBox ISBN13Box;
		private System.Windows.Forms.TextBox ISBN10Box;
		private System.Windows.Forms.TextBox AuthorBox;
		private System.Windows.Forms.TextBox PublisherBox;
		private System.Windows.Forms.TextBox PublishedBox;
		private System.Windows.Forms.TextBox ListPriceBox;
		private System.Windows.Forms.TextBox BookCoverLinkBox;
		private System.Windows.Forms.Button AddBookButton;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.TextBox GenreBox;
		private System.Windows.Forms.Label label4;
	}
}