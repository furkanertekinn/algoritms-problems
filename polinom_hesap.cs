using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PolinomAlgoritmasi1
{
    internal class Program
    {
        public static double Polinomhesaplama(double[] dizi, double x)
        {
            double sonuc = 0;
            int i = 0;

            while (i<dizi.Length)
            {
                sonuc = sonuc + (dizi[i]*Math.Pow(x,i));
                i++;
            }
            return sonuc;
            
        } 

        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 5 tane değer giriniz :");

            double[] dizi = new double[5];

            dizi[0] = Convert.ToDouble(Console.ReadLine());
            dizi[1] = Convert.ToDouble(Console.ReadLine());
            dizi[2] = Convert.ToDouble(Console.ReadLine());
            dizi[3] = Convert.ToDouble(Console.ReadLine());
            dizi[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen bir X değeri giriniz : ");
            string degerx = Console.ReadLine();
            double x = Convert.ToDouble(degerx);

            Console.WriteLine(Polinomhesaplama( dizi,x ));
            Console.ReadLine();

        }
    }
}
