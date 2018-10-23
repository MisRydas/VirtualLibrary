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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.BookCoverBox = new System.Windows.Forms.PictureBox();
			this.BookName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ISBN13 = new System.Windows.Forms.Label();
			this.ISBN10 = new System.Windows.Forms.Label();
			this.Author = new System.Windows.Forms.Label();
			this.Publisher = new System.Windows.Forms.Label();
			this.Published = new System.Windows.Forms.Label();
			this.ListPrice = new System.Windows.Forms.Label();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BookCoverBox)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// BookCoverBox
			// 
			this.BookCoverBox.Enabled = false;
			this.BookCoverBox.Location = new System.Drawing.Point(12, 83);
			this.BookCoverBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BookCoverBox.Name = "BookCoverBox";
			this.BookCoverBox.Size = new System.Drawing.Size(200, 260);
			this.BookCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BookCoverBox.TabIndex = 1;
			this.BookCoverBox.TabStop = false;
			// 
			// BookName
			// 
			this.BookName.AutoSize = true;
			this.BookName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BookName.Location = new System.Drawing.Point(232, 83);
			this.BookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.BookName.Name = "BookName";
			this.BookName.Size = new System.Drawing.Size(158, 37);
			this.BookName.TabIndex = 9;
			this.BookName.Text = "Book Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(232, 133);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "ISBN-13: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(232, 163);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "ISBN-10: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(232, 193);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 24);
			this.label3.TabIndex = 12;
			this.label3.Text = "Author: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(232, 223);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Publisher: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(232, 253);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 24);
			this.label5.TabIndex = 14;
			this.label5.Text = "Published: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(232, 283);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "List Price: ";
			// 
			// ISBN13
			// 
			this.ISBN13.AutoSize = true;
			this.ISBN13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBN13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ISBN13.Location = new System.Drawing.Point(312, 133);
			this.ISBN13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ISBN13.Name = "ISBN13";
			this.ISBN13.Size = new System.Drawing.Size(52, 24);
			this.ISBN13.TabIndex = 16;
			this.ISBN13.Text = "NULL";
			// 
			// ISBN10
			// 
			this.ISBN10.AutoSize = true;
			this.ISBN10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBN10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ISBN10.Location = new System.Drawing.Point(312, 163);
			this.ISBN10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ISBN10.Name = "ISBN10";
			this.ISBN10.Size = new System.Drawing.Size(52, 24);
			this.ISBN10.TabIndex = 17;
			this.ISBN10.Text = "NULL";
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Author.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Author.Location = new System.Drawing.Point(307, 193);
			this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(52, 24);
			this.Author.TabIndex = 18;
			this.Author.Text = "NULL";
			// 
			// Publisher
			// 
			this.Publisher.AutoSize = true;
			this.Publisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Publisher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Publisher.Location = new System.Drawing.Point(327, 223);
			this.Publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Publisher.Name = "Publisher";
			this.Publisher.Size = new System.Drawing.Size(52, 24);
			this.Publisher.TabIndex = 19;
			this.Publisher.Text = "NULL";
			// 
			// Published
			// 
			this.Published.AutoSize = true;
			this.Published.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Published.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Published.Location = new System.Drawing.Point(332, 253);
			this.Published.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Published.Name = "Published";
			this.Published.Size = new System.Drawing.Size(52, 24);
			this.Published.TabIndex = 20;
			this.Published.Text = "NULL";
			// 
			// ListPrice
			// 
			this.ListPrice.AutoSize = true;
			this.ListPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ListPrice.Location = new System.Drawing.Point(322, 283);
			this.ListPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ListPrice.Name = "ListPrice";
			this.ListPrice.Size = new System.Drawing.Size(52, 24);
			this.ListPrice.TabIndex = 21;
			this.ListPrice.Text = "NULL";
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.Gold;
			this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Back.Location = new System.Drawing.Point(12, 12);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(92, 54);
			this.Back.TabIndex = 22;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Book
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.ListPrice);
			this.Controls.Add(this.Published);
			this.Controls.Add(this.Publisher);
			this.Controls.Add(this.Author);
			this.Controls.Add(this.ISBN10);
			this.Controls.Add(this.ISBN13);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BookName);
			this.Controls.Add(this.BookCoverBox);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Book";
			this.Text = "Book";
			((System.ComponentModel.ISupportInitialize)(this.BookCoverBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.PictureBox BookCoverBox;
		private System.Windows.Forms.Label BookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label ISBN13;
		private System.Windows.Forms.Label ISBN10;
		private System.Windows.Forms.Label Author;
		private System.Windows.Forms.Label Publisher;
		private System.Windows.Forms.Label Published;
		private System.Windows.Forms.Label ListPrice;
		private System.Windows.Forms.Button Back;
	}
}