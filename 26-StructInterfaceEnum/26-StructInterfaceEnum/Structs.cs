namespace _26_StructInterfaceEnum
{
    struct Structs
    {
        public string fileName;
        public string encoding;
        public string fileFormat;
        public bool isReadOnly;


        public Structs(string _fileName, string _encoding, string _fileFormat, bool _isReadOnly)
        {
            fileName = _fileName;
            encoding = _encoding;
            fileFormat = _fileFormat;
            isReadOnly = _isReadOnly;
        }
    }
}
// STRUCT'lar Classlara çok benzer özelliklere sahiptir.
// Struct'lar içerisinde field'da (public int x;) alabilir, property'de (public int X { get; set; }) alabilir.
// Class'lar bilgisayardaki RAM'in heap bölgesinde (Referans tipleri diziler, datetime nesnesi, random nesnesi gibi büyük nesneler burada tutulur.
// Nesnenin kendisi heap'te durur. Nesnenin adresi Stack'te tutulur)
// Struct'lar Stack bölümünde(Basit tipler int,decimal) yer alır. Bu da bize hız kazandırır. Structlar genelde oyun geliştirmede kullanılır.
// Struct'lar Class'lar kadar performanslı değildir.
// Struct'lara constructor eklenemiyor. ctor oluşturulacaksa içerisinin field lar ile doldurulması gerekiyor.
// Struct içerisindeki metodlar virtual yapılamıyor yani polymorphism yapılamaz yani ezilemez.
// Struct başka bir struct'tan yada class'tan miras alamaz.
// Struct içerisindeki metodlar abstract, sealed, protected yapılamıyor.
// Struct'ta amaç classtan daha hızlı çalışabilmesi için class'ın polymorphism, inheritance gibi hantallık yapacak özelliklerini iptal edilmiştir.
// Amacı daha hızlı bir şekilde tutacağı verileri bir araya getirip, bir yapı oluşturup, o verileri tutup ve huzlı bir şekilde kullanılmasını sağlamaktır.
// Structlar Ram'de stack'te tutulur. Daha hızlı olabilmesi için.
// Struct ile yapılabilenler; kurallarla constructor tanımlama, field, method, property oluşturmak mümkündür.