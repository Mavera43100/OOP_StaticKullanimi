using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_URUN_StaticKullanimi
{
    internal class Urun
    {
        public static int ID { get; set; }
        public int UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public double fiyat { get; set; }

        public Urun()
        {
            ID++;
        }
    }

    class UrunManager
    {
        static public List<Urun> UrunleriGoster() {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunKodu =101, UrunAdi="Hp ELiteBook 200",fiyat=11000},
                new Urun(){UrunKodu =102, UrunAdi="Hp Victus 16d",fiyat=16000},
                new Urun(){UrunKodu =103, UrunAdi="Hp omenbook 200",fiyat=21000},
                new Urun(){UrunKodu =104, UrunAdi="Hp 14-em008",fiyat=18000},
                new Urun(){UrunKodu =201, UrunAdi="Acer Aspire 7",fiyat=13000},
                new Urun(){UrunKodu =202, UrunAdi="Acer Nitro 5",fiyat=17000}
            };
            return urunler;
        }

        
    }
}
