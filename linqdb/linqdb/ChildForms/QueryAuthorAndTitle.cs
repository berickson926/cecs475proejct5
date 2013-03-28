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
    public partial class QueryAuthorAndTitle : Form
    {
        public QueryAuthorAndTitle()
        {
            InitializeComponent();
        }

        private void authorTitleSearch_Load(object sender, EventArgs e)
        {

        }//end authorTitleSearch_Load

        private void noneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //richTextBox.DataSource = Accessor.getAuthorsAndTitles();

            richTextBox.Clear();

            richTextBox.Text = Accessor.getAuthorsAndTitles().Text;
  
        }//end noneRadioButton_CheckedChanged

        private void authorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView.DataSource = Accessor.getAuthorAndTitles_GroupByAuthor();

            richTextBox.Clear();

            richTextBox.Text = Accessor.getAuthorAndTitles_GroupByAuthor().Text;

        }//end authorRadioButton_CheckedChanged

    }//end QueryAuthorAndTitle
}//end namespace linqdb.ChildForms
