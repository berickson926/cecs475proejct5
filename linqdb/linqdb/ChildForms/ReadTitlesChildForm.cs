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
    public partial class ReadTitlesChildForm : Form
    {
        public ReadTitlesChildForm()
        {
            InitializeComponent();

            System.Data.Linq.Table<Title> titles = Accessor.getTitlesTable();
            dataGridView.DataSource = titles;
        } 
    }
}
