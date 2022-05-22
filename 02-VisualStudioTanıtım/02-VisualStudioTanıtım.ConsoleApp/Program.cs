using System;

namespace _02_VisualStudioTanıtım.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 03 TEMMUZ 2021 VISUAL STUDIO GİRİŞ EKRANI TANITIM
            // Proje ismini kaydederken Project Name kısmına, projenin tipine göre PhoneApp.ConsoleApp / PhoneApp.MobileApp / PhoneApp.WebApp yazılabilir.
            // Solution Name hepsinde PhoneApp olarak aynı kalıyor. Target Framework : .NET 5.0 (Current) seçilir
            // Projeye ismini verip kodlarını yazıp F5'E basıp çalıştırdığımızda VS kodu derliyor.
            // Derleyip kodlarınızı makina diline çeviriyor. Yani Intermediate Language (IL) ara diline çeviriyor.
            // Hataları bulmak için de arada çalıştırırız. Üstteki Build sekmesinin içindeki Build Solution'u seçerek derleyebiliriz.
            // Çıktıları Output penceresine yazar. Output penceresi görünmüyorsa View sekmesi içinden Outputu (CTRL+ALT+O) seçeriz.
            // dll dosyası kütüphanedir.
            // exe dosyası çalıştırılabilirdir.
            // Output Ekranında
            // Derleme Yapılmışsa ; Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped
            // Derleme Tekrarlanmışsa ; Build: 0 succeeded, 0 failed, 1 up-to-date, 0 skipped
            // Derleme Yeniden Yapılmışsa ; Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped
            // .sln dosyası solution dosyasıdır.
            // .csproj projenin dosyasıdır. VS'de görünmez.
            // .cs dosyasıda kodları yazdığımız dosyadır.
            // .NET Core projelerinde dll olarak derlenir.dll'ler kütüphanedir. exe çalıştırılabilir dosyadır.
            // MAC'te exe bulunmaz, dll ile çalıştırılır. Girişte core projesi seçmeseydik, yani Lnux, MAC'te çalışan projeyi seçmeseydik
            // sadece Windows projesi açsaydık Console'un o .NET Framework lü halini seçseydik sadece exe oluşurdu. dll oluşmazdı.
            // Nedeni windows da çalışan versiyon. Windows'ta exe ile çalışılır.
            // Proje birine verildiğinde exe doyasının verilmesi yeterlidir.
            // Debug Mod: Çalışma modu
            // Release Mod: Gerçek mod, test modu Release modda çalıştırılırken de Bin dosyası içinde Release dosyası açılır ve
            // Debug dosyası ile aynı programlar kaydedilir
            // Clean solutioan a tıklanırsa exe ve dll doyalarını siler.
            int sayi = 10;
            decimal sonuc = sayi / 2; // Hatalı bir kod yazıldığında Continue ' ya basılırsa hatayı ekrana yazar.
            Console.WriteLine(sonuc);
            Console.ReadKey(); // Klavyeden herhangi bir tuşa basılmasını bekletir.
            Console.WriteLine("Hello World!");

        }
    }
}
