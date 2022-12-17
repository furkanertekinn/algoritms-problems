using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriHesabi
{
    internal class Program
    {
        public static int Seri(int x)
        {
            int sonuc = 0;

            for (int i = 0; i <=x; i++)
            {
                sonuc = sonuc + (i*i);
            }
            return sonuc;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz!");
            Console.Write("Lütfen bir X değeri giriniz : ");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Seri(x));
            Console.ReadLine();

        }
    }
}
