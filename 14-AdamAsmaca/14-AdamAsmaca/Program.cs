using System;

namespace _14_AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rastgele şehirlerden tahmin edilecek şehri seç
            // Şehri _ ile yazdır
            // Kullanıcıdan harf al
            // Kullanıcıdan aldığın harf seçili şehrin geçiyor mu bak
            // Evet kullanıcı bir harfi bildi bir sonraki satırda _ lerde o harfi aç
            // Hayırsa kullanıcının hakkını azalt 
            // Tekrarın bitmesi ile hak biter
            // Tüm harfleri bilir

            string[] sehirler = { "İSTANBUL", "ANKARA", "LOS ANGELES" }; // Proje tamamlanınca şehirleri arttır.
            Random random = new Random();
            int rastgeleIndex= random.Next(sehirler.Length);
            string sehir = sehirler[rastgeleIndex];   // İ s t a n b u l
                                                      // _ _ _ _ _ _ _ _

            char[] altTireDizisi = new char[sehir.Length];
            int karakterSayisi = 0;
            for (int i = 0; i < sehir.Length; i++)  // Alt Tire dizisini oluştur.
            {
                if (sehir[i]== ' ')
                {
                altTireDizisi[i] = ' ';
                }
                else
                {
                    altTireDizisi[i] = '_';
                    karakterSayisi++;
                }
            }

            int hak = 3;
            
            do
            {
            for (int i = 0; i < altTireDizisi.Length; i++) // Alt Tire dizisini consola yaz.
            {
                Console.Write($" {altTireDizisi[i]} ");
            }
                Console.Write("Tahmin : ");

                char karakter = char.Parse(Console.ReadLine());
                bool bildiMi = false;
                for (int i = 0; i < sehir.Length; i++)
                {
                    if (sehir[i]==karakter)  // tahmini bildiğinde çalışıyor
                    {
                        // evet doğru bildi
                        altTireDizisi[i] = karakter;
                        karakterSayisi--;
                        bildiMi = true;

                    }
                   
                }
                if (!bildiMi)  // Şehrin tüm karakterleri gezildi hiç kullanıcının girdiği karakterden içerilmiyor

                {
                    hak--;
                }


            } while (hak>0 && karakterSayisi>0);  //Döngü, ya kullanıcının tüm hakları biterse sonlanıyor ya da kullanıcı tüm harfleri bilirse sonlanıyor.

            if (karakterSayisi==0)
            {
                for (int i = 0; i < altTireDizisi.Length; i++) // Alt Tire dizisini consola yaz.
                {
                    Console.Write($" {altTireDizisi[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine("KAZANDIN!");
            }

            if (hak==0)
            {
                Console.WriteLine($"KAYBETTİN !\nBİLMEN GEREKEN ŞEHİR {sehir}");
            }

        }
    }
}
