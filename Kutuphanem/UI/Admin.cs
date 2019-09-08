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
    public partial class AdminSayfa : Form
    {
        public AdminSayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapTuru kitapturuform = new KitapTuru();
            kitapturuform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplarForm = new Kitaplar();
            kitaplarForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazarlar yazarlarForm = new Yazarlar();
            yazarlarForm.Show();
        }
    }
}
