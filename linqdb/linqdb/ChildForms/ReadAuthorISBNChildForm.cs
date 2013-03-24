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
    public partial class ReadAuthorISBNChildForm : Form
    {
        public ReadAuthorISBNChildForm()
        {
            InitializeComponent();

            System.Data.Linq.Table<AuthorISBN> authorISBNs = Accessor.getAuthorISBNTable();
            dataGridView.DataSource = authorISBNs;
        }
    }
}
