using Inheritance;
Ogrenci ogrenci1 = new Ogrenci();
ogrenci1._ad = "Murat";
ogrenci1._soyAd = "Soyad";
ogrenci1._ogrenciNo = 1234567789;

Ogretmen ogretmen1 = new Ogretmen();
ogretmen1._ad = "Kazim";
ogretmen1._soyAd = "Nazim";
ogretmen1._maasBilgisi = 27.000;

ogrenci1.Ozet();
ogretmen1.Ozet();