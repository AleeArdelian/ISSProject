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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.affiliationLabel = new System.Windows.Forms.Label();
            this.affiliationTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.tbaCnpLabel = new System.Windows.Forms.Label();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.conferencesDGV = new System.Windows.Forms.DataGridView();
            this.sectionsDGV = new System.Windows.Forms.DataGridView();
            this.papersDGV = new System.Windows.Forms.DataGridView();
            this.panelUploadPaper = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.absTextBox = new System.Windows.Forms.TextBox();
            this.paperNameLabel = new System.Windows.Forms.Label();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.paperNameTextBox = new System.Windows.Forms.TextBox();
            this.abstractTextBox = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.yourPapersDGV = new System.Windows.Forms.DataGridView();
            this.panelReview = new System.Windows.Forms.Panel();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxQualifier = new System.Windows.Forms.ComboBox();
            this.btnReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersDGV)).BeginInit();
            this.panelUploadPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourPapersDGV)).BeginInit();
            this.panelReview.SuspendLayout();
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(98, 32);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 1;
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
            // affiliationTextBox
            // 
            this.affiliationTextBox.Location = new System.Drawing.Point(98, 88);
            this.affiliationTextBox.Name = "affiliationTextBox";
            this.affiliationTextBox.Size = new System.Drawing.Size(100, 22);
            this.affiliationTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(98, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 6;
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
            this.conferencesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conferencesDGV_CellClick_1);
            // 
            // sectionsDGV
            // 
            this.sectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDGV.Location = new System.Drawing.Point(758, 232);
            this.sectionsDGV.Name = "sectionsDGV";
            this.sectionsDGV.RowTemplate.Height = 24;
            this.sectionsDGV.Size = new System.Drawing.Size(314, 214);
            this.sectionsDGV.TabIndex = 10;
            // 
            // papersDGV
            // 
            this.papersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.papersDGV.Location = new System.Drawing.Point(1088, 12);
            this.papersDGV.Name = "papersDGV";
            this.papersDGV.RowTemplate.Height = 24;
            this.papersDGV.Size = new System.Drawing.Size(314, 434);
            this.papersDGV.TabIndex = 11;
            // 
            // panelUploadPaper
            // 
            this.panelUploadPaper.Controls.Add(this.btnSubmit);
            this.panelUploadPaper.Controls.Add(this.contentTextBox);
            this.panelUploadPaper.Controls.Add(this.topicLabel);
            this.panelUploadPaper.Controls.Add(this.absTextBox);
            this.panelUploadPaper.Controls.Add(this.paperNameLabel);
            this.panelUploadPaper.Controls.Add(this.topicTextBox);
            this.panelUploadPaper.Controls.Add(this.contentLabel);
            this.panelUploadPaper.Controls.Add(this.paperNameTextBox);
            this.panelUploadPaper.Controls.Add(this.abstractTextBox);
            this.panelUploadPaper.Location = new System.Drawing.Point(12, 178);
            this.panelUploadPaper.Name = "panelUploadPaper";
            this.panelUploadPaper.Size = new System.Drawing.Size(740, 488);
            this.panelUploadPaper.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(583, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 33);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(303, 31);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(264, 450);
            this.contentTextBox.TabIndex = 22;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(611, 88);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(42, 17);
            this.topicLabel.TabIndex = 28;
            this.topicLabel.Text = "topic:";
            // 
            // absTextBox
            // 
            this.absTextBox.Location = new System.Drawing.Point(33, 31);
            this.absTextBox.Multiline = true;
            this.absTextBox.Name = "absTextBox";
            this.absTextBox.Size = new System.Drawing.Size(264, 450);
            this.absTextBox.TabIndex = 21;
            // 
            // paperNameLabel
            // 
            this.paperNameLabel.AutoSize = true;
            this.paperNameLabel.Location = new System.Drawing.Point(595, 31);
            this.paperNameLabel.Name = "paperNameLabel";
            this.paperNameLabel.Size = new System.Drawing.Size(88, 17);
            this.paperNameLabel.TabIndex = 27;
            this.paperNameLabel.Text = "paper name:";
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(572, 108);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(134, 22);
            this.topicTextBox.TabIndex = 26;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(403, 11);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(59, 17);
            this.contentLabel.TabIndex = 23;
            this.contentLabel.Text = "content:";
            // 
            // paperNameTextBox
            // 
            this.paperNameTextBox.Location = new System.Drawing.Point(572, 51);
            this.paperNameTextBox.Name = "paperNameTextBox";
            this.paperNameTextBox.Size = new System.Drawing.Size(134, 22);
            this.paperNameTextBox.TabIndex = 25;
            // 
            // abstractTextBox
            // 
            this.abstractTextBox.AutoSize = true;
            this.abstractTextBox.Location = new System.Drawing.Point(129, 11);
            this.abstractTextBox.Name = "abstractTextBox";
            this.abstractTextBox.Size = new System.Drawing.Size(63, 17);
            this.abstractTextBox.TabIndex = 24;
            this.abstractTextBox.Text = "abstract:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(12, 141);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(93, 31);
            this.btnUpdateInfo.TabIndex = 13;
            this.btnUpdateInfo.Text = "Update info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(111, 141);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(104, 31);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload paper";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // yourPapersDGV
            // 
            this.yourPapersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yourPapersDGV.Location = new System.Drawing.Point(758, 452);
            this.yourPapersDGV.Name = "yourPapersDGV";
            this.yourPapersDGV.RowTemplate.Height = 24;
            this.yourPapersDGV.Size = new System.Drawing.Size(314, 214);
            this.yourPapersDGV.TabIndex = 15;
            // 
            // panelReview
            // 
            this.panelReview.Controls.Add(this.btnSubmitReview);
            this.panelReview.Controls.Add(this.labelComments);
            this.panelReview.Controls.Add(this.commentsTextBox);
            this.panelReview.Controls.Add(this.comboBoxQualifier);
            this.panelReview.Location = new System.Drawing.Point(1088, 478);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(314, 188);
            this.panelReview.TabIndex = 16;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(219, 4);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(80, 48);
            this.btnSubmitReview.TabIndex = 3;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(4, 35);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(78, 17);
            this.labelComments.TabIndex = 2;
            this.labelComments.Text = "Comments:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(3, 59);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(308, 126);
            this.commentsTextBox.TabIndex = 1;
            // 
            // comboBoxQualifier
            // 
            this.comboBoxQualifier.FormattingEnabled = true;
            this.comboBoxQualifier.Location = new System.Drawing.Point(3, 4);
            this.comboBoxQualifier.Name = "comboBoxQualifier";
            this.comboBoxQualifier.Size = new System.Drawing.Size(121, 24);
            this.comboBoxQualifier.TabIndex = 0;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(1088, 447);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(75, 29);
            this.btnReview.TabIndex = 17;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // MemberMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 671);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.panelReview);
            this.Controls.Add(this.yourPapersDGV);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.panelUploadPaper);
            this.Controls.Add(this.papersDGV);
            this.Controls.Add(this.sectionsDGV);
            this.Controls.Add(this.conferencesDGV);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.tbaCnpLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.affiliationTextBox);
            this.Controls.Add(this.affiliationLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.personalInfoLabel);
            this.Name = "MemberMainWindow";
            this.Text = "MemberMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.conferencesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersDGV)).EndInit();
            this.panelUploadPaper.ResumeLayout(false);
            this.panelUploadPaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourPapersDGV)).EndInit();
            this.panelReview.ResumeLayout(false);
            this.panelReview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label affiliationLabel;
        private System.Windows.Forms.TextBox affiliationTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label tbaCnpLabel;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.DataGridView conferencesDGV;
        private System.Windows.Forms.DataGridView sectionsDGV;
        private System.Windows.Forms.DataGridView papersDGV;
        private System.Windows.Forms.Panel panelUploadPaper;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView yourPapersDGV;
        private System.Windows.Forms.Panel panelReview;
        private System.Windows.Forms.ComboBox comboBoxQualifier;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox absTextBox;
        private System.Windows.Forms.Label paperNameLabel;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox paperNameTextBox;
        private System.Windows.Forms.Label abstractTextBox;
    }
}