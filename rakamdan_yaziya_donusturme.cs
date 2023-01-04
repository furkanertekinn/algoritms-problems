using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakamdanYaziyaDonusum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            while (true)
            {
                Console.Write("Lütfen 4 basmaklı bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi >= 10000 || sayi < 1000)
                    continue;
                else
                    break;
            }

            string[] sayilarTek = new string[] { "", "", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

            string[] sayilarOn = new string[] { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            int birler = sayi % 10;

            sayi = sayi / 10;
            int onlar = sayi % 10;

            sayi = sayi / 10;
            int yuzler = sayi % 10;

            sayi = sayi / 10;
            int binler = sayi % 10;

            Console.WriteLine(" ");
            Console.WriteLine("Sonuç :");
            Console.WriteLine(" ");

            string sonuc = "";

            if (yuzler == 0)
            {
                sonuc = sonuc + sayilarTek[binler] + "bin" + sayilarTek[yuzler] + sayilarOn[onlar] + "" + sayilarTek[birler];
            }

            else
            {
                sonuc = sonuc + sayilarTek[binler] + "bin" + sayilarTek[yuzler] + "yüz" + sayilarOn[onlar] + "" + sayilarTek[birler];
            }

            if (birler == 1)
            {
                sonuc = sonuc + "bir";
            }

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
