using Kutuphanem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Kutuphanem.DAL
{
    class PersonHelper
    {
        public static Person Login(string email, string password)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Person person = db.Person.Where(p => p.Email.Equals(email)).Where(p => p.Password.Equals(password)).FirstOrDefault();
                if (person != null)
                {
                    return person;
                }

                return person;
            }
        }

        public static List<Person> ListPersons()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Person.ToList();
            }
        }

        public static PersonModel GetPersonWithBooks(int personID) // İlgili kişinin kitap listesini getirir
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Person person = db.Person
                     .Where(p => p.PersonID == personID)
                     .Include(p => p.Books.Select(b => b.Authors)) // kişinin kitap bilgisinin yanında yazar ve tür bilgilerinide getiriyor
                     .Include(p => p.Books.Select(g => g.Genres))
                     .FirstOrDefault();

                    return MapPersonEntity(person);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static PersonModel MapPersonEntity(Person person)
        {
            PersonModel personModel = new PersonModel
            {
                PersonID = person.PersonID,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Books = person.Books.ToList()
            };

            return personModel;
        }

        public static int TotalPersonCount()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Person.Count();
            }
        }
    }
}
