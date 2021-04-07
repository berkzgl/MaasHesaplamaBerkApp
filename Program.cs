using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasHesaplamaBerkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel insan1 = new Personel();
            Console.WriteLine("Personel ismini giriniz: ");
            insan1.Ad = Console.ReadLine();
            Console.WriteLine("Soyad giriniz: ");
            insan1.Soyad = Console.ReadLine();
            Console.WriteLine("İşe giriş yılını giriniz: ");
            insan1.Yıl = int.Parse(Console.ReadLine());

            insan1.Hesap = (((DateTime.Now.Year - insan1.Yıl) * insan1.katsayi) * insan1.maas);

            Console.WriteLine(insan1.PersonelBilgileri());
        }


        class Personel
        {
            private string ad;

            public string Ad
            {
                get { return ad; }
                set { ad = value.ToUpper(); }
            }

            private string soyad;

            public string Soyad
            {
                get { return soyad; }
                set { soyad = value.ToUpper(); }
            }


            public int maas = 1000;
            public double katsayi = 0.8;

            private double hesap;

            public double Hesap
            {
                get { return hesap; }
                set { hesap = value; }
            }


            private int yıl;

            public int Yıl
            {
                get { return yıl; }
                set { yıl = value; }
            }

            public string PersonelBilgileri()
            {
                return $"\n Personel adı: {this.ad}\n Personel soyadı: {this.soyad}\n Maaşı: {this.hesap}TL";
            }

        }
    }
}
