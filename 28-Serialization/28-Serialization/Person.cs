using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace _28_Serialization
{
    [Serializable]
    [XmlType("Calisan")] //Person classının ismini değiştirdi
   
    public class Person
    {
        //[XmlElement(ElementName ="Adi")] // Attribute'dur. Xml formatında isim elementinin yanında FirstName yazarken attribute ile Adi yazar
        //[JsonPropertyName("Adi")] Json formatına attribute atar
        public string FirstName { get; set; } // Property

        //[XmlElement(ElementName ="Soyadi")] // Attribute
        //[JsonPropertyName("Soyadi")]
        public string LastName { get; set; }  // Propertty

        //[XmlIgnore] // Eğer ignore edersek xml'de bu property yazılmaz
        //[JsonIgnore] // Json formatında Yaşı yazdırmaması için JsonIgnore yazılır
        

        //[XmlElement(ElementName ="Yas")] // Attribute
        [JsonPropertyName("Yas")]
        public int Age { get; set; }          // Property

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age}";
        }
    }
}
// Bir clasın attribute'leri olur.
// Bir property'nin attribute'leri olur. Bunlara özellik yükleriz isim değiştirmek gibi