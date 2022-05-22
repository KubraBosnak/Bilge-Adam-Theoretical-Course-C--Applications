using System;

namespace _25_AlanHesaplayici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENÜ");
            Console.WriteLine("====");

            Console.WriteLine("[1] Kare Alan Hesapla");
            Console.WriteLine("[2] Dikdörtgen Alan Hesapla");
            Console.WriteLine("[3] Üçgen Alan Hesapla");
            Console.WriteLine("[0] Çıkış");
            Console.WriteLine();
            Console.WriteLine("Seçiminiz : ");
            string secim = Console.ReadLine();
            if (secim=="1")
            {
                Console.Write("Kare Kenar Uzunluğu Giriniz : ");
                string karekenar = Console.ReadLine();

                Kare kare = new Kare(); // Kare class ından bir kare nesnesi üretmek anlamındadır.
                kare.KenarA = int.Parse(karekenar);
                Console.WriteLine("Karenin Alanı : " + kare.AlanHesapla());
            }

            if (secim=="2")
            {
                Console.Write("1. Kenar Uzunluğunu Giriniz : ");
                string kenarA = Console.ReadLine();
                Console.Write("2. Kenar Uzunluğunu Giriniz : ");
                string kenarB = Console.ReadLine();

                Dikdortgen dikdortgen = new Dikdortgen();
                dikdortgen.KenarA = int.Parse(kenarA);
                dikdortgen.KenarB = int.Parse(kenarB);

                Console.WriteLine("Dikdörtgen Alan : " + dikdortgen.AlanHesapla());
            }

            if (secim=="3")
            {
                Console.Write("Taban Uzunluğu Giriniz : ");
                string kenarA = Console.ReadLine();

                Console.Write("Yüksekliği Giriniz : ");
                string height = Console.ReadLine();

                Ucgen ucgen = new Ucgen();
                ucgen.KenarA = int.Parse(kenarA);
                ucgen.Height = int.Parse(height);

                Console.WriteLine("Üçgenin Alanı : " + ucgen.AlanHesapla());
            }

            if (secim=="0")
            {
                
                Environment.Exit(0);
            }

            //Sekil sekil = new Sekil(); // Şekil classını abstract yaparsak class newlenemez.
         //   sekil.KenarA = 10;
           // sekil.AlanHesapla();
        }
    }
}
