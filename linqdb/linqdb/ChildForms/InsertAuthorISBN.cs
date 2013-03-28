using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linqdb.ChildForms
{
    public partial class InsertAuthorISBN : Form
    {
        public InsertAuthorISBN()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn, id;

                //Grab user input from GUI
                isbn = ISBNTextBox.Text;
                id = AuthorIDTextBox.Text;

                //Attempt insertion into DB
                Accessor.InsertOrUpdateAuthorISBN(isbn, Int32.Parse(id));

                //Notify user & Cleanup GUI
                MessageBox.Show("Insertion successful.");
                ISBNTextBox.Text = "";
                AuthorIDTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Insertion Failed.");
            }
        }
    }
}
