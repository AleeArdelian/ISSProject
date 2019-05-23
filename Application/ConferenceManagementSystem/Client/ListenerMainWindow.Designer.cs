namespace Client {
    partial class ListenerMainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonJoinSection = new System.Windows.Forms.Button();
            this.sectionsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJoinSection
            // 
            this.buttonJoinSection.Location = new System.Drawing.Point(181, 414);
            this.buttonJoinSection.Name = "buttonJoinSection";
            this.buttonJoinSection.Size = new System.Drawing.Size(83, 33);
            this.buttonJoinSection.TabIndex = 0;
            this.buttonJoinSection.Text = "Join";
            this.buttonJoinSection.UseVisualStyleBackColor = true;
            this.buttonJoinSection.Click += new System.EventHandler(this.buttonJoinSection_Click);
            // 
            // sectionsDGV
            // 
            this.sectionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDGV.Location = new System.Drawing.Point(36, 102);
            this.sectionsDGV.Name = "sectionsDGV";
            this.sectionsDGV.RowTemplate.Height = 28;
            this.sectionsDGV.Size = new System.Drawing.Size(409, 273);
            this.sectionsDGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick a section you want to participte in:";
            // 
            // ListenerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectionsDGV);
            this.Controls.Add(this.buttonJoinSection);
            this.Name = "ListenerMainWindow";
            this.Text = "ListenerMainWindow";
            this.Load += new System.EventHandler(this.ListenerMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJoinSection;
        private System.Windows.Forms.DataGridView sectionsDGV;
        private System.Windows.Forms.Label label1;
    }
}