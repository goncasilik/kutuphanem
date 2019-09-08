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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            List<BookModel> bookList = KitapHelper.ListBooks();

            foreach (var book in bookList)
            {
                var bookItem = new BookItem();

                bookItem.bookName = book.Name;
                bookItem.bookID = book.BookID.ToString();

                foreach (var author in book.Authors)
                {
                    bookItem.authors.Add(author);
                }

                listBox1.Items.Add(bookItem);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BookItem bookItem = (BookItem)listBox1.SelectedItem;
            DAL.MyLibraryHelper.AddBookToMyLibrary(Convert.ToInt32(bookItem.bookID));
        }
    }

    class BookItem
    {
        public string bookName { get; set; }
        public string bookID { get; set; }

        public List<string> authors = new List<string>();
        public override string ToString()
        {
            string authorsString = "";

            foreach (var author in authors)
            {
                authorsString += "," + author;
            }
            return bookName + '-' + authorsString;
        }
    }
}
