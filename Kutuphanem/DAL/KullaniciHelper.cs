using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem
{
    class KullaniciHelper
    {
        public static bool Login(string email, string password)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Person kullanici = db.Person.Where(p => p.Email.Equals(email)).FirstOrDefault();
                if (kullanici != null)
                {
                    if (kullanici.Password.Equals(password))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public static string PersonRole(string email)
        {
            using(MyLibraryEntities db = new MyLibraryEntities())
            {
                Person person = db.Person.Where(p => p.Email.Equals(email)).FirstOrDefault();

                return person.Role;

            }
        }

        public static List<Person> ListPersons()
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                return db.Person.ToList();
            }
        }

        public static string GetName(string email)
        {
            using (MyLibraryEntities db = new MyLibraryEntities())
            {
                Person person = db.Person.Where(p => p.Email.Equals(email)).FirstOrDefault();

                return person.FirstName;

            }
        }
    }
}
