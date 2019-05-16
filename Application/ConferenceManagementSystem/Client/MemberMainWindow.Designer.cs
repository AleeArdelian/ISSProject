namespace Client
{
    partial class MemberMainWindow
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
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.affiliationLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbaCnpLabel = new System.Windows.Forms.Label();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.conferencesDGV = new System.Windows.Forms.DataGridView();
            this.sectionsDGV = new System.Windows.Forms.DataGridView();
            this.papersDGV = new System.Windows.Forms.DataGridView();
            this.panelUploadPaper = new System.Windows.Forms.Panel();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(142, 17);
            this.personalInfoLabel.TabIndex = 0;
            this.personalInfoLabel.Text = "Personal information:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // affiliationLabel
            // 
            this.affiliationLabel.AutoSize = true;
            this.affiliationLabel.Location = new System.Drawing.Point(12, 91);
            this.affiliationLabel.Name = "affiliationLabel";
            this.affiliationLabel.Size = new System.Drawing.Size(69, 17);
            this.affiliationLabel.TabIndex = 4;
            this.affiliationLabel.Text = "Affiliation:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // tbaCnpLabel
            // 
            this.tbaCnpLabel.AutoSize = true;
            this.tbaCnpLabel.Location = new System.Drawing.Point(58, 121);
            this.tbaCnpLabel.Name = "tbaCnpLabel";
            this.tbaCnpLabel.Size = new System.Drawing.Size(35, 17);
            this.tbaCnpLabel.TabIndex = 7;
            this.tbaCnpLabel.Text = "TBA";
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(12, 121);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(40, 17);
            this.cnpLabel.TabIndex = 8;
            this.cnpLabel.Text = "CNP:";
            // 
            // conferencesDGV
            // 
            this.conferencesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conferencesDGV.Location = new System.Drawing.Point(758, 12);
            this.conferencesDGV.Name = "conferencesDGV";
            this.conferencesDGV.RowTemplate.Height = 24;
            this.conferencesDGV.Size = new System.Drawing.Size(314, 214);
            this.conferencesDGV.TabIndex = 9;
            this.conferencesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sectionsDGV
            // 
            this.sectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDGV.Location = new System.Drawing.Point(758, 232);
            this.sectionsDGV.Name = "sectionsDGV";
            this.sectionsDGV.RowTemplate.Height = 24;
            this.sectionsDGV.Size = new System.Drawing.Size(314, 214);
            this.sectionsDGV.TabIndex = 10;
            this.sectionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // papersDGV
            // 
            this.papersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.papersDGV.Location = new System.Drawing.Point(758, 452);
            this.papersDGV.Name = "papersDGV";
            this.papersDGV.RowTemplate.Height = 24;
            this.papersDGV.Size = new System.Drawing.Size(314, 214);
            this.papersDGV.TabIndex = 11;
            // 
            // panelUploadPaper
            // 
            this.panelUploadPaper.Location = new System.Drawing.Point(12, 178);
            this.panelUploadPaper.Name = "panelUploadPaper";
            this.panelUploadPaper.Size = new System.Drawing.Size(740, 488);
            this.panelUploadPaper.TabIndex = 12;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(12, 141);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(93, 31);
            this.btnUpdateInfo.TabIndex = 13;
            this.btnUpdateInfo.Text = "Update info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(111, 141);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(104, 31);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload paper";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // MemberMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 671);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.panelUploadPaper);
            this.Controls.Add(this.papersDGV);
            this.Controls.Add(this.sectionsDGV);
            this.Controls.Add(this.conferencesDGV);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.tbaCnpLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.affiliationLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.personalInfoLabel);
            this.Name = "MemberMainWindow";
            this.Text = "MemberMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label affiliationLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label tbaCnpLabel;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.DataGridView conferencesDGV;
        private System.Windows.Forms.DataGridView sectionsDGV;
        private System.Windows.Forms.DataGridView papersDGV;
        private System.Windows.Forms.Panel panelUploadPaper;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnUpload;
    }
}