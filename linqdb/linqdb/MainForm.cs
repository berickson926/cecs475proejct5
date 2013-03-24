using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using linqdb.ChildForms;

namespace linqdb
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new ReadAuthorChildForm();

            child.MdiParent = this;

            child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accessor.InsertOrUpdateAuthor("phuong", "nguyen");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accessor.DeleteAuthor(5);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitlesToolstripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new ReadTitlesChildForm();

            child.MdiParent = this;

            child.Show();     
        }

        private void authorISBNSToolstripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new ReadAuthorISBNChildForm();

            child.MdiParent = this;

            child.Show();
        }

        private void SearchForAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new QueryAuthor();

            child.MdiParent = this;

            child.Show();
        }

        private void SearchForTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new QueryTitle();

            child.MdiParent = this;

            child.Show();
        }


    }//end MainForm partial class
}//end namespace Linqdb
