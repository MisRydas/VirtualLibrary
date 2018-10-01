namespace VirtualLibraryApp
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SignInButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(49, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Virtual Library";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(435, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(439, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordTextBox.Location = new System.Drawing.Point(552, 253);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '•';
			this.PasswordTextBox.Size = new System.Drawing.Size(231, 29);
			this.PasswordTextBox.TabIndex = 4;
			this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UsernameTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameTextBox.Location = new System.Drawing.Point(552, 199);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(231, 29);
			this.UsernameTextBox.TabIndex = 6;
			this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(69, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(290, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Find Your New Favorite Book";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// SignInButton
			// 
			this.SignInButton.BackColor = System.Drawing.Color.Gold;
			this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.SignInButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SignInButton.Location = new System.Drawing.Point(455, 309);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(328, 52);
			this.SignInButton.TabIndex = 5;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.UseVisualStyleBackColor = false;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(23, 126);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(389, 347);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 503);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.SignInButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button SignInButton;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}