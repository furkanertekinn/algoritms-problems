using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuvarla
{
    internal class Program
    {
        public static double Yuvarla(double sayi)
        {
            string deger = sayi.ToString();

            string once = "";
            string sonra = "";

            int konumNokta = deger.IndexOf(".");

            sonra = deger.Substring(konumNokta+1,2);
            once = deger.Substring(0, konumNokta);

            if (Convert.ToDouble(sonra) >= 50)
            {
                once = (Convert.ToDouble(once) + (1)).ToString();
                sonra = "0";
            }
            else if (Convert.ToDouble(sonra) < 50)
            {
                sonra = "0";
            }
        
            return Convert.ToDouble(once);
        }

        static void Main(string[] args)
        {
            Console.Write("Lütfen yuvarlamak istediğiniz sayıyı giriniz : ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Sonuç : " + Yuvarla(sayi));

            Console.ReadLine();
        }
    }
}
