using System;
using System.Collections.Generic;

namespace EkCalismalar
{
    class Program
    {/*
      Urun : id,Adı, birimfiyat,categoryId,Stok miktarı
      
     *---------------------
     *Ekleme,silme,guncelleme,listeleme
      */
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.UrunAdi = "Casper";
            urun.UrunId = 155;
            urun.BirimFiyat = 5000;
            urun.KategoriId = 15;
            urun.StokAdedi = 5;

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Apple";
            urun1.UrunId = 159;
            urun1.BirimFiyat = 5050;
            urun1.KategoriId = 25;
            urun1.StokAdedi = 9;
            

            Urun[] uruns = new Urun[3] { urun , urun1,urun };
      
            List<Urun> uruns1 = new List<Urun>();
            Urun sonuc = uruns[0];
            //var sonuc = "asdaskjdsa";
            Console.WriteLine(sonuc.UrunAdi +" "+ sonuc.KategoriId + sonuc);
            UrunYonetimi urunYonetimi = new UrunYonetimi();

            for (int i = 0; i < uruns.Length; i++)
            {
                urunYonetimi.Add(uruns[i]);
            }


        }
    }
}
