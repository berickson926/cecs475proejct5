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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /****************************Tables**************************************/

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new ReadAuthorChildForm();

            child.MdiParent = this;

            child.Show();
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

        private void masterDetailToolStripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new MasterDetail();

            child.MdiParent = this;

            child.Show();
        }

        /****************************Queries*****************************************/

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

        private void searchAuthorAndTitlesToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new QueryAuthorAndTitle();

            child.MdiParent = this;

            child.Show();
        }

        private void searchAuthorsAndISBNsToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new QueryAuthorAndISBN();

            child.MdiParent = this;

            child.Show();
        }

        /******************************Modify Data************************************/


        //private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Accessor.InsertOrUpdateAuthor("phuong", "nguyen");
        //}

        //private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Accessor.DeleteAuthor(5);
        //}

        private void insertAuthorToolStripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new InsertAuthor();

            child.MdiParent = this;

            child.Show();
        }

        private void insertTitleToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new InsertTitle();

            child.MdiParent = this;

            child.Show();
        }

        private void updateAuthorToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new UpdateAuthor();

            child.MdiParent = this;

            child.Show();
        }

        private void updateTitleToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new UpdateTitle();

            child.MdiParent = this;

            child.Show();
        }

        private void deleteAuthorToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new DeleteAuthor();

            child.MdiParent = this;

            child.Show();
        }

        private void deleteTitleToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new DeleteTitle();

            child.MdiParent = this;

            child.Show();
        }

        private void authorISBNToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new InsertAuthorISBN();

            child.MdiParent = this;

            child.Show();
        }

        private void updateAuthorISBNToolstripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new UpdateAuthorISBN();

            child.MdiParent = this;

            child.Show();
        }

        private void deleteAuthorISBNToolstripMenuitem_Click(object sender, EventArgs e)
        {
            Form child = new DeleteAuthorISBN();

            child.MdiParent = this;

            child.Show();
        }

        /****************************End modify data*********************************/


    }//end MainForm partial class
}//end namespace Linqdb
