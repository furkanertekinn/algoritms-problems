using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkekObebAlgoritma
{
    internal class Program
    {
        public static int ObebHesaplama(int sayi1, int sayi2)
        {
            if (sayi1 == sayi2)
            {
                Console.WriteLine("Lütfen farklı değerler giriniz!");
            }

            while (sayi1 != sayi2)
            {
                if (sayi1 > sayi2)
                {
                    sayi1 = sayi1 - sayi2;
                }
                else if (sayi1 < sayi2)
                {
                    sayi2 = sayi2 - sayi1; ;
                }

                else
                {

                }
            }
            return sayi1;
            
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz! OKEK hesabı yapacağınız sayıları giriniz");

            Console.Write("Lütfen KÜÇÜK sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen BÜYÜK sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ObebHesaplama(sayi1, sayi2));

            int OkekHesaplama = (sayi1 * sayi2) / (ObebHesaplama(sayi1,sayi2));

            Console.WriteLine("OKEK :"+OkekHesaplama);
            Console.WriteLine("OBEB : " + ObebHesaplama(sayi1, sayi2));

            Console.ReadLine();
           

        }
    }
}
