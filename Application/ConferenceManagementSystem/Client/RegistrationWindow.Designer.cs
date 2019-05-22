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
            this.firstNameTextBox.Location = new System.Drawing.Point(160, 31);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(21, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(88, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(140, 466);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(84, 36);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 20);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(160, 78);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(21, 130);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(45, 20);
            this.cnpLabel.TabIndex = 6;
            this.cnpLabel.Text = "CNP:";
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(160, 126);
            this.cnpTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(216, 26);
            this.cnpTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 252);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(160, 249);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(216, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(21, 298);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(160, 294);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(216, 26);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(21, 346);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // retypePasswordLabel
            // 
            this.retypePasswordLabel.AutoSize = true;
            this.retypePasswordLabel.Location = new System.Drawing.Point(21, 395);
            this.retypePasswordLabel.Name = "retypePasswordLabel";
            this.retypePasswordLabel.Size = new System.Drawing.Size(132, 20);
            this.retypePasswordLabel.TabIndex = 12;
            this.retypePasswordLabel.Text = "Retype password";
            // 
            // retypePasswordTextBox
            // 
            this.retypePasswordTextBox.Location = new System.Drawing.Point(160, 391);
            this.retypePasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.retypePasswordTextBox.Name = "retypePasswordTextBox";
            this.retypePasswordTextBox.PasswordChar = '*';
            this.retypePasswordTextBox.Size = new System.Drawing.Size(216, 26);
            this.retypePasswordTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(160, 342);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 26);
            this.passwordTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Website:";
            // 
            // WebsiteTextBox
            // 
            this.WebsiteTextBox.Location = new System.Drawing.Point(160, 208);
            this.WebsiteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WebsiteTextBox.Name = "WebsiteTextBox";
            this.WebsiteTextBox.Size = new System.Drawing.Size(216, 26);
            this.WebsiteTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Affiliation:";
            // 
            // AffiliationTextBox
            // 
            this.AffiliationTextBox.Location = new System.Drawing.Point(160, 168);
            this.AffiliationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AffiliationTextBox.Name = "AffiliationTextBox";
            this.AffiliationTextBox.Size = new System.Drawing.Size(216, 26);
            this.AffiliationTextBox.TabIndex = 13;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 561);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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