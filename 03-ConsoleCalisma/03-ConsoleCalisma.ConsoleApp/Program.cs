using System; //System bir dll'dir, System.Console veya System.Random diye uzun uzun yazmamak için dll'i burada tanımlarız. 
//Dynamic-link library : Dinamik bağlantı kitaplığı

//Bu kodların hepsi (Solution Explorer -> Dependencies -> Frameworks -> Microsoft.NETCore.App içerisinde mevcuttur.)

namespace _03_ConsoleCalisma.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MERHABA HOŞGELDİNİZ");
            Console.WriteLine("===================");
            Console.WriteLine("");

            Console.Write("Adınız : ");
            string adi= Console.ReadLine();   //ReadLine'nın üzerine gelindiğinde "string? Console.ReadLine()" yazıyor. Parantezin içi boş olduğu için parametre almıyo, başta string yazdığı için de geriye string değer döndürüyor deriz.

            Console.Write("Soyadınız : ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşınız : ");
            string yasStr = Console.ReadLine();  // Readline geriye string değer döndürdüğü için yaşı değerini int veri tipine dönüştürmemiz gerekiyor.

            int yas = int.Parse(yasStr);   // explicit : açık olarak belirtilmiş dönüşüm

            // .NET'de random sayı üretebilmek için random class'ını kullanırız
            // parse methodu sadece string ile çalışır
            
            Random random = new Random();  //random class'ını kullanabilmemiz için new denen keyword ile üretmemiz gerekir. console class ı gibi hazır kullanamıyoruz. Önce üretmemiz gerekiyor.
            // random class ını ürettikten sonra random yazıp yanına hangi türde veri üretmek istiyorsak onu seçeriz
            // next int üretir.

            // instance oluşturmak ve new leme aynı şeydir
            // Random random heap te tutulur, random un adresi stack te tutulur.

            int rastgeleDeger = random.Next(10,100);

            int yeniYas = rastgeleDeger + yas;
            string yeniYasStr = yeniYas.ToString();
            string yeniYasStr2 = Convert.ToString(yeniYas);
            //random.Next(100);  // 0-100 arası bir değer verir
            int yeniYas3 = Convert.ToInt32("44");
            Console.WriteLine();

            // implicit dönüşüm : ratgele değeri string olarak dönüştürüp yazdırabilmemizin sebebi üstü kapalı ( gizli otomatik) dönüşüm yapmasıdır. 
            Console.WriteLine("Yaşınızın " + rastgeleDeger+" fazlası " + yeniYas+"dir.");

            Console.WriteLine(random.ToString());  // bu kodu yazarsak complex bir tipi dönüştürmeye çalışmış oluruz ama nu çevrim olamaz.


            object isim = "Murat";  // boxing
            isim = 15;
            isim="true";

            int toplam = (int)isim + 10;   //casting (int)isim Object içerisinden veri dönüştürmeye casting denir
                                           // Objenin içerisinden veri çıkarmaya unboxing denir. 
                                           //Object içerisinde veri atmaya da boxing denir.

            object deger = 15;
            int toplam2 = int.Parse(deger.ToString()) + 10;
            int toplam3 = Convert.ToInt32(deger) + 15;
            int toplam4 = (int)deger + 20;
            Console.WriteLine("numara"+deger.ToString());
            
            Console.WriteLine();
            Console.WriteLine("Lütfen kapatmak için tuşa basınız");  // Void : Geriye değer döndürmüyor demektir
            Console.ReadKey();
            // snippet : Simgesi kutucuk : kısayol cw + tab + tab gibi
        }
    }
}
