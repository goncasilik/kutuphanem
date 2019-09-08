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
        MyLibraryEntities db = new MyLibraryEntities();

        public KitapTuru()
        {
            InitializeComponent();
        }

        private void KitapTuru_Load(object sender, EventArgs e)
        {
            Genre tur = new Genre();
            dataGridView1.DataSource = db.Genre.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Genre newGenre = new Genre();
            newGenre.Name = textBox2.Text;
            db.Genre.Add(newGenre);
            db.SaveChanges();
            dataGridView1.DataSource = db.Genre.ToList();
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
