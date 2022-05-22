namespace _25_AlanHesaplayici
{
    public abstract class Sekil
        //public abstract class Sekil   ---  Şekil class ını abastract yaparsak sadece miras alınabilir. newlenemez.
    {
        public int KenarA { get; set; }   // ENCAPSULATION : KAPSÜLLEME

        public virtual int AlanHesapla() //formülü başka yerde ezebilmemiz için virtual yani sanal method yaptık
        {
            return KenarA * KenarA;
        }
        public abstract int CevreHesapla();
    
    }

    
}


//public abstract int AlanHesapla() //formülü başka yerde ezebilmemiz için virtual yani sanal method yaptık


// Abstract (Soyut) methodlarda gövde olmaz sadece tanımlanır.