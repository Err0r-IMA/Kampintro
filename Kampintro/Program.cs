﻿using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - Kendini  tekrarlama
            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            //if (sistemeGirisYapmisMi == true)     
            //{
            //    Console.WriteLine(" Kullanıcı Ayarları butonu");

            //}
            //else
            //{
            //    Console.WriteLine("Giriş Yap Butonu");
            //}
            
            
            //Console.WriteLine(KategoriEtiketi);

        }
    }
}
