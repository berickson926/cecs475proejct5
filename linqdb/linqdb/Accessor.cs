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

        public static void insertOrUpdateTitle(string isbn, string title)
        {

        }

        public static void deleteTitle(string isbn, string title)
        {

        }

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
    }
}
