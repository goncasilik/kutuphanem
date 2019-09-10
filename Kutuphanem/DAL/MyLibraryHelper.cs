using Kutuphanem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.DAL
{
    class MyLibraryHelper
    {
        public static bool AddBookToMyLibrary(int bookID, int personID)
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Book book = db.Book.Where(b => b.BookID == bookID).FirstOrDefault(); //seçilen kitabın kaydı var mı?
                    Person person = db.Person.Where(p => p.PersonID == personID).FirstOrDefault(); // giris yapan kisi var mı?

                    if (book is Book && person is Person)
                    {
                        person.Books.Add(book);
                        db.SaveChanges();

                        return true;
                    }

                    return false;
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
