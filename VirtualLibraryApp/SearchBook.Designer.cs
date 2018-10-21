namespace VirtualLibraryApp
{
	partial class SearchBook
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
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.BooksGroup = new System.Windows.Forms.GroupBox();
			this.BookName = new System.Windows.Forms.LinkLabel();
			this.BookCover = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.BooksGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchTextBox.Location = new System.Drawing.Point(182, 48);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(370, 36);
			this.SearchTextBox.TabIndex = 0;
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(579, 47);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(126, 36);
			this.SearchButton.TabIndex = 1;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// BooksGroup
			// 
			this.BooksGroup.Controls.Add(this.panel1);
			this.BooksGroup.Location = new System.Drawing.Point(23, 112);
			this.BooksGroup.Name = "BooksGroup";
			this.BooksGroup.Size = new System.Drawing.Size(800, 362);
			this.BooksGroup.TabIndex = 2;
			this.BooksGroup.TabStop = false;
			this.BooksGroup.Text = "Books";
			// 
			// BookName
			// 
			this.BookName.AutoSize = true;
			this.BookName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookName.LinkColor = System.Drawing.Color.Black;
			this.BookName.Location = new System.Drawing.Point(148, 8);
			this.BookName.Name = "BookName";
			this.BookName.Size = new System.Drawing.Size(140, 35);
			this.BookName.TabIndex = 1;
			this.BookName.TabStop = true;
			this.BookName.Text = "BookName";
			this.BookName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookName_LinkClicked);
			// 
			// BookCover
			// 
			this.BookCover.Location = new System.Drawing.Point(18, 8);
			this.BookCover.Name = "BookCover";
			this.BookCover.Size = new System.Drawing.Size(115, 150);
			this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BookCover.TabIndex = 0;
			this.BookCover.TabStop = false;
			this.BookCover.Click += new System.EventHandler(this.BookCover_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.BookName);
			this.panel1.Controls.Add(this.BookCover);
			this.panel1.Location = new System.Drawing.Point(6, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(788, 335);
			this.panel1.TabIndex = 2;
			// 
			// SearchBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.BooksGroup);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchTextBox);
			this.Name = "SearchBook";
			this.Text = "SearchBook";
			this.BooksGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.GroupBox BooksGroup;
		private System.Windows.Forms.PictureBox BookCover;
		private System.Windows.Forms.LinkLabel BookName;
		private System.Windows.Forms.Panel panel1;
	}
}