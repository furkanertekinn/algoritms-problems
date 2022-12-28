using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirFonksiyonKodlama
{
    internal class Program
    {
        public static string degistir(string isim)
        {
            string yeniİsim = Reverse(isim).Replace("a", "6");
            Console.WriteLine("Sonuç : " + yeniİsim);
            Console.ReadLine();
            return yeniİsim;

        }

        public static string Reverse(string isim)
        {
            string sonuc = "";

            for (int i = isim.Length - 1; i >= 0; i--)
            {
                sonuc = sonuc + isim[i];
            }

            return sonuc;
        }

        static void Main(string[] args)
        {
            Console.Write("Lütfen içerisinde 'A' harfi bulunan bir metin giriniz : ");
            string isim = Console.ReadLine();

            Console.WriteLine(" ");

            Reverse(isim);

            Console.WriteLine("Girilen metnin ters hali : " + Reverse(isim));

            Console.WriteLine(" ");

            degistir(isim);

            Console.ReadLine();

        }
    }
}
