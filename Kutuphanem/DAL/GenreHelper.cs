using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.DAL
{
    class GenreHelper
    {
        public static List<Genre> ListGenres()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Genre.ToList();
            }
        }
        public static void AddGenre(Genre genre)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                db.Genre.Add(genre);
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

        public static int TotalGenreCount()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Genre.Count();
            }
        }
    }
}
