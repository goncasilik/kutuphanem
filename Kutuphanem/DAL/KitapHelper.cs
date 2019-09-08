using Kutuphanem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem
{
    class KitapHelper
    {
        public static List<BookModel> ListBooks()
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    var query = db.Book.Select(book =>
                            new {
                                bookID = book.BookID,
                                name = book.Name,
                                pageCount = book.PageCount,
                                authors = book.Authors.Select(i => i.Name).ToList()
                            }).ToList<dynamic>();

                    var books = new List<BookModel>();

                    foreach (var book in query)
                    {
                        BookModel bookModel = new BookModel();

                        bookModel.BookID = book.bookID;
                        bookModel.Name = book.name;
                        bookModel.PageCount = book.pageCount;
                        bookModel.Authors = book.authors;

                        books.Add(bookModel);
                    }

                    return books;
                }
            }

            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public static void AddBook(Book book)
        {
            using(MyLibraryEntities db = new MyLibraryEntities())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }

        public static void DeleteBook(int bookID)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Book book = db.Book.Where(s => s.BookID == bookID).FirstOrDefault();
                db.Book.Remove(book);
                db.SaveChanges();
            }
        }

        public static List<Genre> ListGenres()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Genre.ToList();
            }
        }
        public static void AddGenre(Genre tur)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                db.Genre.Add(tur);
                db.SaveChanges();
            }
        }

        public static void DeleteGenre(Genre genre)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                db.Genre.Remove(genre);
                db.SaveChanges();
            }
        }
    }
}
