using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_URUN_StaticKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<Urun> uruns = UrunManager.UrunleriGoster();
            var urunler =  UrunManager.UrunleriGoster();
            foreach (var urun in urunler) {
                Console.WriteLine($"{urun.UrunKodu}\t{urun.UrunAdi}\t{urun.fiyat}");
            }
          Console.WriteLine($"Listelenen Ürün Sayısı : {Urun.ID}");






        }
    }
}
