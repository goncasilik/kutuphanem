using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.Model
{
    class GenreModel
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
