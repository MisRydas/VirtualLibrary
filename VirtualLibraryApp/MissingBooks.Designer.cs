namespace VirtualLibraryApp
{
	partial class MissingBooks
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
			this.BooksGroup = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.BooksGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// BooksGroup
			// 
			this.BooksGroup.Controls.Add(this.panel1);
			this.BooksGroup.Location = new System.Drawing.Point(147, 65);
			this.BooksGroup.Name = "BooksGroup";
			this.BooksGroup.Size = new System.Drawing.Size(558, 362);
			this.BooksGroup.TabIndex = 3;
			this.BooksGroup.TabStop = false;
			this.BooksGroup.Text = "Missing Books";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(6, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(546, 335);
			this.panel1.TabIndex = 2;
			// 
			// MissingBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.BooksGroup);
			this.Name = "MissingBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MissingBooks";
			this.BooksGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox BooksGroup;
		private System.Windows.Forms.Panel panel1;
	}
}