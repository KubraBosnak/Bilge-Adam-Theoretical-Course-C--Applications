using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AlanHesaplayici
{
    class Yamuk : Dikdortgen
    {
        public int KenarC { get; set; }

        public int KenarD { get; set; }

        public override int AlanHesapla()
        {
            return KenarA * KenarB * KenarC * KenarD;
        }
    }
}
