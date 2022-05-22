using System;

namespace ProgramlamaBaslangic.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //29.06.2021 DERS NOTLARI

            //Değişkenlerin Kullanımı
            //   int sayi =   5  ;
            //    |    |       |  |   
            //   Tip   |       | İfade Sonu
            //         |      Atanan Değer
            //    Değişken Adı

            // Değişken İsimlendirme Kuralları
            // Değişken isimleri büyük küçük harf duyarlıdır.
            // Değişken isimlerinde boşluk bulunmaz
            // Değişken isimleri özel karakterler ile başlayamaz. Sadece "_" lullanılabilir.
            // Değişken isimleri sayı ile başlayamaz
            // Değişken isimleri Türkçe karakter içermemelidir
            // Değişken isimleri anahtar kelimeler olamaz
            // Değişken isimleri 255 karakterden fazla olamaz


            // Write : satır atlamadan metni yazar.
            // WriteLine : metni yazar ve satır atlar.
            // Clear : Ekranı temizler
            // "." : dedikten sonra intelligence klavye açılır ve ok tuşları ile ilerlenir. Metotlar üzerinde durulunca açıklaması görünür.Tab tuşu ile seçili olan item ekrana tamamlanır.
            // CTRL + Space : tuşu ile tekrar intelligence penceresi açılır.
            Console.WriteLine("Pencere Yüksekliği :");
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine();
            Console.WriteLine("Pencere Genişliği :");
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine();
            // CTRL + K + C :Yazılan kodları yorum satırına almak için
            // CTRL + K + U :Yazılan kodları yorum satırından çıkarmak için
            String metin = "Murat";
            int sayi = 3;
            float virgullu1 = 12.3f;
            double virgullu2 = 45.6;
            decimal virgullu3 = 78.9m;
            bool evetHayir1 = true;
            bool evetHayir2 = false;
            char karakter = 'c';
            DateTime tarihVeZaman = new DateTime(2020, 1, 1);
            //ReadLine : Kullanıcıdan istenen değeri kullanıcı girer ve enter a basılınca kullanıcının yazdığı metin okunur,tanımlanan değişkene atanır ve alt satıra geçilir.
            Console.WriteLine(tarihVeZaman);
            Console.WriteLine();

            Console.WriteLine("Lütfen Telefon Numaranızı Giriniz.");
            string phoneHome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Telefon Numaranız : ");
            Console.WriteLine(phoneHome);
            Console.Clear();
            Console.WriteLine("Yaşınızı Giriniz.");
            string yas = Console.ReadLine();
            int inteCevrilmisYas = int.Parse(yas);
            int result = inteCevrilmisYas + 1;
            Console.WriteLine("Yaşınızın bir fazlası" + result);
            Console.WriteLine("Doğum yılınız:" + (2021 - inteCevrilmisYas));
           
            Console.Title = "Kübra";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Yazı Rengi :" + Console.ForegroundColor);
            Console.ResetColor();
            Console.Beep(); // Ses çıkmasını sağlar
            Console.WriteLine("Ekran Genişliği :" + Console.WindowWidth);
            Console.WindowWidth = 50;
            Console.WriteLine("Ekran Yüksekliği :" + Console.WindowHeight);
            Console.WindowHeight = 50;
            Console.WriteLine("Lütfen bir tuşa basınız.");
            Console.ReadKey();  // Kullanıcıdan herhangi bir tuşa basılması için bekletir.
                
                //KADİR HOCA'NIN DERS NOTLARI 03.07.2021
            // Sayısal veri tipleri bit birimindedir.
            // 1. byte                  Boyut(Bit): 8                   Değer Aralığı: 0 ile -255
            // 2. sbyte                 Boyut(Bit): 8                   Değer Aralığı: -128 ile +127
            // 3. short                 Boyut(Bit): 16                  Değer Aralığı: -32.768 ile +32.767
            // 4. ushort                Boyut(Bit): 16                  Değer Aralığı: 0 ile 65.535
            // 5. int                   Boyut(Bit): 32                  Değer Aralığı: -2.147.483.648 ile +2.147.483.647
            // 6. uint                  Boyut(Bit): 32                  Değer Aralığı: 0 ile 4.294.967.295
            // 7. long                  Boyut(Bit): 64                  Değer Aralığı: -9.223.372.036.854.775.808 ile +9.223.372.036.854.775.807
            // 8. ulong                 Boyut(Bit): 64                  Değer Aralığı: 0 ile 18.446.744.073.709.551.615
            // 9. float                 Boyut(Bit): 32                  Değer Aralığı: 1.5E-45 ile 3.4E+38
            // 10.double                Boyut(Bit): 64                  Değer Aralığı: 5E-324 ile 1.7E+308
            // 11.decimal               Boyut(Bit): 128                 Değer Aralığı: 1E-28 ile 7.9E+28
            // 12.char                  Boyut(Bit): 16                  Değer Aralığı: Tek bir karakter tutar
            // 13.string                Boyut(Bit): Sınırsız            Değer Aralığı: Sınırsız metin tutar
            // 14.bool                  Boyut(Bit): 16                  Değer Aralığı: True / False
            // Enum değer kendine ait listesi dışında bir değer alamaz.
            // VERİLERİN RAM'DE STOKLANMASI VE SİLİNMESİ
            // __________________________________________________________________
            // |_______STACK__________|__________________HEAP____________________|
            // |_____VALUE_TYPE_______|______________REFERENCE_TYPE______________|
            // |__BASİT_VERİ_TİPLERİ__|__________KOMPLEKS_VERİ_TİPLERİ___________|
            // | age = 5 ;            | DateTime d = new DateTime(2020, 1, 1);   |
            // | name = a ;           |             string                       |
            // | age = 6 ;            |               Program                    |
            // | name = b;            |               Class                      |
            // | int                  |                                          |
            // | char                 |                                          |
            // | decimal              |                                          |
            // | bool                 |                                          |  
            // | float                |                                          |
            // | double               |                                          |
            // | dAddress HXAB        |                                          |
            // |______________________|__________________________________________|

            // RAM'in stack ve heap olmak üzere iki ana depolama bölümü vardır.
            // STACK : Kullanıcı int, char, decimal, bool, float, double değişken tanımladığında bilgisayar bu veriyi RAM üzerindeki STACK bölümünde depolar.
            // Değişkene yeni değer atandığında bu bilgi silinmek üzere işaretlenir.
            // Garbage Collector belirli aralıklarda RAM'i tarar. Tarama işlemini yaptığında işaretlenen eski değişken değerini siler.
            // C++ gibi düşük seviyeli insan diline yakın olmayan dillerde bunu manuel olarak yapmak gerekir.
            // HEAP : DateTime, string, program, class gibi kompleks veri tipleri de heap bölümünde tutulur.
            // Kompleks tipler HEAP'te tutulurken, kompleks tiplerin adresleri de STACK bölümünde tutulur.
            // d değişkenini kullanmak istediğimizde bilgisayar önce STACK bölümünde d kompleks veri tipinin adresini bulur, sonra HEAP'teki değerini bulup ekrana yazdırır.
            // STACK'te adresler ve basit veri tipleri tutulur ve kopyalanarak büyür.
            // HEAP'te kompleks veri tipleri tutulur.
            // GARBEGE COLLECTOR sadece C# gibi insan diline yakın, yüksek anlaşılırlık seviyeli .NET Framework'ün bir methodudur. C++'da kullanılamaz, manuel kod yazmak gerekir. C#'ta bize sunulan bir kolaylıktır.
        }
    }
}
