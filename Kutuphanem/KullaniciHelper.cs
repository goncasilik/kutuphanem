using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanem
{
    class KullaniciHelper
    {
        public static bool KullaniciGirisKontrolu(string kullaniciAdi, string sifre)
        {
            using (KutuphanemEntities db = new KutuphanemEntities())
            {
                Kullanici kullanici = db.Kullanici.Where(k => k.kullaniciAdi.Equals(kullaniciAdi)).FirstOrDefault();
                if (kullanici != null)
                {
                    if (kullanici.sifre.Equals(sifre))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public static string KullaniciRolu(string kullaniciAdi)
        {
            using(KutuphanemEntities db = new KutuphanemEntities())
            {
                Kullanici kullanici = db.Kullanici.Where(k => k.kullaniciAdi.Equals(kullaniciAdi)).FirstOrDefault();

                return kullanici.rol;

            }
        }
    }
}
