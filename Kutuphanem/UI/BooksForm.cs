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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            List<Author> authors = AuthorHelper.ListAuthors();
            //comboBox1.DataSource = authors;
            foreach (var author in authors)
            {
                comboBox1.Items.Add(author.Name);
            }

            List<Genre> genres = GenreHelper.ListGenres();
            //comboBox2.DataSource = genres;
            foreach (var genre in genres)
            {
                comboBox2.Items.Add(genre.Name);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox3.Text = openFileDialog1.FileName;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
