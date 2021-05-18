using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi: " + musteri.MusteriName + " " + musteri.MusteriSurname);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler başarıyla listelendi:" + musteri.MusteriName + " " + musteri.MusteriSurname);
        }
    }
}
