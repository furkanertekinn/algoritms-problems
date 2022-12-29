using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir yükseklik giriniz : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Sonuç : ");

            Console.WriteLine(" ");
            
            int yildiz = 1;

            while (0<yukseklik)
            {
                for (int i = 0; i < yukseklik-1; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <yildiz; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                yildiz = yildiz + 2;
                yukseklik--;
                continue;

            }
            Console.ReadLine();
        }
    }
}
