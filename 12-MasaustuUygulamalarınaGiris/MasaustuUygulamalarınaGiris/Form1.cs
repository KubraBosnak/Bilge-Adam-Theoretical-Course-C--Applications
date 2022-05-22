using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaustuUygulamalarınaGiris
{
    public partial class Form1 : Form
    {

        decimal sayi1 = 0;
        decimal sayi2 = 0;
        decimal sonuc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //text in içerisindeki sayi string olduğundan inte çevirmemiz gereklidir.
            //Console daki readline gibi çalışır. Readline methodtu. text özelliktir(propertydir)
            //İngiliz anahtarı property'dir. Kutu olanlar method  
            sayi1 =nudSayi1.Value;  
            sayi2 = decimal.Parse(txtSayi2.Text);

            sonuc = sayi1 + sayi2;
            lblSonuc.Text = sonuc.ToString();  //sonuc int tir ama lbl nin özelliği text olduğu için tostring ile sonucu label e text olarak yazdırırız
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            sayi1 = nudSayi1.Value;
            sayi2 = decimal.Parse(txtSayi2.Text);

            sonuc = sayi1 - sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = nudSayi1.Value;
            sayi2 = decimal.Parse(txtSayi2.Text);

            sonuc = sayi1 * sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            sayi1 = nudSayi1.Value;
            sayi2 = decimal.Parse(txtSayi2.Text);

            sonuc = sayi1 / sayi2;
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
