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

		public virtual void Ozet()
		{
			Console.WriteLine($"{_ad} {_soyAd}");
		}


	}
	public class Ogrenci : BaseKisisi
	{
		public int _ogrenciNo { get; set; }

		public override void Ozet()
		{
			Console.WriteLine($"{_ogrenciNo}'numarali {_ad} {_soyAd} ogrencisi.");
		}
	}
	public class Ogretmen:BaseKisisi
	{
		public double _maasBilgisi { get; set; }

        public override void Ozet()
        {
            Console.WriteLine($"{_ad} {_soyAd} adli ogretmenin maasi {_maasBilgisi} TL'dir.");
        }
    }
}


