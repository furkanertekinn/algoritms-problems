using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemanSayisi
{
    internal class Program
    {
        public static int Goster(int elemanSayisi)
        {
            Random rnd=new Random();

            
            int[] dizicift = new int[elemanSayisi];
            int[] dizitek = new int[elemanSayisi];

            int diziciftelemansayi = 0;
            int dizitekelemansayi = 0;

            int sonuc = 0;

            for (int i = 0; i < elemanSayisi; i++)
            {
                int sayi = rnd.Next(0,99);

                if (sayi % 2 == 0 && sayi < 50)
                {
                    dizicift[diziciftelemansayi] = sayi;
                    diziciftelemansayi++;
                    Console.WriteLine("Dizi çift elemanı : "+sayi);
                }
                else if (sayi % 2 == 1 && sayi > 50)
                {
                    dizitek[dizitekelemansayi] = sayi;
                    dizitekelemansayi++;
                    Console.WriteLine("Dizi tek elemanı : "+sayi);
                }
                else
                {
                    Console.WriteLine("Sayı belirtilen koşullara uymuyor! - "+sayi);
                }
            }
            for (int i = 0; i < dizicift.Length; i++)
            {
                sonuc = sonuc + dizicift[i];
            }

            for (int i = 0; i < dizitek.Length; i++)
            {
                sonuc = sonuc + dizitek[i];
            }
            return sonuc;
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz!");
            Console.Write("Lütfen istediğiniz elaman sayısını giriniz : ");
            int elamanSayisi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dizilerin toplamı : "+Goster(elamanSayisi));
            Console.ReadLine();
        }
    }
}
