using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret
{
    class Sorgulama
    {
        public int kalanpara2 = 100;
        public void sorgu(Urunler urunler, int kalanpara, string secilen)
        {
            if (secilen == urunler.ad && kalanpara - urunler.fiyat >= 0)
            {
                kalanpara -= urunler.fiyat;
                kalanpara2 = kalanpara;
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"{urunler.ad} satın alındı.");
                Console.WriteLine($"Kalan Paranız : {kalanpara}TL");
                Console.WriteLine("-----------------------------");
            }
            else if (secilen == urunler.ad && kalanpara - urunler.fiyat < 0)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Paranız({kalanpara}TL) {urunler.ad} almaya yetmemektedir.");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
