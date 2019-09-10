using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.DAL
{
    class AuthorHelper
    {
        public static List<Author> ListAuthors()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Author.ToList();
            }
        }
        public static void AddAuthor(Author author)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                db.Author.Add(author);
                db.SaveChanges();
            }
        }

        public static void DeleteAuthor(int authorID)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Author author = db.Author.Where(a => a.AuthorID == authorID).FirstOrDefault();
                db.Author.Remove(author);
                db.SaveChanges();
            }
        }

        public static int TotalAuthorCount()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Author.Count();
            }
        }
    }
}
