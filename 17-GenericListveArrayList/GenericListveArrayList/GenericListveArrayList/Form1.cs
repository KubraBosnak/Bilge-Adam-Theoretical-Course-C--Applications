using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GenericListveArrayList
{
    public partial class Form1 : Form
    {
        public Form1() // Constructor : Belirli bir sınıfta bir nesne oluşturmak için tasarlanmış bir alt program.
                      
        {
            InitializeComponent();  //Bileşeni Başlatma
        }

        // KOLEKSİYONLAR : Dizilerin geliştirilmiş halidir. Arraylist ve Generic'ten oluşur. İçerisinde birden çok farklı türde dizi ve liste barındırabilir.
        // ---> ArrayList
        // ---> Generic
        //      ---> Dictionary
        //      ---> Stack
        //      ---> Queue
        //      ---> Hashset

        // NORMAL DİZİ İLE EKLEME 

        string[] veriler = new string[0]; // Veriler dizisini oluşturduk, başlangıçtaki eleman sayısı 0. Class seviyesinde tanımlanmıştır.Bütün methodlar bu diziye erişebilir
        private void btnEkle_Click(object sender, EventArgs e) // Butona tıklanınca veriler dizisine eleman atılacak.
        {
            //Diziye her tıklanıp içine veri atabilmemiz için diziyi resize etmek zorundayız.

            Array.Resize(ref veriler, veriler.Length + 1); //Veriler dizisinin boyutu sıfırdı. +1 ile 1 kez arttırdık.
            veriler[veriler.Length - 1] = txtVeri.Text; // Textbox a girilen verinin son elemana ekleme yapması için veriler dizisinin ilk elemanına yazdırmak için -1 ile çıkarırız

            //for (int i = 0; i < veriler.Length; i++)
            //{
            //    string item = veriler[i]; // Textboxa girilip veriler dizisindeki değeri alıp item değişkenine atar.
            //    lstVeriler.Items.Add(item);
            //}

            AddToListbox(veriler);
        }
        // Parametre olarak string[] ile çalışır.
        private void AddToListbox(string[] dizi) // DİZİ ALAN LİSTBOXA YAZDIRMA VERSİYONU Bu method çağırıldığında veri dizi isimli diziye atılır ve veriler koleksiyonuna yazılarak Listboxa yazdırılır.
        {
            lstVeriler.Items.Clear();

            foreach (string item in dizi) 
            {
                lstVeriler.Items.Add(item);
            }
        }
        //Parametre olarak Arraylist ile çalışır
        private void AddToListbox(ArrayList dizi) //ARRAY LİST ALAN LİSTBOXA YAZDIRMA VERSİYONU
        {
            lstVeriler.Items.Clear();

            foreach (object item in dizi)
            {
                lstVeriler.Items.Add(item);
            }
        }
        //Parametre olarak Arraylist ile çalışır
        private void AddToListbox(List<string> dizi) //ARRAY LİST ALAN LİSTBOXA YAZDIRMA VERSİYONU
        {
            lstVeriler.Items.Clear();

            foreach (string item in dizi)
            {
                lstVeriler.Items.Add(item);
            }
        }
        ArrayList list = new ArrayList(); // Arraylist koleksiyonunu oluşturduk
        // Arraylistler dizilerden sonra geliştirilmiştir. Ve yukarıda normal dizilerde yaptığımız gibi her hangi bir boyutlandırma yapılmaması en büyük avantajıdır.

        // 1. index kullanmadan işlem yapma
        // 2. resize işlemi yapmama - capacity kavramı ile kendi optimum performans sağlama
        // 3. tip bağımsızlığı sağlama

        private void btnArrayEkle_Click(object sender, EventArgs e)
        {
            list.Add(txtVeri.Text);
            AddToListbox(list);
        }

        List<string> liste2 = new List<string>();

        private void btnListEkle_Click(object sender, EventArgs e)
        {
            liste2.Add(txtVeri.Text);
            AddToListbox(liste2);
        }

        private void btnListSort_Click(object sender, EventArgs e)
        {
            liste2.Sort();
            AddToListbox(liste2);
        }

        private void btnListReverse_Click(object sender, EventArgs e)
        {
            liste2.Reverse();
            AddToListbox(liste2);
        }

        private void btnListRemove_Click(object sender, EventArgs e)
        {
            string item = lstVeriler.SelectedItem.ToString();
            liste2.Remove(item);

            //int index = lstVeriler.SelectedIndex;   // Bu iki formülde silme işlemi yapar
            //liste2.RemoveAt(index);

            AddToListbox(liste2);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstVeriler.SelectedIndex;
            liste2[index] = txtYeniVeri.Text;

            AddToListbox(liste2);
        }
    }
}
