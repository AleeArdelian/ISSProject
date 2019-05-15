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
            this.absTextBox = new System.Windows.Forms.TextBox();
            this.contTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.Label();
            this.abstractTextBox = new System.Windows.Forms.Label();
            this.paperNameTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.paperNameLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.panelUploadPaper = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).BeginInit();
            this.panelUploadPaper.SuspendLayout();
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
            this.conferencesDGV.Location = new System.Drawing.Point(752, 9);
            this.conferencesDGV.Name = "conferencesDGV";
            this.conferencesDGV.RowTemplate.Height = 24;
            this.conferencesDGV.Size = new System.Drawing.Size(325, 150);
            this.conferencesDGV.TabIndex = 8;
            this.conferencesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conferencesDGV_CellClick);
            // 
            // sectionsDGV
            // 
            this.sectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDGV.Location = new System.Drawing.Point(752, 165);
            this.sectionsDGV.Name = "sectionsDGV";
            this.sectionsDGV.RowTemplate.Height = 24;
            this.sectionsDGV.Size = new System.Drawing.Size(325, 150);
            this.sectionsDGV.TabIndex = 9;
            // 
            // absTextBox
            // 
            this.absTextBox.Location = new System.Drawing.Point(8, 26);
            this.absTextBox.Multiline = true;
            this.absTextBox.Name = "absTextBox";
            this.absTextBox.Size = new System.Drawing.Size(264, 380);
            this.absTextBox.TabIndex = 10;
            // 
            // contTextBox
            // 
            this.contTextBox.Location = new System.Drawing.Point(278, 26);
            this.contTextBox.Multiline = true;
            this.contTextBox.Name = "contTextBox";
            this.contTextBox.Size = new System.Drawing.Size(264, 380);
            this.contTextBox.TabIndex = 11;
            // 
            // contentTextBox
            // 
            this.contentTextBox.AutoSize = true;
            this.contentTextBox.Location = new System.Drawing.Point(378, 6);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(59, 17);
            this.contentTextBox.TabIndex = 12;
            this.contentTextBox.Text = "content:";
            // 
            // abstractTextBox
            // 
            this.abstractTextBox.AutoSize = true;
            this.abstractTextBox.Location = new System.Drawing.Point(104, 6);
            this.abstractTextBox.Name = "abstractTextBox";
            this.abstractTextBox.Size = new System.Drawing.Size(63, 17);
            this.abstractTextBox.TabIndex = 13;
            this.abstractTextBox.Text = "abstract:";
            // 
            // paperNameTextBox
            // 
            this.paperNameTextBox.Location = new System.Drawing.Point(547, 46);
            this.paperNameTextBox.Name = "paperNameTextBox";
            this.paperNameTextBox.Size = new System.Drawing.Size(134, 22);
            this.paperNameTextBox.TabIndex = 14;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(547, 103);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(134, 22);
            this.topicTextBox.TabIndex = 15;
            // 
            // paperNameLabel
            // 
            this.paperNameLabel.AutoSize = true;
            this.paperNameLabel.Location = new System.Drawing.Point(570, 26);
            this.paperNameLabel.Name = "paperNameLabel";
            this.paperNameLabel.Size = new System.Drawing.Size(88, 17);
            this.paperNameLabel.TabIndex = 16;
            this.paperNameLabel.Text = "paper name:";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(586, 83);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(42, 17);
            this.topicLabel.TabIndex = 17;
            this.topicLabel.Text = "topic:";
            // 
            // panelUploadPaper
            // 
            this.panelUploadPaper.Controls.Add(this.btnSubmit);
            this.panelUploadPaper.Controls.Add(this.contTextBox);
            this.panelUploadPaper.Controls.Add(this.topicLabel);
            this.panelUploadPaper.Controls.Add(this.absTextBox);
            this.panelUploadPaper.Controls.Add(this.paperNameLabel);
            this.panelUploadPaper.Controls.Add(this.topicTextBox);
            this.panelUploadPaper.Controls.Add(this.contentTextBox);
            this.panelUploadPaper.Controls.Add(this.paperNameTextBox);
            this.panelUploadPaper.Controls.Add(this.abstractTextBox);
            this.panelUploadPaper.Location = new System.Drawing.Point(12, 157);
            this.panelUploadPaper.Name = "panelUploadPaper";
            this.panelUploadPaper.Size = new System.Drawing.Size(694, 418);
            this.panelUploadPaper.TabIndex = 18;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(119, 118);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(109, 33);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Upload paper";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(558, 131);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 33);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(211, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(495, 17);
            this.infoLabel.TabIndex = 21;
            this.infoLabel.Text = "to submit a peper, please select a conference and a section from the 2 tables";
            // 
            // AuthorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 583);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.panelUploadPaper);
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
            this.panelUploadPaper.ResumeLayout(false);
            this.panelUploadPaper.PerformLayout();
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
        private System.Windows.Forms.TextBox absTextBox;
        private System.Windows.Forms.TextBox contTextBox;
        private System.Windows.Forms.Label contentTextBox;
        private System.Windows.Forms.Label abstractTextBox;
        private System.Windows.Forms.TextBox paperNameTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Label paperNameLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Panel panelUploadPaper;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label infoLabel;
    }
}