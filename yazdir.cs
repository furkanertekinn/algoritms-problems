using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazdir
{
    internal class Program
    {
        public static void Yazdir(int baslangic,int adet, int artis)
        {
            Console.WriteLine(" ");
            Console.Write(baslangic);

            for (int i = 1; i < adet; i++)
            {
                baslangic = baslangic + artis;
                Console.Write(","+baslangic);
                
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen başlangıç sayınızı giriniz : ");
            int baslangic=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Kaç adet sayı ekrana yazdırmak istediğinizi giriniz : ");
            int adet=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Lütfen artış miktarınızı giriniz : ");
            int artis=Convert.ToInt32(Console.ReadLine());

            Yazdir(baslangic, adet, artis);


            Console.ReadLine();

        }
    }
}
