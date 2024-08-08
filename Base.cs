using System;
namespace Inheritance
{
    public class BaseKisisi
    {
        public BaseKisisi()
        {
        }
        public string _ad { get; set; }
        public string _soyAd { get; set; }

        public virtual void Ozet(string a,string b, int c)
        {
            Console.WriteLine($"{c}'numarali {a} {c} ogrencisi.");
        }
        public virtual void Ozet(double d, string a, string b)
        {
            Console.WriteLine($"{a} {b}' isimli ogretmenin maas bilgisi {d} TL'dir.");
        }


    }
    public class Ogrenci : BaseKisisi
    {
        public int _ogrenciNo { get; set; }

    }
    public class Ogretmen : BaseKisisi
    {
        public double _maasBilgisi { get; set; }
    }
}

