namespace Client
{
    partial class AuthorMainWindow
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
            this.persInfoLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.conferencesDGV = new System.Windows.Forms.DataGridView();
            this.sectionsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(96, 36);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // persInfoLabel
            // 
            this.persInfoLabel.AutoSize = true;
            this.persInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.persInfoLabel.Name = "persInfoLabel";
            this.persInfoLabel.Size = new System.Drawing.Size(142, 17);
            this.persInfoLabel.TabIndex = 1;
            this.persInfoLabel.Text = "Personal information:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(78, 17);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(78, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(96, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(93, 98);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(46, 17);
            this.cnpLabel.TabIndex = 5;
            this.cnpLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CNP:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(12, 118);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(100, 33);
            this.btnUpdateInfo.TabIndex = 7;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // conferencesDGV
            // 
            this.conferencesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conferencesDGV.Location = new System.Drawing.Point(463, 12);
            this.conferencesDGV.Name = "conferencesDGV";
            this.conferencesDGV.RowTemplate.Height = 24;
            this.conferencesDGV.Size = new System.Drawing.Size(325, 150);
            this.conferencesDGV.TabIndex = 8;
            this.conferencesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conferencesDGV_CellClick);
            // 
            // sectionsDGV
            // 
            this.sectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDGV.Location = new System.Drawing.Point(463, 168);
            this.sectionsDGV.Name = "sectionsDGV";
            this.sectionsDGV.RowTemplate.Height = 24;
            this.sectionsDGV.Size = new System.Drawing.Size(325, 150);
            this.sectionsDGV.TabIndex = 9;
            // 
            // AuthorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sectionsDGV);
            this.Controls.Add(this.conferencesDGV);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.persInfoLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "AuthorMainWindow";
            this.Text = "AuthorMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label persInfoLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.DataGridView conferencesDGV;
        private System.Windows.Forms.DataGridView sectionsDGV;
    }
}