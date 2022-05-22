using System;
using System.Collections.Generic;

namespace _24_OOpPrensipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Encapsulation();

            Car binek = new Car();
            binek.Brand = "Opel";
            binek.Model = "Astra";
            binek.Price = 100000;
            binek.VAT = 18;
            Console.WriteLine(binek.GetTotalPrice());

            SUV suv1 = new SUV();
            suv1.Range = "4x2";
            suv1.Price = 200000;
            suv1.VAT = 11;
            Console.WriteLine(suv1.GetTotalPrice());

            Jeep jeep1 = new Jeep();
            jeep1.Brand = "Jeep";
            jeep1.AraziOzelligiVar = true;
            jeep1.BagageLimit = 100;
            jeep1.Price = 400000;
            jeep1.VAT = 13;
            Console.WriteLine(jeep1.GetTotalPrice());

        }

        private static void Encapsulation()
        {
            List<Personel> personels = new List<Personel>();

            int birthYear = 1984;

            Personel personel1 = new Personel();
            personel1.Name = "Kübra";
            personel1.Surname = "Boşnak";
            personel1.Age = personel1.calculateAge(birthYear);
            personel1.City = "Ankara";
            personel1.Country = "Türkiye";
            Console.WriteLine("Hello World!");
        }
    }
}


// DERS NOTLARI
// C# tarafında tanımlı olmayan yapıları bilgisayarımızın anlayacağı bir yapıda bizlere tanımlama imkanı sağlar.

// OOP ile bir nesne tanımlıyoruz.
// Bir birlisayarı nesne olarak tanımlayacak olursak nesnemizin ne gibi özellikler(property) taşıyacağını şu şekilde belirleyebiliriz.
// Ekran / Anakart / İşlemci / Bellek / Genişletme Kartı / Güç KAynağı / Optik Sürücü / Sabit Disk / Klavye / Fare

// Nesne Tabanlı Programlama Dilleri Nelerdir?
// C++ / Microsoft Visual C# / Java / PHP / Objective-C / Python

// Object Oriented Prensipleri 
// 1- Encapsulation : Kapsülleme
// 2- Inheritance   : Miras Alma
// 3- Polymorphism  : Çok Biçimlilik
// 4- Abstraction   : Soyutlama

// Nesne Yönelimli Programlamanın Avantajları 
// 1- Reusability (Tekrar Kullanılabilirlik)
// 2- Extensibility (Genişletilebilirlik)
// 3- Maintainability (Sürdürülebilirlik)