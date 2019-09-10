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
    public partial class KayıtOl : Form
    {
        MyLibraryEntities db = new MyLibraryEntities();
        public KayıtOl()
        {
            InitializeComponent();
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.Email = textBox1.Text;
            newPerson.FirstName = textBox2.Text;
            newPerson.LastName = textBox3.Text;
            newPerson.Password = textBox4.Text;
            newPerson.Role = "User";
            
            db.Person.Add(newPerson);
            db.SaveChanges();
        }
    }
}
