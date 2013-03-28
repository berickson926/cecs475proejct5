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
    public partial class InsertAuthor : Form
    {
        public InsertAuthor()
        {
            InitializeComponent();
        }

        private void InsertAuthor_Load(object sender, EventArgs e)
        {

        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            string first, last;

            first = firstNameTextBox.Text;
            last = lastNameTextBox.Text;

            if (first.Length > 0 && last.Length > 0)
            {
                Accessor.InsertOrUpdateAuthor(first, last);

                MessageBox.Show("Author added!");

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
            }
            else
                MessageBox.Show("Invalid entry, try again.");

        }//end addAuthorButton_Click

    }//end class InsertAuthor
}
