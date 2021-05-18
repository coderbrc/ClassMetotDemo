using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriName = "aa";
            musteri1.MusteriSurname = "bb";
            Musteri musteri2 = new Musteri();
            musteri2.MusteriName = "cc";
            musteri2.MusteriSurname = "dd";
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkleme(musteri1);
            musterimanager.MusteriEkleme(musteri2);
            Musteri[] musteriler = { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                musterimanager.MusteriListele(musteri);
            }

        }
    }
}