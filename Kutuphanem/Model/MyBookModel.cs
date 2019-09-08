using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.Model
{
    class MyBookModel
    {
        public int MybookID { get; set; }
        public int BookID { get; set; }
        public int PersonID { get; set; }
        public string Status { get; set; }

        public Book Book = new Book();
        public Person Person = new Person();
    }
}
