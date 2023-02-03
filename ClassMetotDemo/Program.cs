using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "Melike";
            musteri1.musteriSoyadi = "Kurt";
            musteri1.musteriAciklama = "Yeni müşteri";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "Emre";
            musteri2.musteriSoyadi = "Erkan";
            musteri2.musteriAciklama = "VIP müşteri";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.musteriAdi);
                Console.WriteLine(musteri.musteriSoyadi);
                Console.WriteLine(musteri.musteriAciklama);
                Console.WriteLine("------");
            }


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine("------");


        }
    }
}