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
    public partial class ReadAuthorChildForm : Form
    {
        public ReadAuthorChildForm()
        {
            InitializeComponent();

            System.Data.Linq.Table<Author> authors = Accessor.GetAuthorsTable();
            dataGridView.DataSource = authors;
        }

        private void ReadAuthorChildForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
