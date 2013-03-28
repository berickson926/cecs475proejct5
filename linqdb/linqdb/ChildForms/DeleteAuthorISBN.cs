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
    public partial class DeleteAuthorISBN : Form
    {
        public DeleteAuthorISBN()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn, id;

                //Grab user input from GUI
                isbn = ISBNTextBox.Text;
                id = AuthorIDTextBox.Text;

                //Attempt deletion in DB
                Accessor.DeleteAuthorISBN(isbn, Int32.Parse(id));

                //Notify user & Cleanup GUI
                MessageBox.Show("Deletion successful.");
                ISBNTextBox.Text = "";
                AuthorIDTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Deletion Failed.");
            }
        }
    }
}
