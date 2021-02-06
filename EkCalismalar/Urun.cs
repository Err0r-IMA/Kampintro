using System;
using System.Collections.Generic;
using System.Text;

namespace EkCalismalar
{
    class Urun
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public int BirimFiyat { get; set; }

        public int KategoriId { get; set; }

        public int StokAdedi { get; set; }
    }
}
