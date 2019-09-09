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
            
            LoadMyLibrary();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BookModel bookModel = (BookModel)comboBox1.SelectedItem;
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = KitapHelper.ListBooks(textBox1.Text);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookModel bookModel = (BookModel)comboBox1.SelectedItem;
            label9.Text = bookModel.Name;
            label10.Text = string.Join(", ", bookModel.Authors.Select(author => author.Name));
            label11.Text = string.Join("-", bookModel.Genres.Select(genre => genre.Name));
            label12.Text = bookModel.PageCount.ToString();
            label13.Text = bookModel.BookID.ToString();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }
    }
}
