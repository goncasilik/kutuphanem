using Kutuphanem.Model;
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

        public static List<AuthorModel> MapAuthorEntity(List<Author> authors)
        {
            List<AuthorModel> authorsModel = new List<AuthorModel>();

            foreach (var author in authors)
            {
                AuthorModel authorModel = new AuthorModel
                {
                    AuthorID = author.AuthorID,
                    Name = author.Name,
                };

                authorsModel.Add(authorModel);
            }

            return authorsModel;
        }

        public static Author MapAuthorModel(AuthorModel author)
        {
            Author authorEntity = new Author
            {
                AuthorID = author.AuthorID,
                Name = author.Name,
            };

            return authorEntity;
        }
    }
}
