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
    public partial class MasterDetail : Form
    {
        BindingSource booksBindingSource;

        public MasterDetail()
        {
            InitializeComponent();

            booksBindingSource = new BindingSource();
        }

        public class AuthorBinding
        {
            public Author Author { get; set; }
            public string name { get; set; } 
        }

        //Initialize data sources when form is loaded
        private void MasterDetail_Load(object sender, EventArgs e)
        {
            //display AuthorBinding.name
            AuthorComboBox.DisplayMember = "Name";

            //Set authorComboBox's DataSource to the list of authors
            AuthorComboBox.DataSource = Accessor.getAuthorList();

            //Display Title.BookTitle
            TitleComboBox.DisplayMember = "BookTitle";

            //Set titleComboBOx's DataSource to the list of titles
            TitleComboBox.DataSource = Accessor.getTitleList();

            //Initially, display no "detail" data
            booksBindingSource.DataSource = null;

            //Set the DataSource of the DataGridView to the BindingSource
            booksDataGridView.DataSource = booksBindingSource;
        }//end method MasterDetailForm_Load

        //Display titles that were co-authored by the selected author
        private void authorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the selected Author object from the ComboBox
            Author currentAuthor = ((AuthorBinding)AuthorComboBox.SelectedItem).Author;

            //Set booksBindingSource's DataSource to the list of titles written by selected author
            booksBindingSource.DataSource = Accessor.getTitlesByAuthor(currentAuthor);
        }//end authorComboBox_SelectedIndexChanged

        //display the authors of the selected title
        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected Title object from the ComboBox
            Title currentTitle = (Title)TitleComboBox.SelectedItem;

            //Set booksBindingSource's DataSource to the list of authors for the selected title
            booksBindingSource.DataSource = Accessor.getAuthorsByTitle(currentTitle);

        }//end titleComboBox_SelectedIndexChanged

    }//end class MasterDetail
}//end namespace linqdb.childforms
