using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret
{
    class Urunler
    {
        public int fiyat { get; set; }
        public string ad { get; set; }

        public void yaz(Urunler urunler)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Ürün Adı : {urunler.ad}");
            Console.WriteLine($"Ürün Fiyatı : {urunler.fiyat}TL");
            Console.WriteLine("-----------------------------");
        }
    }
}
