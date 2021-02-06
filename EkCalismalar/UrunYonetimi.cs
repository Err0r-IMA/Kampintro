using System;
using System.Collections.Generic;
using System.Text;

namespace EkCalismalar
{
    class UrunYonetimi
    {
       
        
        public void Add(Urun urun)
        {
            Console.WriteLine("**************** Eklenilen Urun ****************************");
            Console.WriteLine("Urun adi :  " + urun.UrunAdi);
            Console.WriteLine("Urun Fiyat :  " + urun.BirimFiyat);
            Console.WriteLine("Urun Adet :  " + urun.StokAdedi);
            Console.WriteLine("Urun KAtegori :  " + urun.KategoriId);
            Console.WriteLine("Urun başarıyla eklendi");
        }
        
       

    }
}
