using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;
            bool sonuc=int.TryParse(sayi, out  outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplam);
            Console.WriteLine(toplam);
            // overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            //metot imzası
            //metotadı+ parametre sayisi + parametre
            string a = " Hira";
            string b = " Balcı";
            instance.EkranaYazdir(a, b);
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int Toplam)
        {
            Toplam = a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri ,string veri2)
        {
            Console.WriteLine(veri+veri2);
        }
    }
}
