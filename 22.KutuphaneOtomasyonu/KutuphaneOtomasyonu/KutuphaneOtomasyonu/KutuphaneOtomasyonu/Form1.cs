using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
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
            //Book book1 = new Book();
            //book1.BookName = "Da Vinci Code";
            //book1.AuthorName = "Dan Brown";
            //book1.PageCount = 200;
            //book1.PublishedDate = new DateTime(2000, 4, 1);
            //book1.IsSale = true;

            //books.Add(book1);

            //// nesne oluşturma ve list e ekleme yöntem 1
            //Book book2 = new Book();
            //book2.BookName = "Da Vinci Code2";
            //book2.AuthorName = "Dan Brown 2";
            //book2.PageCount = 300;
            //book2.PublishedDate = new DateTime(2010, 3, 3);
            //book2.IsSale = false;

            //books.Add(book2);
            //MessageBox.Show(book2.BookName + ", " + book2.AuthorName + " eklendi.");

            ////Book book3 = new Book()
            ////{
            ////    BookName = "Yüzüklerin Efendisi",
            ////    AuthorName = "J.R. Tolkien",
            ////    PageCount = 100,
            ////    PublishedDate = new DateTime(2002, 12, 2),
            ////    IsSale = false
            ////};

            //books.Add(new Book()
            //{
            //    BookName = "Yüzüklerin Efendisi",
            //    AuthorName = "J.R. Tolkien",
            //    PageCount = 100,
            //    PublishedDate = new DateTime(2002, 12, 2),
            //    IsSale = false
            //});

            ////MessageBox.Show(book3.BookName + ", " + book3.AuthorName + " eklendi.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookName = txtBookName.Text,
                AuthorName = txtAuthorName.Text,
                PageCount = (int)nudPageCount.Value,
                PublishedDate = dtpPublishDate.Value,
                IsSale = chkIsSale.Checked
            };

            books.Add(book);
            MessageBox.Show(book.BookName + ", " + book.AuthorName + " eklendi.");

            //books.Add(new Book()
            //{
            //    BookName = txtBookName.Text,
            //    AuthorName = txtAuthorName.Text,
            //    PageCount = (int)nudPageCount.Value,
            //    PublishedDate = dtpPublishDate.Value,
            //    IsSale = chkIsSale.Checked
            //});

            //MessageBox.Show(txtBookName.Text + ", " + txtAuthorName.Text + " eklendi.");

            LoadToListView();
        }

        public void LoadToListView()
        {
            lvBooks.Items.Clear();

            foreach (Book book in books)
            {
                string saleStr = (book.IsSale) ? "Evet" : "Hayır";

                ListViewItem item = new ListViewItem(book.BookName, 0);
                item.SubItems.Add(book.AuthorName);
                item.SubItems.Add(book.PageCount.ToString());
                item.SubItems.Add(book.PublishedDate.ToShortDateString());
                item.SubItems.Add(saleStr);
                //item.SubItems.Add((book.IsSale) ? "Evet" : "Hayır");

                lvBooks.Items.Add(item);
            }
        }

        private void cmbListViewTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbListViewTypes.Text;

            switch (type)
            {
                case "Large Icon":
                    lvBooks.View = View.LargeIcon;
                    break;

                case "Small Icon":
                    lvBooks.View = View.SmallIcon;
                    break;

                case "List":
                    lvBooks.View = View.List;
                    break;

                case "Tile":
                    lvBooks.View = View.Tile;
                    break;

                case "Details":
                    lvBooks.View = View.Details;
                    break;

                default:
                    break;
            }
        }

        private void mnuNewBook_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            Form2 frmNewBook = new Form2();
            //frmNewBook.Show();            // kullanıcı kapatmadan önceki forma geçebilir.
            DialogResult result = frmNewBook.ShowDialog();    // kullanıcı kapatmadan önceki forma geçemez.

            //DialogResult result = MessageBox.Show("asdsa", "asddd", MessageBoxButtons.YesNo);

            if (result == DialogResult.OK)
            {
                books.Add(new Book()
                {
                    //BookName = frmNewBook.BookName,
                    //AuthorName = frmNewBook.AuthorName,
                    //PageCount = frmNewBook.PageCount,
                    //PublishedDate = frmNewBook.PublishedDate,
                    //IsSale = frmNewBook.IsSale

                    BookName = frmNewBook.txtBookName.Text,
                    AuthorName = frmNewBook.txtAuthorName.Text,
                    PageCount = (int)frmNewBook.nudPageCount.Value,
                    PublishedDate = frmNewBook.dtpPublishDate.Value,
                    IsSale = frmNewBook.chkIsSale.Checked
                });

                LoadToListView();
            }
        }
    }
}
