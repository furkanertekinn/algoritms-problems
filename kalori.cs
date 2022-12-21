using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesap
{
    internal class Program
    {
        public static int Kalori(int adimSayisi,string cinsiyet)
        {
            int erkekAdimUzunlugu = 45;
            int kadinAdimUzunlugu = 30;
            int kalori = 1;

            if (cinsiyet.ToUpper() == "ERKEK")
            {
                kalori = (adimSayisi * erkekAdimUzunlugu) / 500;

            }
            else if (cinsiyet.ToLower() == "KADIN")
            {
                kalori = (adimSayisi * kadinAdimUzunlugu) / 500;
            }

            else
            {
                Console.WriteLine("Lütfen cinsiyetinizi geçerli giriniz !");
            }

            return kalori;
        }
        public static void Main(string[] args)
        {

            Console.Write("Lütfen cinsiyetinizi giriniz : ");
            string cinsiyet = Console.ReadLine();

            Console.Write("Lütfen adım sayısını giriniz : ");
            int adimSayisi = Convert.ToInt32(Console.ReadLine());

            Kalori(adimSayisi,cinsiyet);
            Console.WriteLine("Günlük almanız gerekli kalori miktarı : "+Kalori(adimSayisi,cinsiyet));

            Console.ReadLine();  
        }
    }
}
