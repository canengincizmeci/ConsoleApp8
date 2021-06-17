using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + product.Adi);




        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {

            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi + " - " + aciklama + " - " + fiyat);



        }






    }
}
