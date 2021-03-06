﻿namespace linqdb
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorISBNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAuthorsTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAuthorsAndISBNsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tItleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorISBNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorISBNToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorISBNToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.readToolStripMenuItem,
            this.insertUpdateDeleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem,
            this.titlesToolStripMenuItem,
            this.authorISBNSToolStripMenuItem,
            this.masterDetailToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // titlesToolStripMenuItem
            // 
            this.titlesToolStripMenuItem.Name = "titlesToolStripMenuItem";
            this.titlesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.titlesToolStripMenuItem.Text = "Titles";
            this.titlesToolStripMenuItem.Click += new System.EventHandler(this.TitlesToolstripMenuItem_Click);
            // 
            // authorISBNSToolStripMenuItem
            // 
            this.authorISBNSToolStripMenuItem.Name = "authorISBNSToolStripMenuItem";
            this.authorISBNSToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.authorISBNSToolStripMenuItem.Text = "AuthorISBNS";
            this.authorISBNSToolStripMenuItem.Click += new System.EventHandler(this.authorISBNSToolstripMenuItem_Click);
            // 
            // masterDetailToolStripMenuItem
            // 
            this.masterDetailToolStripMenuItem.Name = "masterDetailToolStripMenuItem";
            this.masterDetailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.masterDetailToolStripMenuItem.Text = "Master/Detail";
            this.masterDetailToolStripMenuItem.Click += new System.EventHandler(this.masterDetailToolStripMenuitem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForAuthorToolStripMenuItem,
            this.searchForTitleToolStripMenuItem,
            this.searchAuthorsTitlesToolStripMenuItem,
            this.searchAuthorsAndISBNsToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // searchForAuthorToolStripMenuItem
            // 
            this.searchForAuthorToolStripMenuItem.Name = "searchForAuthorToolStripMenuItem";
            this.searchForAuthorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchForAuthorToolStripMenuItem.Text = "Search for Author";
            this.searchForAuthorToolStripMenuItem.Click += new System.EventHandler(this.SearchForAuthorToolStripMenuItem_Click);
            // 
            // searchForTitleToolStripMenuItem
            // 
            this.searchForTitleToolStripMenuItem.Name = "searchForTitleToolStripMenuItem";
            this.searchForTitleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchForTitleToolStripMenuItem.Text = "Search for Title";
            this.searchForTitleToolStripMenuItem.Click += new System.EventHandler(this.SearchForTitleToolStripMenuItem_Click);
            // 
            // searchAuthorsTitlesToolStripMenuItem
            // 
            this.searchAuthorsTitlesToolStripMenuItem.Name = "searchAuthorsTitlesToolStripMenuItem";
            this.searchAuthorsTitlesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchAuthorsTitlesToolStripMenuItem.Text = "Authors and Titles";
            this.searchAuthorsTitlesToolStripMenuItem.Click += new System.EventHandler(this.searchAuthorAndTitlesToolstripMenuitem_Click);
            // 
            // searchAuthorsAndISBNsToolStripMenuItem
            // 
            this.searchAuthorsAndISBNsToolStripMenuItem.Name = "searchAuthorsAndISBNsToolStripMenuItem";
            this.searchAuthorsAndISBNsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchAuthorsAndISBNsToolStripMenuItem.Text = "Authors and ISBNs";
            this.searchAuthorsAndISBNsToolStripMenuItem.Click += new System.EventHandler(this.searchAuthorsAndISBNsToolstripMenuitem_Click);
            // 
            // insertUpdateDeleteToolStripMenuItem
            // 
            this.insertUpdateDeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.insertUpdateDeleteToolStripMenuItem.Name = "insertUpdateDeleteToolStripMenuItem";
            this.insertUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.insertUpdateDeleteToolStripMenuItem.Text = "Insert/Update/Delete";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.titleToolStripMenuItem,
            this.authorISBNToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.insertAuthorToolStripMenuitem_Click);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.insertTitleToolstripMenuitem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem1,
            this.titleToolStripMenuItem1,
            this.authorISBNToolStripMenuItem1});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // authorToolStripMenuItem1
            // 
            this.authorToolStripMenuItem1.Name = "authorToolStripMenuItem1";
            this.authorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.authorToolStripMenuItem1.Text = "Author";
            this.authorToolStripMenuItem1.Click += new System.EventHandler(this.updateAuthorToolstripMenuitem_Click);
            // 
            // titleToolStripMenuItem1
            // 
            this.titleToolStripMenuItem1.Name = "titleToolStripMenuItem1";
            this.titleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.titleToolStripMenuItem1.Text = "Title";
            this.titleToolStripMenuItem1.Click += new System.EventHandler(this.updateTitleToolstripMenuitem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem2,
            this.tItleToolStripMenuItem2,
            this.authorISBNToolStripMenuItem2});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // authorToolStripMenuItem2
            // 
            this.authorToolStripMenuItem2.Name = "authorToolStripMenuItem2";
            this.authorToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.authorToolStripMenuItem2.Text = "Author";
            this.authorToolStripMenuItem2.Click += new System.EventHandler(this.deleteAuthorToolstripMenuitem_Click);
            // 
            // tItleToolStripMenuItem2
            // 
            this.tItleToolStripMenuItem2.Name = "tItleToolStripMenuItem2";
            this.tItleToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.tItleToolStripMenuItem2.Text = "Title";
            this.tItleToolStripMenuItem2.Click += new System.EventHandler(this.deleteTitleToolstripMenuitem_Click);
            // 
            // authorISBNToolStripMenuItem
            // 
            this.authorISBNToolStripMenuItem.Name = "authorISBNToolStripMenuItem";
            this.authorISBNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.authorISBNToolStripMenuItem.Text = "AuthorISBN";
            this.authorISBNToolStripMenuItem.Click += new System.EventHandler(this.authorISBNToolstripMenuitem_Click);
            // 
            // authorISBNToolStripMenuItem1
            // 
            this.authorISBNToolStripMenuItem1.Name = "authorISBNToolStripMenuItem1";
            this.authorISBNToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.authorISBNToolStripMenuItem1.Text = "AuthorISBN";
            this.authorISBNToolStripMenuItem1.Click += new System.EventHandler(this.updateAuthorISBNToolstripMenuItem_Click);
            // 
            // authorISBNToolStripMenuItem2
            // 
            this.authorISBNToolStripMenuItem2.Name = "authorISBNToolStripMenuItem2";
            this.authorISBNToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.authorISBNToolStripMenuItem2.Text = "AuthorISBN";
            this.authorISBNToolStripMenuItem2.Click += new System.EventHandler(this.deleteAuthorISBNToolstripMenuitem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 530);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Book Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorISBNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tItleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchAuthorsTitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAuthorsAndISBNsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorISBNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorISBNToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorISBNToolStripMenuItem2;
    }
}

