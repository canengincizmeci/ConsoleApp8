using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Product elma = new Product();
            elma.Adi = "Elma";
            elma.Fiyati = 15;
            elma.Aciklama = "Amasya elması";

            Product karpuz = new Product();
            karpuz.Adi = "Karpuz";
            karpuz.Fiyati = 80;
            karpuz.Aciklama = "Diyarbakır Karpuzu";

            Product kiraz = new Product();
            kiraz.Adi = "Kiraz";
            kiraz.Fiyati = 5;
            kiraz.Aciklama = "Sinop kirazı";

            Product[] products = new Product[] {elma,karpuz };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("--------------------------");


            }

            Console.WriteLine("-----------Metotlar---------------");

            //instance - örnek

            SepetManager sepetManager = new SepetManager();

            //reusubility 
            sepetManager.Ekle(elma);
            sepetManager.Ekle(karpuz);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Limon", "İri Limon", 2,9);
            sepetManager.Ekle2("Ahududu", "Mor Ahududu", 3,8);

            Console.ReadLine();

        }


    }
}
