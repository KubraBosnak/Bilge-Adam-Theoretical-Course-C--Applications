using System;

namespace _11_ClassKavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConsoleHelper myConsole = new MyConsoleHelper();

            myConsole.BaslikYaz("CLASS KAVRAMI");

            TryParseOrnek1();
            TryParseOrnek2();
            // CLASS KAVRAMI
            // REFERENCE AND VALUE TYPE
            // Value type lar stack te durur. Int, double--->Reference type ların adresleri STACK'te tutulur.
            // Reference type lar heap de durur. DateTime, diziler,  --> New'lenen nesneler HEAP'te tutulur.
            // MASAÜSTÜ UYGULAMALARINA GİRİŞ
            // Masaüstü uygulaması : masaüstü bilgisayarınız, dizüstü bilgisayarınızı veya genel amaçlı bir bilgisayar dahil, standart bilgisayarlarda çalışacak yazılımları yazma süreci için kullanılan geniş bir terimdir. Geliştirilmekte olan yazılım, işetim sisteminize veya uygulama yazılımınıza yardımcı olacak sistem yazılımı olabilir. Uygulama yazılımı, tek yada bir dizi görevi gerçekleştirmek amacıyla tasarlanmıştır ve oyunlar, kelime işlemciler ve kuruluşlar için özelleştirilmiş uygulamalar gibi şeyleri içerir.


            //string tamAd = myConsole.KelimeleriBirlestir("Murat", "Baseren");
            //Console.WriteLine(tamAd);

            //string tamAd2 = myConsole.KelimeleriBirlestir("Kadir", "Başeren");
            //Console.WriteLine(tamAd2);

            //Random rnd = new Random();
            //int rastgele= rnd.Next(10, 30);

            //myConsole.EkranaYaz("Rastgele : " + rastgele);



            Hesaplayici h = new Hesaplayici();
            int sonuc = h.Topla(4, 5);
            myConsole.EkranaYaz(sonuc.ToString());



            Console.WriteLine("Lütfen kapatmak için bir tuşa basınız.");
            Console.ReadKey(); // herhangi bir tuşa basmamızı bekler.

        }

        private static void TryParseOrnek2()
        {
            int sayiSonuc = 0;
            string sayiStr = "";
            bool result = false;

            do
            {
                Console.WriteLine("Sayı Giriniz : ");
                sayiStr = Console.ReadLine();

                result = int.TryParse(sayiStr, out sayiSonuc);
                if (result==false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen sayı giriniz.");
                }

                // TryParse : Eğer sayiStr'yi int'e dönüştürebilirse, sayiSonuc değişkenine int olarak atar ve true döner.
                // Eğer sayiStr'yi int'e dönüştüremezse geriye false döner ve sayiSonuc değişkenine dokunmaz.

            } while (result==false);

            Console.WriteLine("Girilen değerin 10 fazlası : "+(sayiSonuc+10));

        }
        private static void TryParseOrnek1()
        {
            int sayiSonuc = 0;
            string sayiStr = "";

            do
            {
                Console.Write("Sayı giriniz : ");
                sayiStr = Console.ReadLine();

                // TryParse : Eğer sayiStr'yi int'e dönüştürebilirse, sayiSonuc değişkenine int olarak atar ve true döner.
                // Eğer sayiStr'yi int'e dönüştüremezse geriye false döner ve sayiSonuc değişkenine dokunmaz.

            } while (int.TryParse(sayiStr,out sayiSonuc)==false);
        
        
        
        }
       
        }
}
