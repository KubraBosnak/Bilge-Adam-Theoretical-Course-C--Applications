using System;

namespace _08_Diziler.ConsoleApp
{
    class Program
    {

        static void BaslikYaz(string baslik) //ana methodumuz static tir
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
            Console.Write("=");

            }

            Console.WriteLine();
            Console.WriteLine();

        }
        static void DizilerGiris()
        
        {
            // DİZİ (ARRAY) NEDİR?
            // Birden fazla aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelerimizdir.
            // Dizilerin tanımlanma şekli

            // VeriTipi[] Değişkenin Adı = {Değer0,Değer1,Değer2,Değer3,Değer4}

            // Dizi [0] = 10
            // Dizi [1] = 20
            // Dizi [2] = 30
            // Dizi [3] = 40
            // Dizi [4] = 50

            //string[] ogrenciler = { "Ogrenci1, Ogrenci2, Ogrenci3, Ogrenci4, Ogrenci5" };

            //foreach (string ogreci in ogrenciler)
            //{
            //    System.Console.WriteLine(ogreci);
            //}

            //ARRAY SINIFI NEDİR?

            // Diziler, .NET Framework içinde tanımlı ARRAY SINIFI temsil eder. Tüm diziler Array sınıfında tanımlı özellikleri ve metotları kullanırlar.

            // Bu metotlardan ve özelliklerden en sık kullanılanları şunlardır.

            // Length   : Dizinin eleman sayısını verir.
            // Reverse  : Diziyi tersine çevirir.
            // Sort     : Diziyi sıralama işi yapar.
            // Clear    : Dizinin elamanlarını boşaltır.
            // IndexOf  : Dizi içerisinde verilen değerin index numarasını getirir.


            // BAŞTAN VERİLER İLE BOYUTLANDIRMA İLE DİZİ OLUŞTURMA

            int[] sayilar = new int[] { 3, 4, 5, 6, 7 };   //lenght=5

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //Console.WriteLine("Sayılar:");
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine(sayilar[4]);
            Console.WriteLine("Dizi Boyutu : " + sayilar.Length);

            // Resize : Diziyi Boyutlandırma
            // Resize : bir diziyi boyutlandırmak istediğimizde kullandığımız methodtur.

            // Resize küçültme de yapar ama küçültme sonrası kırpılan satırların değeri tipin varsayılanı olur.
            Array.Resize(ref sayilar, 3);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            Console.WriteLine("Dizi Boyutu : " + sayilar.Length);

            Array.Resize(ref sayilar, 7);

            // 7 dizinin eleman sayısıdır.

            sayilar[5] = 65;                         // diziler tanımlanırken sabit bir şekilde tanımlandığı için diziye bu şekilde sonradan eleman atayamıyoruz.
            sayilar[6] = 100;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //Console.WriteLine();
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine(sayilar[4]);
            //Console.WriteLine(sayilar[5]);           // dizilerin eleman sayısını arttırmak istersek resize yapmak zorundayız.
            //Console.WriteLine(sayilar[6]);


            Console.WriteLine("Dizi Boyutu : " + sayilar.Length);

            // RAM'de iki bölge vardır. STACK ve HEAP. Basit tipler stack'te, karmaşık tipler heap'te tutulur. 
            // STACK : int sayi, bool secim, char harf='c', byte gun=2, tarih-addr=746GJ, sayilar-addr=ah65 gibi
            // HEAP  : DateTime tarih, int[] sayilar 




            //BAŞTAN BOYUTLANDIRMA İLE DİZİ OLUŞTURMA
        }



        static void Main(string[] args)    // void değer döndürmeyen methoddur. Değer döndürüyorsa void yerine döndürdüğü değerin veri tipi yazılır
        {
            BaslikYaz("DİZİLER");

            DizilerGiris();   //eğer bu method un başına gelip // yorum satırına alırsak bu methodun içerisindeki hiç bir kodu çalıştırmaz
            DizilerGelismis();
            Kapanis();

        }

        static void Kapanis()
        {
            Console.WriteLine("Kapatmak için bir tuşa basınız.");
            Console.ReadKey();
        }

        static void DizilerGelismis()
        {
            int[] sayilar2 = new int[5];
            Console.WriteLine("Lütfen 5 adet 0-100 (0 ve 100 dahil değildir) arası sayı giriniz.");

            int toplam = 0;

            for (int i = 0; i < sayilar2.Length; i++)
            {
                int sayi = 0;
                do
                {
                    Console.Write((i + 1) + ".sayıyı giriniz : ");

                    try
                    {
                        sayi = int.Parse(Console.ReadLine());
                        if (sayi <= 0 || sayi >= 100)
                        {
                            Console.WriteLine("Koşula uygun sayı giriniz.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Sadece sayı giriniz.");
                    }


                } while (sayi <= 0 || sayi >= 100);

                // && (ve)   : tüm şartlar sağlanırsa dön.
                // || (yada) : şartlardan birinin sağlanması döngünün dönmesine yeterdir.

                sayilar2[i] = sayi;

                toplam += sayilar2[i];

            }
            //int toplam = 0;
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    toplam += sayilar2[i];
            //}
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz sayıların toplamı : " + toplam);

            Console.WriteLine();
            Console.WriteLine("============================");

            Array.Sort(sayilar2);     // Sort    : küçükten büyüğe sıralar
            Array.Reverse(sayilar2);  // Reverse : sort ile sıralanan diziyi tersine çevirir.

            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Lütfen dizideki sayılardan birini giriniz : ");
            int deger = int.Parse(Console.ReadLine());

            // BİRDEN FAZLA AYNI DEĞERDE SAYI GİRİLDİ İSE INDEX NUMARALARINI VERMESİ İÇİN AŞAĞIDAKİ FOR DÖNGÜSÜ YAZILIR.
            // 1 .YÖNTEM FOR DÖNGÜSÜ
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    if (sayilar2[i]==deger)
            //    {
            //        Console.WriteLine("Girdiğiniz sayının indexi : "+i);
            //    }
            //}
            //  Console.WriteLine("Girdiğiniz sayının index'i : "+Array.IndexOf(sayilar2,deger));

            int startIndex = 0;
            while (Array.IndexOf(sayilar2, deger, startIndex) > -1)
            {
                int index = Array.IndexOf(sayilar2, deger, startIndex);
                Console.WriteLine("Girdiğiniz Sayının Index'i :" + index);
                startIndex = ++index;
            }
        }
    }
}
