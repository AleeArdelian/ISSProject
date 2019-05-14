namespace Client
{
    partial class RegistrationWindow
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.retypePasswordLabel = new System.Windows.Forms.Label();
            this.retypePasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebsiteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AffiliationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(142, 25);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(78, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(124, 373);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 29);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(78, 17);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(142, 62);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(19, 104);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(40, 17);
            this.cnpLabel.TabIndex = 6;
            this.cnpLabel.Text = "CNP:";
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(142, 101);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(192, 22);
            this.cnpTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 199);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(142, 196);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(192, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(19, 238);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(142, 235);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(192, 22);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(19, 277);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // retypePasswordLabel
            // 
            this.retypePasswordLabel.AutoSize = true;
            this.retypePasswordLabel.Location = new System.Drawing.Point(19, 316);
            this.retypePasswordLabel.Name = "retypePasswordLabel";
            this.retypePasswordLabel.Size = new System.Drawing.Size(117, 17);
            this.retypePasswordLabel.TabIndex = 12;
            this.retypePasswordLabel.Text = "Retype password";
            // 
            // retypePasswordTextBox
            // 
            this.retypePasswordTextBox.Location = new System.Drawing.Point(142, 313);
            this.retypePasswordTextBox.Name = "retypePasswordTextBox";
            this.retypePasswordTextBox.PasswordChar = '*';
            this.retypePasswordTextBox.Size = new System.Drawing.Size(192, 22);
            this.retypePasswordTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(142, 274);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(192, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Website:";
            // 
            // WebsiteTextBox
            // 
            this.WebsiteTextBox.Location = new System.Drawing.Point(142, 166);
            this.WebsiteTextBox.Name = "WebsiteTextBox";
            this.WebsiteTextBox.Size = new System.Drawing.Size(192, 22);
            this.WebsiteTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Affiliation:";
            // 
            // AffiliationTextBox
            // 
            this.AffiliationTextBox.Location = new System.Drawing.Point(142, 134);
            this.AffiliationTextBox.Name = "AffiliationTextBox";
            this.AffiliationTextBox.Size = new System.Drawing.Size(192, 22);
            this.AffiliationTextBox.TabIndex = 13;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebsiteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AffiliationTextBox);
            this.Controls.Add(this.retypePasswordLabel);
            this.Controls.Add(this.retypePasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "RegistrationWindow";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label retypePasswordLabel;
        private System.Windows.Forms.TextBox retypePasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WebsiteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AffiliationTextBox;
    }
}