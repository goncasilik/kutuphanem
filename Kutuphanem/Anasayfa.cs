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
                listBox1.Items.Add(new KitapItem
                {
                    kitapAdi = kitap.kitapAdi,
                    kitapID = kitap.kitapID.ToString()
                });

                listBox1.DisplayMember = kitap.kitapAdi;
                listBox1.ValueMember = kitap.kitapID.ToString();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedValue);
        }
    }

    class KitapItem
    {
        public string kitapAdi { get; set; }
        public string kitapID { get; set; }
        public override string ToString()
        {
            return kitapAdi;
        }
    }
}
