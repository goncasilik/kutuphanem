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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Person loggedPerson;

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Anasayfa anasayfa = new Anasayfa();
            AdminSayfa adminSayfa = new AdminSayfa();
            
            if (!(string.IsNullOrEmpty(textBox1.Text)) && !(string.IsNullOrEmpty(textBox2.Text))) // textboxlar dolu mu 
            {
                Person person = PersonHelper.Login(textBox1.Text, textBox2.Text); // kullanici adi ve sifre dogru mu
                if (person is Person)
                {
                    loggedPerson = person;
                    if (person.Role.Equals("Admin"))
                    {
                        adminSayfa.Show();
                    }
                    else
                    {
                        anasayfa.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız");
                }
            }
            else
            {
                MessageBox.Show("Boş Bırakılamaz!");
            }

            
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtOl = new KayıtOl();
            kayıtOl.Show();

        }
    }
}

