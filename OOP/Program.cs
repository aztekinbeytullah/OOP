using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri m1 = new GercekMusteri() {
                Adi = "BEytullah",
                Id = 1,
                MusteriNo = "123456",
                Soyadi = "Aztekin",
                TcNo = "40192075042"
                
            };

            Tuzel_Musteri m2 = new Tuzel_Musteri()
            {
                Id = 2,
                MusteriNo = "654321",
                SirketAdi = "Kodmalaio",
                VergiNo = "987654"

            };

            Musteri musteri = new GercekMusteri();
            Musteri musteri1 = new Tuzel_Musteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(m1);
            musteriManager.Ekle(m2);
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri1);

        }
    }
}
