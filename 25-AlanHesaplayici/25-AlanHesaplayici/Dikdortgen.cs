using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_AlanHesaplayici
{
    class Dikdortgen:Sekil  // INHERITANCE : MİRAS ALMA 
    {
        // public int kenarA { get; set; }   Kareden miras aldığımız için artık burada property tanımlamamıza gerek yok
        public int KenarB { get; set; }

        //public int AlanHesapla()   Bu method yerine KARE Class ındaki formülü override edeceğiz
        //{
        //    return kenarA * kenarB;
        //}

        public override int AlanHesapla() // POLYMORPHISM : ÇOK BİÇİMLİLİK
        {
            return KenarA * KenarB;
            //return base.AlanHesapla();
        }

        public override int CevreHesapla()
        {
            return (KenarA * 2) + (KenarB * 2);
        }
    }

    
}
