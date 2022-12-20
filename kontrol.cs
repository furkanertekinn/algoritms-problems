using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol1
{
    internal class Program
    {
        public static int Yaz(int kontrol)
        {
            bool dogru=true;
            bool yanlis = false;

            int sayi=Convert.ToInt32(kontrol);

            bool sonuc = 1 <= sayi && sayi <= 10;

            if (sonuc==true)      
            {
                while (true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Sonuç : {12 23 34 45 56}");
                    break;
                }
                   
            }

            else if (sonuc==false)
            {
                while (true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Sonuç : {ab bc cd de ef}");
                    break;
                }
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }         
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1 ile 10 arası bir değer giriniz : ");
            int kontrol=Convert.ToInt32(Console.ReadLine());

            Yaz(kontrol);

            Console.ReadLine();
        }
    }
}
