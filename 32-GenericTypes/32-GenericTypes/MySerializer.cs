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
    public class MySerializer<T>
    {
        public void Serialize(string path, T obj) // Dosyaya xml yazdırma
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter streamWriter = new StreamWriter(path);

            serializer.Serialize(streamWriter, obj);

            streamWriter.Close();
            streamWriter.Dispose();
        }
        public string Serialize(T obj) //Ram seviyesinde xml yazdırma
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(memoryStream);

            serializer.Serialize(streamWriter, obj);

            memoryStream.Position = 0;

            StreamReader streamReader = new StreamReader(memoryStream);
            string result = streamReader.ReadToEnd();

            streamWriter.Close();
            streamWriter.Dispose();

            streamReader.Close();
            streamReader.Close();

            memoryStream.Close();
            memoryStream.Dispose();

            return result;
        }


        public T Deserialize(string path)
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                XmlReader xmlReader = new XmlTextReader(streamReader);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                if (serializer.CanDeserialize(xmlReader))
                {
                    streamReader.BaseStream.Position = 0;
                    object obj = serializer.Deserialize(streamReader);

                    xmlReader.Close();
                    streamReader.Close();

                    return (T)obj;
                }
            }
            return default(T);
        }
    }
}
