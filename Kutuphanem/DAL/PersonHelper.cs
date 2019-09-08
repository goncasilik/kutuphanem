using Kutuphanem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.DAL
{
    class PersonHelper
    {
        public static PersonModel GetPersonWithBooks()
        {
            try
            {
                using (MyLibraryEntities db = new MyLibraryEntities())
                {
                    Person person = db.Person
                        .Where(p => p.PersonID == 1) // change this
                        .First();

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
    }   
}
