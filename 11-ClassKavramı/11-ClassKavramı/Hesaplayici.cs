using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ClassKavramı
{
    class Hesaplayici
    {
        public Hesaplayici() //Constructor Nesneyi oluşturduğumuz yer
        {

        }

        public int Topla(int a, int b)
        {
            int c = a + b;
            return c;

        }
        public int Cıkar(int a, int b)
        {
            int c = a - b;
            return c;

        }
    }
}
