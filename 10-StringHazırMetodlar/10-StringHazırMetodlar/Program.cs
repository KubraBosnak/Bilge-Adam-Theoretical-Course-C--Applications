using System;

namespace _10_StringHazırMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# HAZIR METODLARI
            // String Metodlar
            // String veri tipine özelleştirilmiş metodlardır. String ifadeler üzerinde değişiklik ve düzenleme yapmak için kullanılır
            // Trim       : Verilen string ifadenin başındaki ve sonundaki boşlukları siler. Kullanımı : Trim(); veya Trim(' ','a', '!','2','\'); veya TrimStart(); veya TrimEnd();           
            // Equals     : Eşit mi anlamında bir soru sorar. If'in methodla yazılmış hali. İki string'i birbiri ile karşılaştırırken kullanırız. ikisi birbirine eşit mi diye.
            // bool esitMi1 = textBox1.Text.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase);   -------------> Metodu küçük büyük harf gözetmeksizin karşılaştırma
            // bool esitMi2 = textBox1.Text.Equals(textBox2.Text, StringComparison.CurrentCultureIgnoreCase); --------> Hem küçük büyük harf gözetmeksizin kıyaslama hemde dil seçeneğine göre kıyaslama
            // SubString  : String ifadenin içerisinden metin kırpmaya yarar. 
            // string metin1 = textBox1.Text.Substring(2); -----> 2 start indextir.
            // string metin2 = textBox1.Text.Substring(2,4); -----> 2 start indextir, 4 keseceği uzunluktur.
            // Reverse    : Stringi tersten yazar.
            // Index Of   : String metin dizisi içerisindeki indexi verir. Bulamazsa "-1" döndürür.
            // Remove     : textBox1.Text= textBox1.Text.Remove(2,4);  2 ile 6. index arasını siler. 4 length dir.
            // Contains   : İçeriyor mu? bool iceriyorMu= textBox1.Text.Contains('a');   -------> Evet yada hayır döner
            // Contains   : İçeriyor mu? bool iceriyorMu2= textBox1.Text.Contains('bigeadam');
            // Replace    : Değişim 
            // textBox1.Text= textBox1.Text.Replace(a,b); ----a yerine b yaz 
            // Split      : String ifade içerisinde verdiğimiz ayıraca göre ifadeyi böler. Böldüğü ifadeyi diziye aktarır.
            // string [] sonuc = "murat baseren".Split(' ');
            // sonuc[0]=murat
            // sonuc[1]=baseren
            // string t = "23. 08.1995 "
            // t.Trim(); --------------> Başındaki ve sonundaki boşlukları siler.
            // t.Replace(" ",""); -----> Boşlukları boşluksuz hale getirir.
            // string[] ss = t.Split('.');-----------> . gördüğü yerden ayırır diziye atar.
            // ToUpper    : Bütün harfelri büyük harfe çevirir.
            // ToLower    : Bütün harfelri küçük harfe çevirir.

            // DATETIME METODLAR
            // DateTime veri tipi tarih ve zaman bilgisini yönetmek ve kullanmak için kullanılan sınıftır.

            // AddDays()
            // AddHours()
            // AddMonths();
            // Add Year();
            // ToShortDateString();
            // ToShortTimeString();
            // ToUniversalTime();
            // ToLongDateString();
            // ToLongTimeString();

            // MATH KÜTÜPHANESİ VE METODLAR
            // Hazır olarak onlarca matematiksel fonksiyonu bize sunan temel sınıftır. 
            // Pi Sayısı
            // ABS
            // FLOOR
            // CEILING
            // ROUND
            // TRUNCATE
            // MAX
            // MIN
            // POW
            // SQRT
            // SIGN

            Console.WriteLine("String Hazır Metodlar");
            Console.WriteLine("=====================");
            Console.WriteLine();

            // StringOrnek1();
            // StringOrnek2();
            // AnlıkZaman();
            // DateTimeOrnek1();
            // DateTimeOrnek2();
            // DateTimeOrnek3();


            decimal deger1value = 2.4465m;
            decimal deger1 = Math.Round(deger1value);
            decimal deger2 = Math.Ceiling(deger1value);
            decimal deger3 = Math.Floor(deger1value);

            Console.WriteLine($"Round : {deger1}");        // Yakın olana yuvarla
            Console.WriteLine($"Ceiling : {deger2}");      // Yukarı yuvarla
            Console.WriteLine($"Floor : {deger3}");        // Aşağı yuvarla
            Console.WriteLine($"Pi : {Math.PI}");          // Pi
            Console.WriteLine($"Pow : {Math.Pow(2,3)}");   // Üssü
            Console.WriteLine($"Sqrt : {Math.Sqrt(49)}");  // Kök
            Console.WriteLine($"Mod : {2%3}");             // Mod Alma

            Console.WriteLine();
            Console.WriteLine("Lütfen Kapatmak İçin Bir Tuşa Basınız.");
            Console.ReadKey();

            static void DateTimeOrnek3()
            {
                Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz.");
                Console.WriteLine();

                Console.Write("Değer Giriniz : ");
                string dateTimeStr = Console.ReadLine();

                DateTime birthDate = DateTime.Parse(dateTimeStr);



                Console.WriteLine($"Doğum Tarihiniz : {birthDate}");
                Console.WriteLine($"Doğum Tarihiniz (ToShortDateString): {birthDate.ToShortDateString()}");
                Console.WriteLine($"Doğum Tarihiniz (ToLongDateString) : {birthDate.ToShortDateString()}");
                Console.WriteLine($"Doğum Tarihiniz (ToShortTimeString): {birthDate.ToShortTimeString()}");
                Console.WriteLine($"Doğum Tarihiniz (ToLongTimeString) : {birthDate.ToLongTimeString()}");
                Console.WriteLine();

                Console.WriteLine($"Bir Sonraki Doğum Gününüz : {birthDate.AddYears(1).ToLongDateString()}");
                Console.WriteLine($"Bir Önceki Doğum Gününüz :{birthDate.AddYears(-1).ToLongDateString()}");
            }
        }

        private static void AnlıkZaman()
        {
            Console.WriteLine($"Şuanın tarih ve zamanı{DateTime.Now}");
            Console.WriteLine($"Şuanın Günü{DateTime.Now.Day}");
        }

        private static void DateTimeOrnek1()
        {
            Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz.");
            Console.WriteLine();

            Console.Write("Gün Giriniz : ");
            string dayStr = Console.ReadLine();

            Console.Write("Ay Giriniz : ");
            string monthStr = Console.ReadLine();

            Console.Write("Yıl Giriniz : ");
            string yearStr = Console.ReadLine();

            Console.Write("Saat Giriniz : ");
            string hourStr = Console.ReadLine();

            Console.Write("Dakika Giriniz : ");
            string minuteStr = Console.ReadLine();

            Console.Write("Saniye Giriniz : ");
            string secondStr = Console.ReadLine();

            int day = int.Parse(dayStr);
            int month = int.Parse(monthStr);
            int year = int.Parse(yearStr);
            int hour = int.Parse(dayStr);
            int minute = int.Parse(minuteStr);
            int second = int.Parse(secondStr);


            DateTime birthDate = new DateTime(year, month, day, hour, minute, second);


            Console.WriteLine($"Doğum Tarihiniz : {birthDate}");
            Console.WriteLine($"Doğum Tarihiniz (ToShortDateString): {birthDate.ToShortDateString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToLongDateString) : {birthDate.ToShortDateString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToShortTimeString): {birthDate.ToShortTimeString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToLongTimeString) : {birthDate.ToLongTimeString()}");
            Console.WriteLine();

            Console.WriteLine($"Bir Sonraki Doğum Gününüz : {birthDate.AddYears(1).ToLongDateString()}");
            Console.WriteLine($"Bir Önceki Doğum Gününüz :{birthDate.AddYears(-1).ToLongDateString()}");
        }

        private static void DateTimeOrnek2()
        {
            string dateTimeStr = Console.ReadLine();

            string[] dateTimeParts = dateTimeStr.Trim().Split(' ');  //23.08.1995 13:30:00 olarak girilmelidir// girilen tarih ve zamanı boşluktan ikiye böldük
            string datePart = dateTimeParts[0];  // tarihi parçalamamız lazım
            string timePart = dateTimeParts[1];  // zamanı parçalamamız lazım
            //tarih kısmı
            string[] dateParts = datePart.Split("."); //  23.08.1995
            int day = int.Parse(dateParts[0]);   // 23
            int month = int.Parse(dateParts[1]); // 8
            int year = int.Parse(dateParts[2]);  // 1995

            int hour = 0;
            int minute = 0;
            int second = 0;

            if (dateTimeParts.Length > 1)
            {
                // zaman kısmı
                string[] timeParts = timePart.Split(":");  //13:30:00
                hour = int.Parse(timeParts[0]);    // 13
                minute = int.Parse(timeParts[1]);  // 30 
                second = int.Parse(timeParts[2]);  // 00
            }




            DateTime birthDate = new DateTime(year, month, day, hour, minute, second);


            Console.WriteLine($"Doğum Tarihiniz : {birthDate}");
            Console.WriteLine($"Doğum Tarihiniz (ToShortDateString): {birthDate.ToShortDateString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToLongDateString) : {birthDate.ToShortDateString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToShortTimeString): {birthDate.ToShortTimeString()}");
            Console.WriteLine($"Doğum Tarihiniz (ToLongTimeString) : {birthDate.ToLongTimeString()}");
            Console.WriteLine();

            Console.WriteLine($"Bir Sonraki Doğum Gününüz : {birthDate.AddYears(1).ToLongDateString()}");
            Console.WriteLine($"Bir Önceki Doğum Gününüz :{birthDate.AddYears(-1).ToLongDateString()}");
        }

        private static void StringOrnek2()
        {
            bool dogruFormatMi = true;

            do
            {
                Console.WriteLine("Lütfen Telefon Numaranızı giriniz.");
                string phone = Console.ReadLine();

                phone = phone.Trim().Replace(" ", "");

                if (phone.IndexOf("0") != 0)
                {
                    // phone = "0" + phone;
                    phone = $"0{phone}";

                }

                Console.WriteLine($"Telefonunuz : {phone}");
                try
                {
                    for (int i = 0; i < phone.Length; i++)
                    {
                        char karakter = phone[i];
                        int.Parse(karakter.ToString());
                    }

                    dogruFormatMi = true;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen doğru formatta telefon numarası giriniz.");
                    dogruFormatMi = false;
                }


            } while (dogruFormatMi == false);
        }

        private static void StringOrnek1()
        {
            Console.Write("Lütfen adınızı ve soyadınızı giriniz");
            string adSoyad = Console.ReadLine();

            string sonucTrim = adSoyad.Trim();

            Console.WriteLine($"Trim :|{adSoyad.Trim()}|");
            Console.WriteLine($"Trim Start : |{adSoyad.TrimStart()}|");
            Console.WriteLine($"Trim End : |{adSoyad.TrimEnd()}|");
            Console.WriteLine($"Replace : |{adSoyad.Replace("a", "b")}|");
            Console.WriteLine($"ToUpper :|{adSoyad.ToUpper()}|");
            Console.WriteLine($"ToLower :|{adSoyad.ToLower()}|");
        }
    }
}
