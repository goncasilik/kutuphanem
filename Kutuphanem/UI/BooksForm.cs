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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            List<AuthorModel> authors = AuthorHelper.MapAuthorEntity(AuthorHelper.ListAuthors());
            listBox1.DataSource = authors;
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            List<GenreModel> genres = GenreHelper.MapGenreEntity(GenreHelper.ListGenres());
            listBox2.DataSource = genres;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Book newBook = new Book
            {
                Name = textBox1.Text
            };

            List<Author> authors = new List<Author>();

            foreach (var item in listBox1.SelectedItems)
            {
                authors.Add(AuthorHelper.MapAuthorModel((AuthorModel)item));
            }

            newBook.Authors = authors;

            List<Genre> genres = new List<Genre>();

            foreach (var item in listBox2.SelectedItems)
            {
                genres.Add(GenreHelper.MapGenreModel((GenreModel)(item)));
            }

            newBook.Genres = genres;
            newBook.PageCount = Convert.ToInt32(textBox2.Text);

            bool isAdded = BookHelper.Addbook(newBook);

            if (isAdded)
            {
                // load
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
