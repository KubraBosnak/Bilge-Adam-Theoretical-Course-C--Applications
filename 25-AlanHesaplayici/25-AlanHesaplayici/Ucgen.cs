using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AlanHesaplayici
{
    class Ucgen : Sekil
    {
        public int Height { get; set; }

        public override int AlanHesapla()
        {
            return (Height * KenarA) / 2;
        }

        public override int CevreHesapla()
        {
            return KenarA * 3;
        }
    }
}
