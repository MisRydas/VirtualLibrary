namespace VirtualLibraryApp
{
    partial class RegistrationForm
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
            this.firstName = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(558, 176);
            this.firstName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(131, 29);
            this.firstName.TabIndex = 7;
            this.firstName.Text = "First Name";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.Gold;
            this.createAccountButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createAccountButton.Location = new System.Drawing.Point(525, 580);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(425, 127);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create an Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(742, 170);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(228, 35);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(742, 228);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(228, 35);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(558, 234);
            this.lastName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(128, 29);
            this.lastName.TabIndex = 8;
            this.lastName.Text = "Last Name";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(742, 384);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(228, 35);
            this.usernameTextBox.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(558, 390);
            this.username.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 29);
            this.username.TabIndex = 9;
            this.username.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(742, 442);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(228, 35);
            this.passwordTextBox.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(569, 448);
            this.password.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 29);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(742, 500);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(228, 35);
            this.confirmPasswordTextBox.TabIndex = 4;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(478, 506);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(210, 29);
            this.confirmPassword.TabIndex = 11;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(702, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(702, 448);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(702, 506);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(702, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(702, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "*";
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
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RegistrationWindow
            // 
            this.AcceptButton = this.createAccountButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 897);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.firstName);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Back;
	}
}