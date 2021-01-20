using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} adlı müşteri eklendi.",musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} adlı müşteri silindi.", musteri.Ad);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }
    }
}
