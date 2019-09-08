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
        public static bool AddBookToMyLibrary(int bookID, int personID = 1)
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Book book = db.Book.Where(b => b.BookID == bookID).FirstOrDefault();
                    Person person = db.Person.Where(p => p.PersonID == personID).FirstOrDefault();

                    if (book is Book && person is Person)
                    {
                        // add instance to navigation property
                        person.Books.Add(book);

                        //call SaveChanges from context to confirm inserts
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
