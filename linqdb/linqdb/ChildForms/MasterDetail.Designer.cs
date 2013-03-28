namespace linqdb.ChildForms
{
    partial class MasterDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 51);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.Size = new System.Drawing.Size(460, 267);
            this.booksDataGridView.TabIndex = 2;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(59, 21);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(163, 21);
            this.AuthorComboBox.TabIndex = 3;
            this.AuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.authorComboBox_SelectedIndexChanged);
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(261, 21);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(211, 21);
            this.TitleComboBox.TabIndex = 4;
            this.TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.titleComboBox_SelectedIndexChanged);
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.TitleComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterDetail";
            this.Text = "Master/Detail";
            this.Load += new System.EventHandler(this.MasterDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.ComboBox TitleComboBox;
    }
}