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
        MyLibraryEntities db = new MyLibraryEntities();
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminSayfa_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.metin;
            label7.Text = db.Person.Count().ToString();
            label8.Text = db.Author.Count().ToString();
            label9.Text = db.Book.Count().ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
