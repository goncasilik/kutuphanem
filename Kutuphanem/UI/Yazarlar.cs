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
        MyLibraryEntities db = new MyLibraryEntities();

        public Yazarlar()
        {
            InitializeComponent();
        }

        private void Yazarlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Author.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();
            newAuthor.Name = textBox2.Text;
            db.Author.Add(newAuthor);
            db.SaveChanges();
            dataGridView1.DataSource = db.Author.ToList();
        }
    }
}
