namespace linqdb.ChildForms
{
    partial class QueryAuthorAndTitle
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
            this.groupByBox = new System.Windows.Forms.GroupBox();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupByBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupByBox
            // 
            this.groupByBox.Controls.Add(this.authorRadioButton);
            this.groupByBox.Controls.Add(this.noneRadioButton);
            this.groupByBox.Location = new System.Drawing.Point(12, 12);
            this.groupByBox.Name = "groupByBox";
            this.groupByBox.Size = new System.Drawing.Size(409, 44);
            this.groupByBox.TabIndex = 1;
            this.groupByBox.TabStop = false;
            this.groupByBox.Text = "Group By:";
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(99, 20);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.TabStop = true;
            this.authorRadioButton.Text = "Author";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            this.authorRadioButton.CheckedChanged += new System.EventHandler(this.authorRadioButton_CheckedChanged);
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(7, 20);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.noneRadioButton_CheckedChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 62);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(409, 232);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // QueryAuthorAndTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.groupByBox);
            this.Name = "QueryAuthorAndTitle";
            this.Text = "Author & Title Search";
            this.Load += new System.EventHandler(this.authorTitleSearch_Load);
            this.groupByBox.ResumeLayout(false);
            this.groupByBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupByBox;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}