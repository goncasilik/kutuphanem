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
    public partial class KitapTuru : Form
    {
        public KitapTuru()
        {
            InitializeComponent();
        }

        private void ListGenres()
        {
            dataGridView1.DataSource = GenreHelper.ListGenres();
        }

        private void KitapTuru_Load(object sender, EventArgs e)
        {
            ListGenres();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Genre newGenre = new Genre
            {
                Name = textBox2.Text
            };
            GenreHelper.AddGenre(newGenre);
            ListGenres();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //KitapHelper.TurSil();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
