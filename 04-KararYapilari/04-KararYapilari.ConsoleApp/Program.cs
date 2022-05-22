using System;

namespace _04_KararYapilari.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  KARAR YAPILARI VE DÖNGÜLER  04..07.2021
            // Algortimadaki elmas şeklindeki yaptırmak istediğimiz işlemler için kullanırız.
            // İÇERİK
            // if- else if - else
            // while
            // do -while
            // for
            // Algoritması çıkarılan örneklerin koda dökülmesi
            // Gelişmiş Yapılar
            // Ternary if
            // Switch
            //
            // ----> if -else karar yapısı
            // --> if  , belirli bir koşula bağlı olarak çalışacak olan kod parçacıklarını belirlemek için kullanılır. 
            // --> else, kısmı da var ise koşulun sağlanmadığı bütün durumlarda else kod parçacığı çalışır.
            //  if (kosul)
            // {
            //    yapılacak işlemler
            // }
            //  else if (kosul)
            // {
            //    yapılacak işlemler
            // }
            // else
            // {
            //    yapılacak işlemler
            // }

            // ---->  while- do-while döngüsü
            // -->  while,    belirli bir koşulun sağlandığı sürece yapılacak olan kod parçacıklarının belirlenmesinde kullanılır.
            // -->  do-while, kod parçacığının bir kez çalıştırıldıktan sonra tekrar çalışmasının bir koşula bağlı olmasını sağlamak amacıyla kullanılır.
            //
            //  while (kosul)
            // {
            //    yapılacak işlemler
            // }


            // do
            // {
            //    yapılacak işlemler
            // }
            //  while (kosul)


            //---->  for döngüsü
            // --> for, bir kod parçacığının istenilen ya da belirli bir koşula bağlı olarak değişen sayıda tekrar çalıştırılmasını sağlamak amacıyla kullanılır.

            // for (int i = 0; i < 5; i++)
            // {
            //    yapılacak işlemler
            // }
            // For döngüsünün belirli bir başlangıç değeri var, sonra bir koşulu var ve en sonra sayacı kaçar arttıracağını belirten bir bölümü var. 3 bölümden oluşuyor.

            //jwt.io   sitesi token olarak şifreleme yapmayı sağlar.



            //Console.WriteLine("Karar Yapıları");
            //Console.WriteLine("==============");
            //Console.WriteLine();

            Console.WriteLine("Lütfen yaşınızı giriniz : ");
            string yasStr = Console.ReadLine();            // program ilk önce eşitliğin sağ tarafını görür ve birşeyler yazıp enter a basmamızı bekler ve okur.
            int yas = int.Parse(yasStr);

            //todo if - else if - else bölümü

            //if (yas> 17)
            //{
            //    Console.WriteLine("Yaşınız"+yasStr+", siz yetişkinsiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşınız" + yasStr + ", siz yetişkin değilsiniz.");
            //}

            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen kapatmak için bir tuşa basınız.");
            //    Console.ReadKey();

            ////TERNARY OPERATÖRÜ

            //string mesaj = (yas < 18) ? "Yetişkin değilsiniz." : "Yetişkinsiniz.";
            //Console.WriteLine(mesaj);


            // SWITCH - CASE BÖLÜMÜ
            // Daha spesifik tercihler için switch case kullanılır.
            switch (yas)
            {
                case 1:
                    Console.WriteLine("Bebeksin");
                    break;

                case 18:
                    Console.WriteLine("Yetişkin sınırı");
                    break;
                case 25:
                    Console.WriteLine("Yetişkinsiniz");
                    break;
                default:
                    Console.WriteLine("Gençsiniz");
                    break;
 
            }

            // Karar Yapılarında IF ve SWITCH kullanılır.





        }
    }
}
