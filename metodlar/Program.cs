using metodlar;
using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 10;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 100;
            urun2.Aciklama = "diyarbakır karpuzu";
            

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı+" "+"tl");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }


            Console.WriteLine("-----------Metotlar-------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil eşma", 12);
            sepetManager.Ekle2("karpuz", "yeşil karpuz", 12);
        }
    }
}













//Do Not Repeat Yourself - DRY - Clean code - Best Practice