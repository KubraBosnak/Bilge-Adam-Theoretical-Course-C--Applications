using System;

namespace _09_Metodlar
{
    class Program
    {   
        static int Carpma(params int[] degerler)
        {
            int sonuc = 1;
            for (int i = 0; i < degerler.Length; i++)
            {
                sonuc *= degerler[i];
            }
            return sonuc;
        }
        // Carpma(int,int)
        static int Carpma(int sayi1, int sayi2)

        {
            int Sonuc = sayi1 * sayi2;
            return Sonuc;

        }

        static int Topla(int sayi1 = 0, int sayi2 = 0)

        {
            int Sonuc = sayi1 + sayi2;
            return Sonuc;

        }

        static int Topla2(int[] sayilar)
        {
            int sonuc = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }

            return sonuc;

        }
        static int Topla3(params int[] sayilar)
        {
            int sonuc = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }

            return sonuc;

        }

        static void DiziyiYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                //String İnterpolation in C#
                Console.WriteLine($"{i+1}.sayı:{dizi[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("METODLAR");
            Console.WriteLine("========");
            Console.WriteLine();

            //ToplaMetodOrnegi();
            //ToplaDiziOrnegi();
            //RandomKullanımı();


            //Metod Overloading : aynı isimli ve farklı imzalı metod yazma olayı
            Console.WriteLine(Carpma(5,4));
            Console.WriteLine(Carpma(3,4,5));
            Console.WriteLine(Carpma(123,4565,789));

            Console.WriteLine();
            Console.WriteLine("Kapatmak için lütfen bir tuşa basınız.");
            Console.ReadKey();

        }

        private static void RandomKullanımı()
        {
            Random random = new Random();
            int count = random.Next(10, 20);
            int[] sayilar = new int[count];


            for (int i = 0; i < count; i++)
            {
                sayilar[i] = random.Next(100, 300);
            }


            DiziyiYaz(sayilar);


            int toplam = Topla3(sayilar);
            Console.WriteLine("Toplam :" + toplam);
        }

        private static void ToplaDiziOrnegi()
        {
            Console.WriteLine("Lütfen kaç adet sayı gireceğinizi yazınız");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] sayilar = new int[count];

            //for (int i = 0; i < count; i++) // Aşağıdaki  for ile aynı işlevdedir.

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine((i + 1) + ".sayı : ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int toplam = Topla2(sayilar);


            Console.WriteLine();
            Console.WriteLine("Toplam : " + toplam);
        }

        private static void ToplaMetodOrnegi()
        {
            Console.WriteLine("Lütfen toplama işlemi için sayıları giriniz.");
            Console.Write("1. Sayınız : ");
            int deger1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayınız : ");
            int deger2 = int.Parse(Console.ReadLine());

            int toplam = Topla(deger1, deger2);
            Console.WriteLine();
            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
