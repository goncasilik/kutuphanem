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
        public static bool AddBookToMyLibrary(int bookID, int personID = 1, string status = "read")
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Book book = db.Book.Where(b => b.BookID == bookID).FirstOrDefault();
                    Person person = db.Person.Where(s => s.PersonID == bookID).FirstOrDefault();

                    //if (book is Book && person is Person)
                    //{
                    //    MyBook myBook = new MyBook();

                    //    myBook.PersonID = personID;
                    //    myBook.BookID = bookID;
                    //    myBook.Status = status;

                    //    db.MyBook.Add(myBook);
                    //    db.SaveChanges();

                    //    return true;
                    //}

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
