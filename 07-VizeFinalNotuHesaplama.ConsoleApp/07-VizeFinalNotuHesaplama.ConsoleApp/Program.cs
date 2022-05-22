using System;

namespace _07_VizeFinalNotuHesaplama.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Vize Notu :");
            float vize1 = Convert.ToSingle(Console.ReadLine());   // Readline'nın bize döndürdüğü stringi ifadeyi Convert.ToSingle ile float veri tipine dönüştürdük.
            Console.Write("2. Vize Notu :");
            float vize2 = float.Parse(Console.ReadLine()); 
            Console.Write("1. Final Notu :");
            float final1 = Convert.ToSingle(Console.ReadLine());

            float yilSonuNotu = (vize1 * 0.3F) + (vize2 * 0.3F) + (final1 * 0.4F);
                Console.WriteLine("Yıl Sonu Notunuz : " + yilSonuNotu);

            if (yilSonuNotu<50)
            {
                Console.WriteLine("Kaldınız");
            }
            else
            {
                Console.WriteLine("Geçtiniz");
            }
        }
    }
}
