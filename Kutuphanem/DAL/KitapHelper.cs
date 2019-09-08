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
                    return MapBookEntity(db.Book.ToList<Book>());
                }
            }

            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public static List<BookModel> MapBookEntity(List<Book> books)
        {
            List<BookModel> booksModel = new List<BookModel>();

            foreach (var book in books)
            {
                BookModel bookModel = new BookModel
                {
                    BookID = book.BookID,
                    Name = book.Name,
                    PageCount = book.PageCount,
                    // Authors = book.Authors.ToList(),
                    // Genres = book.Genres.ToList()
                };

                booksModel.Add(bookModel);
            }

            return booksModel;
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
