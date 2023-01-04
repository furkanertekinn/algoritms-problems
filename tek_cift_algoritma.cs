using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekCiftAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            int ciftToplam = 0;
            int tekToplam = 0;
            int sayi1;
            int i = 0;

            while (0<sayi)
            {      
                sayi1 =sayi % 10;
                sayi = sayi / 10;
                i++;
               
                
                if (sayi1 % 2 == 0) 
                {
                    ciftToplam = ciftToplam + sayi1;                   
                }

                else if (sayi1 % 2 != 0) 
                {
                    tekToplam= tekToplam + sayi1;                   
                }

                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz !");
                }
                continue;
            }

            Console.WriteLine("Çift rakamlar toplamı : " + ciftToplam);
            Console.WriteLine(" ");
            Console.WriteLine("Tek rakamlar toplamı : " + tekToplam);
            Console.WriteLine(" ");
            Console.WriteLine("Girilen sayı "  + i + " basamaklıdır");
            Console.WriteLine(" ");
            Console.WriteLine("Mutlak fark : " + Math.Abs(ciftToplam - tekToplam));

            Console.ReadLine();
        }
    }
}
