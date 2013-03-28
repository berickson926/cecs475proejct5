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
    public partial class DeleteAuthor : Form
    {
        public DeleteAuthor()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Accessor.DeleteAuthor(Int32.Parse(authorIDTextBox.Text));

                MessageBox.Show("Success");
                authorIDTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Deletion Failed.");
            }
        }
    }
}
