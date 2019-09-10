using Kutuphanem.DAL;
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
        private static Person loggedPerson;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            loggedPerson = Form1.loggedPerson;
            
            label4.Text = loggedPerson.FirstName + " " + loggedPerson.LastName;
            
            LoadMyLibrary();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BookModel bookModel = (BookModel)listBox1.SelectedItem;
            bool isAdded = MyLibraryHelper.AddBookToMyLibrary(Convert.ToInt32(bookModel.BookID), loggedPerson.PersonID);
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
            PersonModel personModel = PersonHelper.GetPersonWithBooks(loggedPerson.PersonID); // kişinin id bilgisine göre kitap listesini doldurur
            listBox2.DataSource = BookHelper.MapBookEntity(personModel.Books);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = BookHelper.ListBooks(textBox1.Text);
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            BookModel bookModel = (BookModel)listBox1.SelectedItem;
            label9.Text = bookModel.Name;
            label10.Text = string.Join(", ", bookModel.Authors.Select(author => author.Name));
            label11.Text = string.Join("-", bookModel.Genres.Select(genre => genre.Name));
            label12.Text = bookModel.PageCount.ToString();
            label13.Text = bookModel.BookID.ToString();
        }
    }
}
