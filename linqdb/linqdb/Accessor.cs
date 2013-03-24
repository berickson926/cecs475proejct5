using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;

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

        public static System.Data.Linq.Table<AuthorISBN> getAuthorISBNTable()
        {
            BooksDataContext dc = new BooksDataContext();
            return dc.GetTable<AuthorISBN>();
        }
    }
}
