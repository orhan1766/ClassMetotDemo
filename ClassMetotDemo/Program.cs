using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id=1,
                Ad="Orhan",
                Sehir="Edirne",
                YeniMusteri=true
            };

            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Ad = "Mesut",
                Sehir = "Bursa",
                YeniMusteri = false
            };

            Musteri musteri3 = new Musteri
            {
                Id = 3,
                Ad = "Emre",
                Sehir = "Sakarya",
                YeniMusteri = false
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("-------------");
            musteriManager.Listele(musteriler);
            Console.WriteLine("-------------");
            musteriManager.Sil(musteri1);

        }
    }
}
