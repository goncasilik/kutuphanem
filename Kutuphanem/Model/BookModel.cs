using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem.Model
{
    class BookModel
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public Nullable<int> PageCount { get; set; }

        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }

        public override string ToString()
        {
            return $"{Name} ({BookID})";
        }
    }
}
