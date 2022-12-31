using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSoyadSekilli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen adınızı giriniz : ");
            string ad = Console.ReadLine();

            Console.Write("Lütfen soyadınızı giriniz : ");
            string soyad = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Sonuç : ");
            Console.WriteLine(" ");

            //emre********
            if(ad.Length % 12 != 0)
            {
                int tut = ad.Length % 12;
                for(int f = 0; f< 12- tut; f++)
                {
                    ad = ad + "*";
                }
            }

            if (soyad.Length % 12 != 0)
            {
                int tut = soyad.Length % 12;
                for (int f = 0; f < 12 - tut; f++)
                {
                    soyad = soyad + "+";
                }
            }

            int adUzunluk = ad.Length / 4;
            int soyadUzunluk = soyad.Length / 3;

            int adBoslukSayi = adUzunluk - 2;
            string adBosluk = "";
            int soyadBoslukSayi = soyadUzunluk - 2;
            string soyadBosluk = "";

            for (int i = 0; i < soyadBoslukSayi; i++)
            {
                soyadBosluk = soyadBosluk + " ";
            }

            for(int i = 0; i < adBoslukSayi; i++ )
            {
                adBosluk = adBosluk + " ";          
            }

            string adParca1 = ad.Substring(0, adUzunluk); // 0 - 3
            string adParca2 = ad.Substring(adUzunluk, adUzunluk); // 3-6
            string adParca3 = ad.Substring(2 * adUzunluk,adUzunluk);//6-9
            string adParca4 = ad.Substring(3 * adUzunluk, adUzunluk);//9-12

            string soyadParca1 = soyad.Substring(0, soyadUzunluk);
            string soyadParca2 = soyad.Substring(soyadUzunluk, soyadUzunluk);
            string soyadParca3 = soyad.Substring(2 * soyadUzunluk, soyadUzunluk);

            for (int k = 0; k < adUzunluk; k++)
            {
                if(k == 0)
                {
                    Console.WriteLine(adParca1);
                }

                Console.WriteLine(adParca2[k] + adBosluk+ adParca4[k]);

                if (k == adUzunluk-1)
                {
                    Console.WriteLine(adParca3);
                }              
            }


            Console.WriteLine(" ");

            for (int t = 0; t < soyadUzunluk; t++)
            {
                Console.WriteLine(soyadParca1[t] + soyadBosluk + soyadParca3[t]);

                if (t==soyadUzunluk-1)
                {
                    Console.WriteLine(soyadParca2);
                }               

            }
            Console.ReadLine();
        }
    }
}

