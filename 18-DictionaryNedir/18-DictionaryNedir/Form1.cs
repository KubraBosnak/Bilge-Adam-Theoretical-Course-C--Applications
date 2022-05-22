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

namespace _18_DictionaryNedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dict = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            dict.Add("table", "masa");
            dict.Add("car", "araba");
            dict.Add("pencil", "kalem");
            dict.Add("masa", "table");
            dict.Add("araba", "car");
            dict.Add("kalem", "pencil");
            AddToListBox();



        }

        private void AddToListBox()
        {
            lstWords.Items.Clear();
            foreach (KeyValuePair<string, string> item in dict)
            {
                //lstWords.Items.Add(item.Key);
                lstWords.Items.Add(item.Key + "-" + item.Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            string value = txtValue.Text;

            dict.Add(key, value);
            AddToListBox();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            string value = dict[keyword];

            MessageBox.Show($"{keyword} : {value}");
        }
    }
}


// KOLEKSİYONLAR

// Birden fazla aynı tipteki nesneleri (class) bir arada tutmamızı sağlayan yapılardır. String veya int de olabilir , class'ta olabilir.
// Örneğin ; Sınıfımızda bulunan öğrencilerin listesini hazırlamak istedğimizde;
// Öğrenci isimli bir class'ımızın olması gerekir.
// Öğrenci ; Adı-Soyadı-Sınıfı-Yaşı
// Her bir öğrenci bir nesneye karşılık geleceği için her öğrencimiz adına bir nesnemiz olmalıdır. 
// Oluşturduğumuz öğrencilerimizi bir arada tutan yapıya biz collection diyoruz.
// Adı - Soyadı - Sınıfı - Yaşı
// Ahmet - A    - 101    - 22 
// Mehmet - B   - 102    - 23
// Deniz  - C   - 103    - 24

// ARRAYLIST

// ArrayList: Dizinin benzeridir fakat sadece object tipinden verileri saklar. Dolayısıyla da gönderilen veri object değilse boxing işlemine tabi tutulur.
// * Belirli bir sınır vermemize gerek yoktur.
// * Yeni nesne eklendikçe boyutunu otomatikman arttırır.
// * Add , Remove, Sort ve indeksleme metotlarına sahip olması işlem yapmayı kolaylaştırır.

//private void Form1_Load(object sender, EventArgs e)
// {
//        ArrayList alist = new ArrayList();
//        alist.Add("Merhaba");
//        alist.Add(12);
//        alist.Add(new Button());
//        alist.Add(15.5m);
//        alist.Add(true);

//        foreach (object item in alist)
//        {
//        MessageBox.Show(item.GetType().ToString());
//        }

// }


// LIST

// List sınıfı ArrayList sınıfı gibi içerisinde object tipinde veri saklayabilen bir yapıdadır.
// Aralarındaki en büyük fark ArrayList sınıfı içerisine eklenen her türlü veriyi object tipinde saklarken-
// List yapısına saklayacağı verilerin tipi bilgi olarak verilebilir.
// Bu şekilde List Sınıfı içerisindeki verilerin tipleri bilindiği için herhangi bir tip dönüştürme işlemi kullanmadan direkt işleme sokulabilir.

// Kullanımı ;

// List<T> = new List <T>
// T => istenilen veri tipinin yazılacağı bölüm
