using Kutuphanem.Model;
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

        public static List<GenreModel> MapGenreEntity(List<Genre> genres)
        {
            List<GenreModel> genresModel = new List<GenreModel>();

            foreach (var genre in genres)
            {
                GenreModel genreModel = new GenreModel
                {
                    GenreID = genre.GenreID,
                    Name = genre.Name
                };

                genresModel.Add(genreModel);
            }

            return genresModel;
        }

        public static Genre MapGenreModel(GenreModel genre)
        {
            Genre genreEntity = new Genre
            {
                GenreID = genre.GenreID,
                Name = genre.Name,
            };

            return genreEntity;
        }
    }
}
