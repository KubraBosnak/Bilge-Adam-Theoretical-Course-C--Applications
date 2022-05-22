using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOpPrensipleri
{
    public class Personel
    {
        // Field lar
        private string _Name;
        private string _Surname;
        private int _Age;
        public string City { get; set; }
        public string Country { get; set; }

        // Property ler
        public string Name // kapsülleme işlemidir.
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value<18)
                {
                    throw new Exception("Yaş 18'den küçük olamaz.");
                }
                _Age = value;
            }
        }
        public string Surname // kapsülleme işlemidir.
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
            }
        }
        public int calculateAge(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
      
   

    }
}
