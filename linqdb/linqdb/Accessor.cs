using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;

namespace linqdb
{
    class Accessor
    {
        
        public static System.Data.Linq.Table<Author> GetAuthorsTable()
        {
            BooksDataContext dc = new BooksDataContext();
            return dc.GetTable<Author>();
        }
        public static void InsertOrUpdateAuthor(string first, string last)
        {
            BooksDataContext dc = new BooksDataContext();
            Table<Author> authors = Accessor.GetAuthorsTable();
            Author au = new Author();
            au.FirstName = first;
            au.LastName = last;
            authors.InsertOnSubmit(au);
            authors.Context.SubmitChanges();
            dc.SubmitChanges();

        }

        public static void DeleteAuthor(int authorID)
        {
            BooksDataContext dc = new BooksDataContext();
           var matchedAuthor = (from a in dc.GetTable<Author>()
                             where a.AuthorID == authorID
                             select a).SingleOrDefault();
            dc.Authors.DeleteOnSubmit(matchedAuthor);
            dc.SubmitChanges();
        }

        public static void insertOrUpdateTitle(string isbn, string title, int edition, string copyright)
        {
            BooksDataContext dc = new BooksDataContext();

            Table<Title> titles = Accessor.getTitlesTable();
            Title t = new Title();

            t.ISBN = isbn;
            t.BookTitle = title;
            t.EditionNumber = edition;
            t.Copyright = copyright;

            titles.InsertOnSubmit(t);
            titles.Context.SubmitChanges();
            dc.SubmitChanges();
        }

        public static void deleteTitle(string isbn)
        {
            BooksDataContext dc = new BooksDataContext();
            var matchedTitle = (from t in dc.GetTable<Title>()
                                 where t.ISBN == isbn
                                 select t).SingleOrDefault();
            dc.Titles.DeleteOnSubmit(matchedTitle);
            dc.SubmitChanges();
        }

        public static void InsertOrUpdateAuthorISBN(string isbn, int id)
        {
            BooksDataContext dc = new BooksDataContext();

            Table<AuthorISBN> authorISBNs = dc.GetTable<AuthorISBN>();

            AuthorISBN a = new AuthorISBN();

            a.AuthorID = id;
            a.ISBN = isbn;

            authorISBNs.InsertOnSubmit(a);
            authorISBNs.Context.SubmitChanges();
            dc.SubmitChanges();

        }//end insertorupdateauthorisbn

        public static void DeleteAuthorISBN(string isbn, int id)
        {
            BooksDataContext dc = new BooksDataContext();

            var matchedAuthorISBN = (from authorisbn in dc.GetTable<AuthorISBN>()
                                     where authorisbn.ISBN == isbn && authorisbn.AuthorID == id
                                     select authorisbn).SingleOrDefault();

            dc.AuthorISBNs.DeleteOnSubmit(matchedAuthorISBN);
            dc.SubmitChanges();

        }//end deleteauthorisbn

        public static System.Data.Linq.Table<Title> getTitlesTable()
        {
            BooksDataContext dc = new BooksDataContext();
            return dc.GetTable<Title>();
        }

        public static System.Linq.IQueryable getAuthorISBNTable()
        {
            BooksDataContext dc = new BooksDataContext();

            var authISBN = (from author in dc.GetTable<Author>()
                          join book in dc.GetTable<AuthorISBN>()
                               on author.AuthorID equals book.AuthorID
                          orderby author.LastName, author.FirstName
                          select new { author.FirstName, author.LastName, book.ISBN });    

            return authISBN;
        }

        public static String getAuthorByID(string id)
        {

            BooksDataContext dc = new BooksDataContext();

            var authID = (from author in dc.GetTable<Author>()
                          where author.AuthorID == Int32.Parse(id)
                          select author.FirstName+" "+author.LastName).SingleOrDefault<System.String>();

            return authID;
        }

        public static String getAuthorByLastName(String last)
        {
            BooksDataContext dc = new BooksDataContext();

            var authLast = (from author in dc.GetTable<Author>()
                            where author.LastName.CompareTo(last) == 0
                            select author.AuthorID + ", " + author.FirstName + " " + author.LastName).First<System.String>();
            return authLast;
        }

        public static void getAuthorAndTitles()
        {
            BooksDataContext dc = new BooksDataContext();

            var authTitle = (from title in dc.GetTable<Title>()
                             from book in title.AuthorISBNs
                             let author = book.Author
                             orderby author.LastName, author.FirstName, title.BookTitle
                             select new { author.FirstName, author.LastName, title.BookTitle });

           // return authTitle;
        }//end getAuthorAndTitles

        public static System.Linq.IQueryable getAuthorList()
        {
            BooksDataContext dc = new BooksDataContext();

            var auth = (from author in dc.GetTable<Author>()
                        orderby author.LastName, author.FirstName
                        let name = author.FirstName+" "+author.LastName
                        select new linqdb.ChildForms.MasterDetail.AuthorBinding {Author = author, name = name});

            return auth;
        }//end getAuthorList

        public static System.Linq.IQueryable getTitleList()
        {
            BooksDataContext dc = new BooksDataContext();

            var titleList = (from title in dc.GetTable<Title>()
                         orderby title.BookTitle
                         select title);

            return titleList;
        }//end getTitleList

        public static System.Collections.Generic.IEnumerable<linqdb.Title> getTitlesByAuthor(Author currentAuthor)
        {
            BooksDataContext dc = new BooksDataContext();

            var titleByAuth = (from book in currentAuthor.AuthorISBNs
                               select book.Title);

            return titleByAuth;
        }

        public static System.Collections.Generic.IEnumerable<linqdb.Author> getAuthorsByTitle(Title currentTitle)
        {
            BooksDataContext dc = new BooksDataContext();

            var authByTitle = (from book in currentTitle.AuthorISBNs
                               select book.Author);

            return authByTitle;
        }

        public static System.Linq.IQueryable getTitlesByCopyright()
        {
            BooksDataContext dc = new BooksDataContext();

            var titleByCR = (from title in dc.GetTable<Title>()
                             orderby title.Copyright
                             select title);

            return titleByCR;
        }//end getTitlesByCopyright

        public static System.Linq.IQueryable getBooksByTitle(string bookName)
        {
            BooksDataContext dc = new BooksDataContext();

            var bookByTitle = (from title in dc.GetTable<Title>()
                               where title.BookTitle.Contains(bookName)
                               select title);

            return bookByTitle;

        }//end getBooksByTitle

        public static System.Linq.IQueryable getAuthorByISBN()
        {
            BooksDataContext dc = new BooksDataContext();

            var authISBN = (from author in dc.GetTable<Author>()
                            join book in dc.GetTable<AuthorISBN>()
                                on author.AuthorID equals book.AuthorID
                            orderby author.LastName, author.FirstName
                            select new { author.FirstName, author.LastName, book.ISBN });

            return authISBN;

        }//end getAuthorByISBN


        public static RichTextBox getAuthorsAndTitles()
        {
            BooksDataContext dc = new BooksDataContext();

            var authTitle = (from title in dc.GetTable<Title>()
                             from book in dc.GetTable<AuthorISBN>()
                             let author = book.Author
                             orderby author.LastName, author.FirstName, title.BookTitle
                             select new { author.FirstName, author.LastName, title.BookTitle });

            RichTextBox temp = new RichTextBox();
            temp.AppendText("Authors and titles:\n\n");

            foreach (var element in authTitle)
            {
                temp.AppendText(String.Format("\t{0,-10} {1,-15} {2}\n", element.FirstName, element.LastName, element.BookTitle));
            }

            return temp;

        }//end getAuthorsAndTitles

        public static RichTextBox getAuthorAndTitles_GroupByAuthor()
        {
            BooksDataContext dc = new BooksDataContext();

            var authTitle = (from author in dc.GetTable<Author>()
                             orderby author.LastName, author.FirstName
                             let name = author.FirstName + " " + author.LastName 
                             let titles =  
                                 from book in author.AuthorISBNs
                                 orderby book.Title.BookTitle 
                                 select book.Title.BookTitle
                             select new { Name = name, Titles = titles });
            
            RichTextBox temp = new RichTextBox();

            temp.AppendText("Titles Grouped by Author:\n");
            

            // display titles written by each author, grouped by author 
            foreach ( var author in authTitle ) 
            { 
                // display author's name 
                temp.AppendText("\t" + author.Name + ":\n"); 

                // display titles written by that author 
                foreach ( var title in author.Titles ) 
                {
                    temp.AppendText("\t\t" + title+"\n"); 
                } // end inner foreach 
            } // end outer foreach 

            return temp;

        }//end getAuthorAndTitles

    }//end class Accessor
}
