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
    public partial class QueryAuthor : Form
    {
        private bool searchType;

        public QueryAuthor()
        {
            InitializeComponent();

            searchType = true;//search by ID by default
        }

        private void IDRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchType = true;//search by ID
        }

        private void LastNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchType = false;//search by last name
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Search by ID
                if (searchType)
                    MessageBox.Show(Accessor.getAuthorByID(parameterBox.Text).ToString());
                else//search by last name
                {
                    MessageBox.Show(Accessor.getAuthorByLastName(parameterBox.Text).ToString());
                }//end else
            }
            catch (Exception)
            {
                MessageBox.Show("Author not found!");
            }
        }//end SearchBtn_Click
    }//end partial class QueryAuthor
}//end linqdb.ChildForms
