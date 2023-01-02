using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigasyon
{
    internal class Program
    {
        public static string YolBul(int[,] navigasyon)
        {
            string sonuc = "";

            int satir = navigasyon.Length / 5;
            int sutun = navigasyon.Length / 4;

            int i = 0;

            while (i < satir)
            {
                int j = 0;
                while (j < sutun)
                {
                    if (navigasyon[i, j] == 1)
                    {
                        sonuc = sonuc + " " + i + j;
                    }
                    j++;
                }
                i++;
            }

            Console.WriteLine("Navigasyonun izlediği yol : " + sonuc);

            return sonuc;
        }


        static void Main(string[] args)
        {
            int[,] navigasyon = new int[4, 5];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Lütfen değer olarak 0 veya 1 giriniz!");
                Console.WriteLine(" ");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0}][{1}] = ",i,j);
                    navigasyon[i,j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.Clear();
            }

            Console.Clear();

            Console.WriteLine("Girdiğiniz değerlere göre oluşan tablo :");
            Console.WriteLine(" ");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(navigasyon[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");

            YolBul(navigasyon);

            Console.ReadLine();


        }
    }
}
