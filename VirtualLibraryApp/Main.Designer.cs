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
            this.lastSearchesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CameraScanButton
            // 
            this.CameraScanButton.BackColor = System.Drawing.Color.Gold;
            this.CameraScanButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraScanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CameraScanButton.Location = new System.Drawing.Point(537, 357);
            this.CameraScanButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CameraScanButton.Name = "CameraScanButton";
            this.CameraScanButton.Size = new System.Drawing.Size(374, 163);
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
            this.AddBook.Location = new System.Drawing.Point(537, 634);
            this.AddBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(374, 163);
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
            this.lastSearchesButton.Location = new System.Drawing.Point(537, 90);
            this.lastSearchesButton.Margin = new System.Windows.Forms.Padding(5);
            this.lastSearchesButton.Name = "lastSearchesButton";
            this.lastSearchesButton.Size = new System.Drawing.Size(374, 163);
            this.lastSearchesButton.TabIndex = 2;
            this.lastSearchesButton.Text = "Last Searches";
            this.lastSearchesButton.UseVisualStyleBackColor = false;
            this.lastSearchesButton.Click += new System.EventHandler(this.lastSearchesButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1491, 912);
            this.Controls.Add(this.lastSearchesButton);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.CameraScanButton);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Library App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CameraScanButton;
		private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button lastSearchesButton;
    }
}