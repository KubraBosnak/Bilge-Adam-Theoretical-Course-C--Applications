using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22.KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Book> books = new List<Book>();

        private void Form1_Load(object sender, EventArgs e)
        {
        //    Book book1 = new Book();
        //    book1.BookName = "Da Vinci Code";
        //    book1.AuthorName = "Dan Brown";
        //    book1.PageCount = 200;
        //    book1.PublishedDate = new DateTime(2000, 4, 1);
        //    book1.IsSale = true;

        //    books.Add(book1);


        //    Book book2 = new Book();
        //    book2.BookName = "Da Vinci Code";
        //    book2.AuthorName = "Dan Brown";
        //    book2.PageCount = 200;
        //    book2.PublishedDate = new DateTime(2000, 4, 1);
        //    book2.IsSale = true;

        //    books.Add(book2);
        //    MessageBox.Show(book2.BookName+","+book2.AuthorName+"eklendi.");

        //    // Nesne Oluşturma ve List'e ekleme yöntem 2 
        //    Book book3 = new Book()
        //    {
        //        BookName = "Yüzüklerin Efendisi",
        //        AuthorName = "J.R. Tolkien",
        //        PageCount = 100,
        //        PublishedDate = new DateTime(2002, 12, 2),
        //        IsSale = false

        //    };

        //    books.Add(book3);
        //    MessageBox.Show(book3.BookName+", "+book3.AuthorName+"eklendi");
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    Book book = new Book()
        //    {
        //        BookName = txtBookName.Text,
        //        AuthorName = txtAuthorName.Text,
        //        PageCount = (int)nudPageCount.Value,
        //        PublishedDate = dtpPublishDate.Value,
        //        IsSale = chkIsSale.Checked

        //    };
        //    books.Add(book);
        //    MessageBox.Show(book.BookName + ", " + book.AuthorName + "eklendi.");

            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookName = txtBookName.Text,
                AuthorName = txtAuthorName.Text,
                PageCount=(int)nudPageCount.Value,
                PublishedDate=dtpPublishDate.Value,
                IsSale=chkIsSale.Checked

            };
        }
    }
}
