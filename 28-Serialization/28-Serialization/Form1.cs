using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _28_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();

        string path = Application.StartupPath + @"\data.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        public object JsonSerialization { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
            StreamReader streamReader = new StreamReader(path);
            XmlReader xmlReader = new XmlTextReader(streamReader);

                if (serializer.CanDeserialize(xmlReader)) ;
                {
                    streamReader.BaseStream.Position = 0;

                    streamReader=new StreamReader(path); 

                    object obj = serializer.Deserialize(streamReader);
                    people = obj as List<Person>;

                    xmlReader.Close();
                    streamReader.Close();

                    if (people == null) people = new List<Person>();

                    LoadListbox();
                }
            }

        }

        private void btnCreatePersonal_Click(object sender, EventArgs e)
        {
            Person person = new Person()  // Burada kullanıcıdan veri alıp nesne oluşturduk
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = (int)nudAge.Value
            };

            // Oluşturduğumuz nesneyi people listesinin için atmamamız gerekir.

            people.Add(person); // Person nesnesini people listesine attık
             
            LoadListbox(); // Method çağırdık . Önce methodu yazdık sanki varmış gibi. CTRL + . 'ya basınca  Method ürettik ve içini doldurduk
            
        }

        private void LoadListbox()
        {
            //lstPersons.Items.Clear();
            // Data source kullandığımızda clear yapmamıza gerek yok çünkü data source un içerisinde kendisi verileri silip yüklüyor

            //foreach (Person person in people)
            //{
            //    lstPersons.Items.Add(person);
            //}

            lstPersons.DataSource = null;
            lstPersons.DataSource = people; // Foreach kodu ile aynı işi yapar
            //
        }

        private void lstPersons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstPersons.SelectedIndex>-1)// Listbox'te bir şey seçilmişse..
            {
                Person selecetedPerson = lstPersons.SelectedItem as Person;

                if (selecetedPerson!=null)
                {
                    MessageBox.Show(selecetedPerson.ToString());
                   // MessageBox.Show(selecetedPerson.FirstName + " " + selecetedPerson.LastName + "-" + selecetedPerson.Age);
                }
            }

            //if (lstPersons.SelectedItem != null) // Yukarıdaki ile aynıdır.
            //{

            //}
        }

        private void btnSaveXmlFile_Click(object sender, EventArgs e)
        {
            
            
            StreamWriter streamWriter = new StreamWriter(path);

            serializer.Serialize(streamWriter, people);

            streamWriter.Close();
            streamWriter.Dispose();

            MessageBox.Show("data.xml kaydedildi.");
        }

        private void btnCreateCustonXML_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");

            XmlElement kisiElement = doc.CreateElement("kisi"); //<kisi> </kisi>

            XmlElement adElement = doc.CreateElement("ad");

            XmlText adElementValue = doc.CreateTextNode("Murat");
            adElement.AppendChild(adElementValue); // <ad> Murat </ad>

            XmlElement soyadElement = doc.CreateElement("soyad");
            XmlText soyadElementValue = doc.CreateTextNode("Baseren");
            soyadElement.AppendChild(soyadElementValue); // <soyad> Başeren </soyad>

            XmlAttribute yasAttribute = doc.CreateAttribute("yas");
            yasAttribute.Value = "18";

            kisiElement.AppendChild(adElement);
            kisiElement.AppendChild(soyadElement);
            kisiElement.SetAttribute("yas", "18");
            kisiElement.SetAttributeNode(yasAttribute);

            doc.AppendChild(declaration);
            doc.AppendChild(kisiElement);

            doc.Save(Application.StartupPath + "\\custom.xml");
            doc = null;

            MessageBox.Show("Custom.xml kaydedildi.");


            // XmlDeclaration/Declaration kullanmak yerine XDocument kullanabiliriz. 

            XDocument xDoc = new XDocument(
                new XDeclaration("1.0","utf-8","yes"),
                new XElement("kisi",                  
                    new XElement("ad","Murat"),
                    new XElement("soyad", "Baseren"),
                    new XAttribute("yas","18"))
                );
            xDoc.Save(Application.StartupPath + "\\custom2.xml");
            xDoc = null;

            MessageBox.Show("Custom2.xml kaydedildi.");
        }

        private void btnBinarySerialization_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream stream = new FileStream(Application.StartupPath + "\\data2.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            binaryFormatter.Serialize(stream, people);

            stream.Position = 0;

            object obj = binaryFormatter.Deserialize(stream);
            List<Person> result = obj as List<Person>;
            stream.Close();
            stream.Dispose();
        }

        JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            IncludeFields = true
        };

        private void btnCreateJson_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(people,serializerOptions);
            File.WriteAllText(Application.StartupPath + "\\data.json", json);
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\data.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                //object obj = JsonSerializer.Deserialize(json, typeof(List<Person>));
                List<Person> result = JsonSerializer.Deserialize<List<Person>>(json);


                //if (obj != null)
                //{
                    //List<Person> result = obj as List<Person>;
                    
                    if (result != null && result.Count>0)
                    {
                        Person person = result[0];
                        MessageBox.Show(person.ToString());

                    }
                //}
            }
        }
    }
}
