using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeUyguluma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz!");
            Console.WriteLine(" ");
            Console.Write("Lütfen boyunuzu giriniz (cm) : ");
            string girilenBoy = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Lütfen kilonuzu giriniz (kg) : ");
            string girilenKilo = Console.ReadLine();


            double s1 = Convert.ToDouble(girilenBoy);
            double s2 = Convert.ToDouble(girilenKilo);
            double bolum = s1 / s2;
            Console.WriteLine("");
            Console.WriteLine("Sonuç : " + bolum);
            Console.WriteLine(" ");

            if (2.5 <= bolum)
            {
                Console.WriteLine("Üzgünüz! Kilonuz az, kilo almanız gerekiyor. ");
                Console.ReadLine();
            }
            else if (bolum < 2.5)
            {
                Console.WriteLine("Tebrikler! Kilonuz normal. Sağlıklı günler dileriz. ");
                Console.ReadLine();
            }
            else if (bolum <= 2)
            {
                Console.WriteLine("Üzgünüz! Kilonuz fazla, kilo vermeniz gerekiyor.");
                Console.ReadLine();
            }

        }
    }
}
