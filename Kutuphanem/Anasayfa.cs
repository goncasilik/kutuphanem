using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanem
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            List<Kitap> kitapListesi = KitapHelper.KitapListele();
            foreach (var kitap in kitapListesi)
            {
                listBox1.Items.Add(kitap.kitapAdi);
            }
        }
    }
}
