using System;

namespace _05_HataYonetimi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HATA YÖNETİMİ");
            Console.WriteLine("=============");
            Console.WriteLine();

            // CTRL + SHIFT + B
            // Compiling Errors : Derleme Hataları

            // Runtime Hatası
            //int sayi = 1;
            //int sonuc = sayi / 0;

            //Logical Errors : if parantez hataları gibi

            try
            {
                Console.WriteLine("Sayı giriniz.");
                string sayiStr = Console.ReadLine();
                int sayi = int.Parse(sayiStr);


                if (sayi == 5)
                {
                    throw new Exception("Sayı 5 olamaz."); // Bilinçli hata fırlatma yöntemidir
                }
            }

            catch (Exception ex)  //hatayı yönetmek için yapılır.
            {
                Console.WriteLine(ex.Message);     // hatayı mesaj olarak verir
                Console.WriteLine(ex.StackTrace);  // hatayı satır numarasına kadar yazarak gösterir
                Console.WriteLine("Bir hata oluştu.");

                int s = 11;
                s = s / 0;  // bilerek hata yaptık, üstteki hatayı yakaladık ancak burada program.cs ye geri döndük

            }

            //catch 
            //{

            //    Console.WriteLine("Bir hata oluştu.");
            //}






            //if (sayi==10)
            //// Break point koyduktan sonra point üzerine sağ tıklayıp conditions a tıklayıp kodları durdurma değeri girebiliriz.
            //    Console.WriteLine("SMS atma kodları çalıştı.");

            //Console.WriteLine("Veritabanına veri yazma.");


            //Console.WriteLine();
            //Console.WriteLine("Kapatmak için bir tuşa basınız.");
            //Console.ReadKey();
        }
    }
}


// Projeyi duraklatmak için satırın sol başına bir kere tıklanması gerekir.
// AddWatch özelliği kullanılarak değişkenlere atanan değerleri altta açılan menü de görebiliriz
// Quick Watch özelliği ile de değerleri izleyebiliriz.
