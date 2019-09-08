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
            List<Author> authors = YazarHelper.ListAuthors();
            foreach (var author in authors)
            {
                comboBox1.Items.Add(author.Name);
            }
        }
    }
}
