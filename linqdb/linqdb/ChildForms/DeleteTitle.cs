﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linqdb.ChildForms
{
    public partial class DeleteTitle : Form
    {
        public DeleteTitle()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = ISBNTextBox.Text;

                Accessor.deleteTitle(isbn);

                MessageBox.Show("Title deleted.");

                ISBNTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Deletion Failed.");
            }
        }
    }
}
