using Kutuphanem.Model;
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
            label4.Text = Form1.metin;
            listBox1.DataSource = KitapHelper.ListBooks();
            LoadMyLibrary();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BookModel bookModel = (BookModel)listBox1.SelectedItem;
            bool isAdded = DAL.MyLibraryHelper.AddBookToMyLibrary(Convert.ToInt32(bookModel.BookID));
            if (isAdded)
            {
                LoadMyLibrary();
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadMyLibrary()
        {
            PersonModel personModel = DAL.PersonHelper.GetPersonWithBooks();
            listBox2.DataSource = KitapHelper.MapBookEntity(personModel.Books);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
