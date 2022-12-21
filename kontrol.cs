using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol
{
    internal class Program
    {
        public static int Yaz(int kontrol)
        {
            bool dogru = true;
            bool yanlis = false;

            bool sonuc = 1 <= kontrol && kontrol <= 10;

            int pay = 1;
            int payda = 2;

            Console.WriteLine(" ");
            Console.Write("Sonuç : {");

            if (sonuc == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" ");
                    Console.Write("{0}{1}", pay, payda);
                    pay++;
                    payda++;
                }
            }

            else if (sonuc == false)
            {
                HarfDongu(sonuc);
            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }

            Console.Write(" }");

            return 0;

        }

        public static string HarfDongu(bool sonuc)
        {
            char harf1;
            char harf2;

            for (harf1 = 'a'; harf1 <= 'e'; harf1++)
            {
                break;

            }
            for (harf2 = 'b'; harf2 <= 'f'; harf2++)
            {

                Console.Write(" ");
                Console.Write("{0}{1}", harf1, harf2);
                harf1++;

                continue;
            }

            return harf1.ToString();
        }
        public static void Main(string[] args)
        {
            Console.Write("Lütfen 1 ile 10 arası bir rakam giriniz : ");
            int kontrol = Convert.ToInt32(Console.ReadLine());

            Yaz(kontrol);

            Console.ReadLine();
        }


    }
}
