using System;

namespace _19.EnKucukveyaEnBuyukSayiBelirleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // end yazana kadar sayı al
            // end yazdığında en büyük ve en küçük sayıyı çıktı olarak ver.
            // kullanıcının minimum iki sayı yazdığını kontrol et
            // kullanıcının yazdığı değer sayı mı kontrol et uygun değilse uyarı dön
            // kullanıcı exit yazarsa uygulama kapanacak
            // kullanıcıdan bir değer al
            // sayi        : sayıyı al büyük mü küçük mü karşılaştırmak için
            // geçersiz    : uyarı ver, döngüye devam
            // end         : en az iki sayı aldığından emin ol ve sayı almayı bırak
            // exit        : return

            // Not: return, continue, break 

            bool kontrol;
            int sayi=0;
            string komut;
            int sayac = 0;
            int buyukSayi = 0;
            int kucukSayi = int.MaxValue;
            bool bitirelimMi;
            do
            {
                bitirelimMi = false;
                do // sayı almamızı sağlar.
                {
                    Console.WriteLine("Çıkmak istediğinizde exit ile çıkabilirsiniz.");
                    Console.WriteLine("Lütfen bir sayı giriniz");
                    komut = Console.ReadLine();
                    if (komut=="end")
                    {
                    if (sayac>=2)
                         {
                             bitirelimMi = true;
                            break;
                         }
                    }

                    if (komut == "exit")
                    {
                        //Environment.Exit(0);
                        return;
                    }

                    kontrol = int.TryParse(komut, out sayi);
                    if (!kontrol)
                    {
                        sayi = kucukSayi;
                        Console.WriteLine("Lütfen sayı değeri giriniz");
                    }

                } while (!kontrol && !bitirelimMi);
                sayac++;

                buyukSayi = sayi > buyukSayi ? sayi : buyukSayi;       
                kucukSayi = sayi < kucukSayi ? sayi : kucukSayi;         
            } 
            
                  while (!bitirelimMi);
                Console.WriteLine("Büyük Sayı :"+buyukSayi);
                Console.WriteLine("Küçük Sayı :"+kucukSayi);

        }
    }
}
