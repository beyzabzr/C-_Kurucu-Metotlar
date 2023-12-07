using System;
namespace _nstance_field_property
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Söz Dizimi:
                class SinifAdi
                {
                    [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
                    [Erisim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
                    {
                        METOT KOMUTLARI
                    }
                }

                Erisim Belirleyicileri:
                * Public
                * Private
                * Internal
                * Protected
            */

            Console.WriteLine("****Calisan 1****");

            Calisan calisan1 = new Calisan("Ayse", "Kara", 2154513, "Insan Kaynaklari");
            calisan1.CalisanBilgileri();

            Console.WriteLine("****Calisan 2****");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 5546546;
            calisan2.Departman = "Satin Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("****Calisan 3****");
            Calisan calisan3 = new Calisan("Ayse", "Kara");
            calisan3.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }

            public Calisan() { }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyad: {0}", Soyad);
                Console.WriteLine("Calisan No: {0}", No);
                Console.WriteLine("Calisan Departmani: {0}", Departman);
            }
        }
    }
}