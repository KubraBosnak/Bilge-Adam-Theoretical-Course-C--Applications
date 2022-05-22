using System;

namespace _06_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string baslik = "Döngüler";
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine();



            //Console.WriteLine("DÖNGÜLER");
            //Console.WriteLine("========");
            //Console.WriteLine();

            Console.WriteLine("FOR DÖNGÜSÜ İLE 1'DEN 5'E KADAR YAZDIRMA");

            for (int i = 0; i < 5; i++)
            {

                //İÇERİDEKİ KODUN ÇALIŞMASINI İSTEMEDİĞİMİZDE CONTINUE YAZARIZ

                if (i==0)
                {
                    i++;
                    continue; // bizi başa for döngüsüne atar
                }
                if (i==3) // 3 olunca for döngüsünden çıkar
                {
                    break;
                }

                Console.WriteLine("Sayac i : "+i);
            }

            //FOR + tab + tab ile snippet değişkenlerinde gezilebilir. çift basılırsa geri gider

 
            Console.WriteLine();
            // DO-WHILE DÖNGÜSÜ

            Console.WriteLine("DO-WHILE DÖNGÜSÜ İLE 1'DEN 5'E KADAR YAZDIRMA");
            int k = 0;

            do
            {
                Console.WriteLine("Sayac k : " + k);
                k = k + 1;
                //i++;

            } 
            
            while (k<5);

            // SADECE WHILE DÖNGÜSÜ
            Console.WriteLine("SADECE WHILE DÖNGÜSÜ İLE 1'DEN 5'E KADAR YAZDIRMA");

            Console.WriteLine();
            int j = 0;

            while (j<5)
            {
                Console.WriteLine("Sayaç j :"+j);
                j += 1;
                //j++;
                //j = j + 1;
            }


            //FOREACH DÖNGÜSÜ DE VAR ANCAK DİZİLER KONUSUNDA ANLATILACAK

        }
    }
}
