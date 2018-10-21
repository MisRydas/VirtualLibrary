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
			this.SearchBook = new System.Windows.Forms.Button();
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
			// SearchBook
			// 
			this.SearchBook.BackColor = System.Drawing.Color.Gold;
			this.SearchBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SearchBook.Location = new System.Drawing.Point(307, 64);
			this.SearchBook.Name = "SearchBook";
			this.SearchBook.Size = new System.Drawing.Size(214, 90);
			this.SearchBook.TabIndex = 1;
			this.SearchBook.Text = "Search Book";
			this.SearchBook.UseVisualStyleBackColor = false;
			this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.SearchBook);
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
	}
}