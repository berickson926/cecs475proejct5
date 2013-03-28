/*
 * Program 5, CECS 475
 * Author: Bret Erickson
 * 
 * Description:
 * 
 * Books database application.
 * 
 * GUI allows user to interact with database by facilitating the following features:
 * 
 * Insert/Update/Delete and Author, Title, or AuthorISBN relation
 * 
 * Query the three tables stored in the DB, Author, Title, AuthorISBN
 * 
 * A master/detail view of the DB
 * 
 * The following queries:
 * 
 *  author's name by author id
    author's id and name by last name
    book titles in the Titles table. If the user enter "Visual", then the search should return any title containing the word "Visual". Hint: Use the Contains method of the string class - Ex: where title.BookTitle.Contains("Visual")
    all titles by copyright
    authors and ISBNs of each book they co-authored
    authors and titles of each book they co-authored
    authors and titles of each book they co-authored; group by author
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace linqdb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
