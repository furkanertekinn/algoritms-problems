using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degistir
{
    internal class Program
    {
        public static int Degistir(int[] dizi,int girilenDeger)
        {

            dizi[girilenDeger] = -1;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i+". İndeks'e gelen değer : "+dizi[i]);
            }
            return 0;
        }


         public static void Main(string[] args)
        {
            Console.Write("Lütfen oluşturmak istediğiniz dizinin boyutunu giriniz : ");
            int girilenDeger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            int[] dizi = new int[girilenDeger];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. İndex'e gelen değeri giriniz : ",i);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Lütfen değerini değiştirmek istediğiniz İndeks'i giriniz : ");
            int degisilenindex = Convert.ToInt32(Console.ReadLine());

            Degistir(dizi, degisilenindex);
            Console.ReadLine();
        }
    }
}
