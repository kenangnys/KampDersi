using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "kenan";
            int yas = 21;

            kurs kurs1=new kurs();
            kurs1.KursAdi = "c*";
            kurs1.Egitmen = "kenan";
            kurs1.İzlenmeOrani = 60;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "murat";
            kurs2.İzlenmeOrani = 70;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "oğuz";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " " +kurs.Egitmen+" "+kurs.İzlenmeOrani);
            }



        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
