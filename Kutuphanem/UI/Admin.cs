using Kutuphanem.UI;
using Kutuphanem.DAL;
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
        private static Person loggedPerson;

        public AdminSayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapTuru genreForm = new KitapTuru();
            genreForm.Show();

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
            loggedPerson = Form1.loggedPerson;
            label2.Text = loggedPerson.FirstName + " " + loggedPerson.LastName;

            label5.Text = GenreHelper.TotalGenreCount().ToString();
            label7.Text = PersonHelper.TotalPersonCount().ToString();
            label8.Text = AuthorHelper.TotalAuthorCount().ToString();
            label9.Text = BookHelper.TotalBookCount().ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PersonForm PersonForm = new PersonForm();
            PersonForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
