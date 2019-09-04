using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem
{
    class KitabımHelper
    {
        public static void KitapEkle(int kitapID, int kullaniciID)
        {
            using (KutuphanemEntities db = new KutuphanemEntities())
            {
                Kitabım kitabım = new Kitabım(); // oluşturma
                kitabım.kitapID = kitapID;
                //kitabım.kullaniciID = kullaniciID;
                kitabım.kullaniciID = 1;
                kitabım.durum = "okundu";

                db.Kitabım.Add(kitabım); //ekleme

                db.SaveChanges(); // kaydetme
            }
        }
    }
}
