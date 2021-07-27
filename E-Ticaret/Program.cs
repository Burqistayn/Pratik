using System;
using System.Collections.Generic;

namespace E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorgulama sorgula = new Sorgulama();
            int kalan_para = 100;
            bool listede_var_mi = false;

            Urunler urunler1 = new Urunler();
            urunler1.ad = "Domates";
            urunler1.fiyat = 10;

            Urunler urunler2 = new Urunler();
            urunler2.ad = "Patates";
            urunler2.fiyat = 15;

            Urunler urunler3 = new Urunler();
            urunler3.ad = "Hıyar";
            urunler3.fiyat = 10;

            Urunler urunler4 = new Urunler();
            urunler4.ad = "Patlıcan";
            urunler4.fiyat = 20;

            Urunler urunler5 = new Urunler();
            urunler5.ad = "Muz";
            urunler5.fiyat = 30;

            Urunler[] urunler = new Urunler[] { urunler1, urunler2, urunler3, urunler4, urunler5 };

            Console.WriteLine($"Kalan Paranız : {kalan_para}TL");
            Console.WriteLine("Mevcut ürünler ;");
            foreach (var urun in urunler)
            {
                urunler1.yaz(urun);
            }
            
            string secilen;
            while (5 > 0)
            {
                listede_var_mi = false;
                Console.Write("Ürün Seçiniz : ");
                secilen = Console.ReadLine();
                foreach (var urun in urunler)
                {
                    sorgula.sorgu(urun, kalan_para, secilen);
                    kalan_para = sorgula.kalanpara2;

                    if (secilen != urun.ad && listede_var_mi == false)
                    {
                        listede_var_mi = false;
                    }
                    else if (secilen == urun.ad)
                    {
                        listede_var_mi = true;
                    }
                }
                kalan_para = sorgula.kalanpara2;
                if(listede_var_mi == false)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Seçtiğiniz ürün bulunmamaktadır.");
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
