using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineCalisma
{
    internal class Program
    {
        public static int Calisma(int makine, int ay)
        {
            bool ilkbaharYaz = 3 <= ay && ay <= 8;

            int saat = 0;
            int dakika = 0;
            int calisma = 0;
            int sonuc = 0;

            if (ilkbaharYaz)
            {
                saat = 8;
                dakika = 45;

                Console.WriteLine(" ");
                calisma = saat * 60;
                Console.Write(calisma);

                for (int i = 1; i < makine; i++)
                {
                    for (int j = 0; j < calisma; j++)
                    {
                        
                        sonuc = calisma - dakika;
                        Console.Write("-" + sonuc);
                        dakika = dakika + 45;
                        break;
                    }

                }

            }

            else if (!ilkbaharYaz)
            {
                saat = 9;
                dakika = 30;

                Console.WriteLine(" ");
                calisma = saat * 60;
                Console.Write(calisma);

                for (int i = 1; i < makine; i++)
                {
                    for (int j = 0; j < calisma; j++)
                    {
                       
                        sonuc = calisma - dakika;
                        Console.Write("-" + sonuc);
                        dakika = dakika + 30;
                        break;
                    }

                }
            }

            else
            {
                Console.WriteLine("Lütfen istenilen değerlerin doğruluğunu kontrol ediniz!");
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz!");
            Console.Write("Lütfen makine sayınızı giriniz : ");
            int makine = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen hangi ay içinde olduğunuzu giriniz : ");
            int ay = Convert.ToInt32(Console.ReadLine());

            Calisma(makine, ay);

            Console.ReadLine();
        }
    }
}
