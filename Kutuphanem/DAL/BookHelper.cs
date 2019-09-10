using Kutuphanem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.DAL
{
    class BookHelper
    {
        public static List<BookModel> ListBooks(string searchQuery)
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    var result = db.Book.Where(b => b.Name.Contains(searchQuery))
                             .ToList();

                    return MapBookEntity(result);
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
                    Authors = book.Authors.ToList(),
                    Genres = book.Genres.ToList()
                };

                booksModel.Add(bookModel);
            }

            return booksModel;
        }

        public static bool Addbook(Book book)
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    db.Book.Add(book);
                    db.SaveChanges();

                    return true;
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
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

        public static int TotalBookCount()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Book.Count();
            }
        }
    }
}
