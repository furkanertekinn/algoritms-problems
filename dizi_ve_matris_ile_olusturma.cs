using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DiziOlusturma
{
    internal class Program
    {
        public static void Olustur(int sayi)
        {
            Console.WriteLine(" ");

            int[,] array = new int[sayi, 4];

            int x = 10;
            int y = 2;
            int z = 10;

            for (int i = 0; i < sayi; i++)
            {
                Console.Write(x);
                            
                for (int j = 1; j < 4; j++)
                {
                    array[i, j] = Convert.ToInt32(x);
                    x = x - y;
                    Console.Write(" "+x);
                    continue;                
                }
                x = 10;
                y++;
                x = x + z;
                z = z + 10;
                Console.WriteLine(" ");
                continue;
                
            }          

        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen 4 ile 8 arasında bir sayı giriniz : ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            bool sayiDogruluk = 4 <= sayi && sayi <= 8;
            if (sayiDogruluk)
            {
                Olustur(sayi);
            }

            else if (!sayiDogruluk)
            {
                Console.WriteLine(" ");
                Console.Write("Lütfen 4 ile 8 arasında bir sayı giriniz : ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen girdiğiniz değerin geçerliliğini kontrol ediniz!");
            }
            Console.ReadLine();
        }
    }
}
