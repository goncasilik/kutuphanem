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
    public partial class Yazarlar : Form
    {
        private void ListAuthors()
        {
            dataGridView1.DataSource = AuthorHelper.ListAuthors();
        }

        public Yazarlar()
        {
            InitializeComponent();
        }

        private void Yazarlar_Load(object sender, EventArgs e)
        {
            ListAuthors();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author
            {
                Name = textBox2.Text
            };
            AuthorHelper.AddAuthor(newAuthor);
            ListAuthors();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
