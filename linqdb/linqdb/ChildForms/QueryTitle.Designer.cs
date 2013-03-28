namespace linqdb.ChildForms
{
    partial class QueryTitle
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleRadioButton = new System.Windows.Forms.RadioButton();
            this.CopyrightRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ParameterLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 146);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(418, 189);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TitleRadioButton);
            this.groupBox1.Controls.Add(this.CopyrightRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Type";
            // 
            // TitleRadioButton
            // 
            this.TitleRadioButton.AutoSize = true;
            this.TitleRadioButton.Location = new System.Drawing.Point(6, 19);
            this.TitleRadioButton.Name = "TitleRadioButton";
            this.TitleRadioButton.Size = new System.Drawing.Size(45, 17);
            this.TitleRadioButton.TabIndex = 1;
            this.TitleRadioButton.TabStop = true;
            this.TitleRadioButton.Text = "Title";
            this.TitleRadioButton.UseVisualStyleBackColor = true;
            this.TitleRadioButton.CheckedChanged += new System.EventHandler(this.TitleRadioButton_CheckedChanged);
            // 
            // CopyrightRadioButton
            // 
            this.CopyrightRadioButton.AutoSize = true;
            this.CopyrightRadioButton.Location = new System.Drawing.Point(57, 19);
            this.CopyrightRadioButton.Name = "CopyrightRadioButton";
            this.CopyrightRadioButton.Size = new System.Drawing.Size(69, 17);
            this.CopyrightRadioButton.TabIndex = 0;
            this.CopyrightRadioButton.TabStop = true;
            this.CopyrightRadioButton.Text = "Copyright";
            this.CopyrightRadioButton.UseVisualStyleBackColor = true;
            this.CopyrightRadioButton.CheckedChanged += new System.EventHandler(this.CopyrightRadioButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(355, 95);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ParameterLabel
            // 
            this.ParameterLabel.AutoSize = true;
            this.ParameterLabel.Location = new System.Drawing.Point(9, 82);
            this.ParameterLabel.Name = "ParameterLabel";
            this.ParameterLabel.Size = new System.Drawing.Size(30, 13);
            this.ParameterLabel.TabIndex = 3;
            this.ParameterLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 98);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // QueryTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 347);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ParameterLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "QueryTitle";
            this.Text = "Query Title";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TitleRadioButton;
        private System.Windows.Forms.RadioButton CopyrightRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ParameterLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
    }
}