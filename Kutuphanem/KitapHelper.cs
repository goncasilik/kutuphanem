using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem
{
    class KitapHelper
    {
        public static List<Kitap> KitapListele()
        {
            using (KutuphanemEntities db = new KutuphanemEntities())
            {
                return db.Kitap.ToList();
            }
        }
    }
}
