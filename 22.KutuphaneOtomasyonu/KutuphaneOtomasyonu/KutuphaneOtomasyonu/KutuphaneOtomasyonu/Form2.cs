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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public string BookName;
        //public string AuthorName;
        //public int PageCount;
        //public DateTime PublishedDate;
        //public bool IsSale;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //BookName = txtBookName.Text;
            //AuthorName = txtAuthorName.Text;
            //PageCount = (int)nudPageCount.Value;
            //PublishedDate = dtpPublishDate.Value;
            //IsSale = chkIsSale.Checked;

            Close();
        }
    }
}
