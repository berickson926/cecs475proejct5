namespace linqdb.ChildForms
{
    partial class InsertAuthorISBN
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
            this.InsertButton = new System.Windows.Forms.Button();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.AuthorIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author ID:";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(81, 89);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(81, 32);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNTextBox.TabIndex = 3;
            // 
            // AuthorIDTextBox
            // 
            this.AuthorIDTextBox.Location = new System.Drawing.Point(81, 63);
            this.AuthorIDTextBox.Name = "AuthorIDTextBox";
            this.AuthorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorIDTextBox.TabIndex = 4;
            // 
            // InsertAuthorISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 132);
            this.Controls.Add(this.AuthorIDTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertAuthorISBN";
            this.Text = "Insert AuthorISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox AuthorIDTextBox;
    }
}