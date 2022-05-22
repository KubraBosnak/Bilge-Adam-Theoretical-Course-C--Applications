using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace _32_GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenericClassNasilYazilir();

            // MyGenericXMLSerializerMethod();

            BasicGenericClassSample();
        }

        private static void BasicGenericClassSample()
        {
            bool isEqual = EqualityChecker.AreEqual<int>(5, 6);
            // bool isEqual = EqualityChecker.AreEqual<string>("5", "6");

            if (isEqual)
            {
                Console.WriteLine("İki değer birbirine eşit.");
            }
            else
            {
                Console.WriteLine("İki değer birbirine eşit değil.");
            }
        }

        // Static bir class ya da method new lenmeden çağırılır. Static olmayanlar ise newlenerek çağırılır.

        private static void MyGenericXMLSerializerMethod()
        {
            List<string> data = new List<string> { "aaa", "bbb", "ccc", "ddd" };

            MySerializer<List<string>> mySerializer = new MySerializer<List<string>>();

            mySerializer.Serialize("data.xml", data);
            List<string> result = mySerializer.Deserialize("data.xml");

            string xml = mySerializer.Serialize(data);
        }

        private static void GenericClassNasilYazilir()
        {
            Company<string, bool> company = new Company<string, bool>
            {
                Name = "BilgeAdam",
                Address = "Bilkent",
                Data = new List<string>() { "Ahmet", "Mehmet", "Murat" }
            };
            Company<decimal, string> company2 = new Company<decimal, string>
            {
                Name = "BilgeAdam2",
                Address = "Bilkent2",
                Data = new List<decimal>() { 123, 234, 345 }
            };
        }
    }

    class Company<T,K> //<T> BU şekilde class ı generic liste haline getirdi. T type ı ifade eder. T-K-L-M diye sıralanabilir.
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<T> Data { get; set; }

        public void DoWork(T val)
        {
            throw new NotImplementedException();
        }
        public T DoWork(T val,int val2)
        {
            throw new NotImplementedException();
        }
    }

    public class EqualityChecker
    {
        public static bool AreEqual<T>(T v1, T v2)
        {
            return v1.Equals(v2);
        }
    }

}
