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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            AdminSayfa adminSayfa = new AdminSayfa();
            if (!(string.IsNullOrEmpty(textBox1.Text)) && !(string.IsNullOrEmpty(textBox2.Text))) // textboxlar dolu mu 
            {
                bool kontrol = KullaniciHelper.KullaniciGirisKontrolu(textBox1.Text, textBox2.Text); // kullanici adi ve sifre dogru mu
                if (kontrol)
                {
                    if (KullaniciHelper.KullaniciRolu(textBox1.Text).Equals("admin"))
                    {
                        adminSayfa.Show();
                    }
                    else
                    {
                        anasayfa.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız");
                }
            }
            else
            {
                MessageBox.Show("Boş Bırakılamaz!");
            }
        }
    }
}

