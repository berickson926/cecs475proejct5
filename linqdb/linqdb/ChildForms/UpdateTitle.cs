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
    public partial class UpdateTitle : Form
    {
        public UpdateTitle()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn, name, copyright;
                int edition;

                isbn = ISBNTextBox.Text;
                name = BookTitleTextBox.Text;
                copyright = CopyrightTextBox.Text;

                edition = Int32.Parse(EditionTextBox.Text);

                Accessor.insertOrUpdateTitle(isbn, name, edition, copyright);

                MessageBox.Show("Title Updated.");

                ISBNTextBox.Text = "";
                BookTitleTextBox.Text = "";
                CopyrightTextBox.Text = "";
                EditionTextBox.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to update Title");
            }
        }
    }
}
