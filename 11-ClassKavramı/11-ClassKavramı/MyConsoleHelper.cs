using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ClassKavramı
{
    class MyConsoleHelper
    {
        public string KelimeleriBirlestir(string ad, string soyad)
        {
            string adSoyad = ad + "" + soyad;
            return adSoyad;
        }
        public void BaslikYaz(string baslik)
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void EkranaYaz(string metin)
        {
            Console.WriteLine("->>" + metin);
        }
    }
}
