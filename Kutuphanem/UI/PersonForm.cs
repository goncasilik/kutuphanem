using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanem.UI
{
    public partial class PersonForm : Form
    {
        MyLibraryEntities db = new MyLibraryEntities();
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Person.ToList();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
