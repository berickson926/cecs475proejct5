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
    public partial class QueryTitle : Form
    {
        public QueryTitle()
        {
            InitializeComponent();
        }

        private void TitleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Enable user controls for the search
            ParameterLabel.Visible = true;
            ParameterTextBox.Visible = true;
            SearchButton.Visible = true;
        }

        private void CopyrightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Hide controls not relevant to this function
            ParameterLabel.Visible = false;
            ParameterTextBox.Visible = false;
            SearchButton.Visible = false;

            //autopull all data sorted by copyright into datagrid
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
