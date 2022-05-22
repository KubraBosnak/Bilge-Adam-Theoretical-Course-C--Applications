using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOpPrensipleri
{
    public class Car    // INHERITANCE : MİRAS ALMA ÖRNEĞİ
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }
        
        public decimal VAT { get; set; }

        // POLYMORPHISM : ÇOK BİÇİMLİLİK
        public virtual decimal GetTotalPrice()  // Virtual ile sanala çıkardık. Sebebi Başka class lar içinde override edebilmemiz için ezmemiz için.

        {
            return Price * (1 + (VAT / 100));
        }       
    }
    public class SUV : Car
    {
        public string Range { get; set; }
        public bool AraziOzelligiVar { get; set; }

        public override decimal GetTotalPrice()
        {
            //return base.GetTotalPrice();

            return Price * (2 + (VAT / 100)); // üstte tanımlanan methodu ezdik yeni formül yazdık
        }
    }

    public class Jeep : SUV
    {
        public int BagageLimit { get; set; }
        public override decimal GetTotalPrice()
        {
            //return base.GetTotalPrice();

            return Price * (3 + (VAT / 100)); // üstte tanımlanan methodu ezdik yeni formül yazdık
        }
    }
}
